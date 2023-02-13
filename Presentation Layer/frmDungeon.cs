using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Reflection;
using DataObjects;
using LogicLayer;

namespace Presentation_Layer
{
    public partial class frmDungeon : Form
    {
        private int _playerHealth = 500;
        private int _playerAC = 16;
        private int _enemyHp = 0;
        private int _enemyAC = 0;
        public frmDungeon()
        {
            InitializeComponent();
        }

        Random randGen = new Random();

        public void resetGame()
        {
            btnAttack.Enabled = false;
            btnDamage.Enabled = false;
            btnStart.Enabled = true;
            btnNext.Enabled = false;
        }

        public void enemyAttack()
        {
            this.txtFeedBack.Text += "It attacks." + "\n";
            if (randGen.Next(1, 20) >= _playerAC)
            {
                this.txtFeedBack.Text += "It hits. Now it rolls for attack." + "\n";
                _playerHealth -= randGen.Next(1, 6);
                this.txtFeedBack.Text += "You have " + _playerHealth + " health" + "\n";
                if (_playerHealth <= 0)
                {
                    MessageBox.Show("You Died\n\nStart agian", "DEATH!" + "\n",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _playerHealth = 500;
                    resetGame();
                }
                btnAttack.Enabled = true;
                btnDamage.Enabled = false;
                btnStart.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                this.txtFeedBack.Text += "It missed. Roll for attack." + "\n";
                btnAttack.Enabled = true;
                btnDamage.Enabled = false;
                btnStart.Enabled = false;
                btnNext.Enabled = false;
            }
        }

        private void frmDungeon_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(@"C:\Users\gopi5\Documents\School\NET Dev\Final\Presentation Layer\bin\Debug\monsterdata", "*.png");
            List<string> images = paths.ToList();
            picMonster.ImageLocation = paths[randGen.Next(0, images.Count - 1)];
            _enemyAC = randGen.Next(1, 19);
            _enemyHp = randGen.Next(10, 100);
            this.txtFeedBack.Text += "A enemy apperared it has " + _enemyHp + " health and " + _enemyAC + " armor, roll to Attack." + "\n";
            btnAttack.Enabled = true;
            btnDamage.Enabled = false;
            btnStart.Enabled = false;
            btnNext.Enabled = false;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (randGen.Next(1, 20) >= _enemyAC)
            {
                this.txtFeedBack.Text += "You hit it roll for Damage." + "\n";
                btnAttack.Enabled = false;
                btnDamage.Enabled = true;
                btnStart.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                this.txtFeedBack.Text += "You missed, it attacks." + "\n";
                btnAttack.Enabled = false;
                btnDamage.Enabled = false;
                btnStart.Enabled = false;
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            enemyAttack();
        }

        private void btnDamage_Click(object sender, EventArgs e)
        { 
            _enemyHp -= randGen.Next(1, 6);
            this.txtFeedBack.Text += "It has " + _enemyHp + " health" + "\n";
            btnAttack.Enabled = false;
            btnDamage.Enabled = false;
            btnStart.Enabled = false;
            btnNext.Enabled = true;
            if (_enemyHp <= 0)
            {
                MessageBox.Show("You've won\n\nStart agian", "VICTORY!",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            };
        }
    }
}
