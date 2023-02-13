
namespace Presentation_Layer
{
    partial class frmArticle
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.picMonsterImage = new System.Windows.Forms.PictureBox();
            this.butNextArticle = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMonsterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtArticle
            // 
            this.txtArticle.Location = new System.Drawing.Point(25, 71);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.ReadOnly = true;
            this.txtArticle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArticle.Size = new System.Drawing.Size(284, 360);
            this.txtArticle.TabIndex = 1;
            // 
            // picMonsterImage
            // 
            this.picMonsterImage.Location = new System.Drawing.Point(324, 71);
            this.picMonsterImage.Name = "picMonsterImage";
            this.picMonsterImage.Size = new System.Drawing.Size(283, 360);
            this.picMonsterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonsterImage.TabIndex = 2;
            this.picMonsterImage.TabStop = false;
            // 
            // butNextArticle
            // 
            this.butNextArticle.Location = new System.Drawing.Point(121, 473);
            this.butNextArticle.Name = "butNextArticle";
            this.butNextArticle.Size = new System.Drawing.Size(101, 41);
            this.butNextArticle.TabIndex = 3;
            this.butNextArticle.Text = "Next Article";
            this.butNextArticle.UseVisualStyleBackColor = true;
            this.butNextArticle.Click += new System.EventHandler(this.butNextArticle_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(395, 473);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(101, 41);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(262, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 564);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.butNextArticle);
            this.Controls.Add(this.picMonsterImage);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Read About A Monster";
            this.Load += new System.EventHandler(this.frmArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMonsterImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.PictureBox picMonsterImage;
        private System.Windows.Forms.Button butNextArticle;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBack;
    }
}