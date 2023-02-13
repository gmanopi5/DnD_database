using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace Presentation_Layer
{
    public partial class frmArticle : Form
    {
        ArticleLogic _monsterManager = null;
        List<Monster> _monsterList = null;
        int _currentMonster = -1;

        public frmArticle(ArticleLogic fl, List<Monster> fr, int cf)
        {
            _monsterManager = fl;
            _monsterList = fr;
            _currentMonster = cf;

            InitializeComponent();
        }

        private void frmArticle_Load(object sender, EventArgs e)
        {
            showArticle();
        }

        private void showArticle()
        {
            try
            {
                MonsterArticle article = _monsterManager.FetchMonsterArticle(_monsterList[_currentMonster]);
                lblTitle.Text = article.title;
                txtArticle.Text = article.ArticleText;
                txtArticle.SelectionStart = int.MaxValue;

                picMonsterImage.Image = Image.FromFile(AppData.DataPath + "\\" + _monsterList[_currentMonster].ImageFileName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
        }

        private void butNextArticle_Click(object sender, EventArgs e)
        {
            _currentMonster++;
            if (_currentMonster >= _monsterList.Count)
            {
                _currentMonster = 0;
            }
            showArticle();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _currentMonster--;
            if (_currentMonster < 0)
            {
                _currentMonster = _monsterList.Count -1;
            }
            showArticle();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
