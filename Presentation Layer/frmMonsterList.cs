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
    public partial class frmMonsterList : Form
    {
        ArticleLogic _monsterManager = new ArticleLogic();
        List<Monster> _monsterList;

        public frmMonsterList()
        {
            InitializeComponent();
        }

        private void frmFruitList_Load(object sender, EventArgs e)
        {
            try
            {
                _monsterList = _monsterManager.FetchMonsterList();
                populateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message, "Data Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateList()
        {
            lstMonster.Items.Clear();
            for (int i = 0; i < _monsterList.Count; i++)
            {
                lstMonster.Items.Add(_monsterList[i].Name);

                lstMonster.Items[lstMonster.Items.Count - 1].SubItems.Add(_monsterList[i].Type);
                lstMonster.Items[lstMonster.Items.Count - 1].SubItems.Add(_monsterList[i].Size);
            }
        }

        private void btnReadArticle_Click(object sender, EventArgs e)
        {
            if(lstMonster.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an article.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //MessageBox.Show(lstFruit.SelectedItems[0].Index.ToString());

            int item = lstMonster.SelectedItems[0].Index;
            frmArticle acrticleForm = new frmArticle(_monsterManager, _monsterList, item);

            acrticleForm.ShowDialog();

        }

        private void lstFruit_DoubleClick(object sender, EventArgs e)
        {
            btnReadArticle_Click(sender, e);
        }

        private void btnDungeon_Click(object sender, EventArgs e)
        {
            frmDungeon dungeon = new frmDungeon();
            dungeon.ShowDialog();
        }
    }
}
