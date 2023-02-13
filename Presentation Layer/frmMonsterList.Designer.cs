
namespace Presentation_Layer
{
    partial class frmMonsterList
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
            this.btnReadArticle = new System.Windows.Forms.Button();
            this.btnDungeon = new System.Windows.Forms.Button();
            this.lstMonster = new System.Windows.Forms.ListView();
            this.colMonster = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnReadArticle
            // 
            this.btnReadArticle.Location = new System.Drawing.Point(213, 350);
            this.btnReadArticle.Name = "btnReadArticle";
            this.btnReadArticle.Size = new System.Drawing.Size(109, 44);
            this.btnReadArticle.TabIndex = 1;
            this.btnReadArticle.Text = "Read Article";
            this.btnReadArticle.UseVisualStyleBackColor = true;
            this.btnReadArticle.Click += new System.EventHandler(this.btnReadArticle_Click);
            // 
            // btnDungeon
            // 
            this.btnDungeon.Location = new System.Drawing.Point(479, 350);
            this.btnDungeon.Name = "btnDungeon";
            this.btnDungeon.Size = new System.Drawing.Size(109, 44);
            this.btnDungeon.TabIndex = 3;
            this.btnDungeon.Text = "Dungeon";
            this.btnDungeon.UseVisualStyleBackColor = true;
            this.btnDungeon.Click += new System.EventHandler(this.btnDungeon_Click);
            // 
            // lstMonster
            // 
            this.lstMonster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMonster,
            this.colType,
            this.colSize});
            this.lstMonster.FullRowSelect = true;
            this.lstMonster.GridLines = true;
            this.lstMonster.HideSelection = false;
            this.lstMonster.Location = new System.Drawing.Point(105, 61);
            this.lstMonster.MultiSelect = false;
            this.lstMonster.Name = "lstMonster";
            this.lstMonster.Size = new System.Drawing.Size(602, 253);
            this.lstMonster.TabIndex = 4;
            this.lstMonster.UseCompatibleStateImageBehavior = false;
            this.lstMonster.View = System.Windows.Forms.View.Details;
            this.lstMonster.DoubleClick += new System.EventHandler(this.lstFruit_DoubleClick);
            // 
            // colMonster
            // 
            this.colMonster.Text = "Monster Name";
            this.colMonster.Width = 107;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 133;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 91;
            // 
            // frmMonsterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMonster);
            this.Controls.Add(this.btnDungeon);
            this.Controls.Add(this.btnReadArticle);
            this.Name = "frmMonsterList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monster List";
            this.Load += new System.EventHandler(this.frmFruitList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadArticle;
        private System.Windows.Forms.Button btnDungeon;
        private System.Windows.Forms.ListView lstMonster;
        private System.Windows.Forms.ColumnHeader colMonster;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

