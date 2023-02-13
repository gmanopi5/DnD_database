
namespace Presentation_Layer
{
    partial class frmDungeon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDamage = new System.Windows.Forms.Button();
            this.txtFeedBack = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.picMonster = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(261, 523);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(122, 44);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack(D20)";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDamage
            // 
            this.btnDamage.Location = new System.Drawing.Point(413, 523);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(122, 44);
            this.btnDamage.TabIndex = 1;
            this.btnDamage.Text = "Damage(1D6)";
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // txtFeedBack
            // 
            this.txtFeedBack.Location = new System.Drawing.Point(0, 378);
            this.txtFeedBack.Multiline = true;
            this.txtFeedBack.Name = "txtFeedBack";
            this.txtFeedBack.ReadOnly = true;
            this.txtFeedBack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedBack.Size = new System.Drawing.Size(847, 139);
            this.txtFeedBack.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(566, 523);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 44);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picMonster
            // 
            this.picMonster.Location = new System.Drawing.Point(265, 12);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(283, 360);
            this.picMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonster.TabIndex = 11;
            this.picMonster.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(111, 523);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 44);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start Encounter";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmDungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 609);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picMonster);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtFeedBack);
            this.Controls.Add(this.btnDamage);
            this.Controls.Add(this.btnAttack);
            this.Name = "frmDungeon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight a Monster";
            this.Load += new System.EventHandler(this.frmDungeon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.TextBox txtFeedBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picMonster;
        private System.Windows.Forms.Button btnStart;
    }
}