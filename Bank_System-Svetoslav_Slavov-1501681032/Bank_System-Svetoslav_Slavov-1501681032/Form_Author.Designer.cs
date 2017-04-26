namespace Bank_System_Svetoslav_Slavov_1501681032
{
    partial class Form_Author
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Author));
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSTD = new System.Windows.Forms.Label();
            this.labelFac = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxMyPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBox_author = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_author)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(287, 398);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(251, 55);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Затвори";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "редовно обучение";
            // 
            // labelSTD
            // 
            this.labelSTD.AutoSize = true;
            this.labelSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSTD.Location = new System.Drawing.Point(12, 114);
            this.labelSTD.Name = "labelSTD";
            this.labelSTD.Size = new System.Drawing.Size(506, 64);
            this.labelSTD.TabIndex = 9;
            this.labelSTD.Text = "специалност:Софтуерни технологии \r\nи дизайн";
            // 
            // labelFac
            // 
            this.labelFac.AutoSize = true;
            this.labelFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFac.Location = new System.Drawing.Point(12, 71);
            this.labelFac.Name = "labelFac";
            this.labelFac.Size = new System.Drawing.Size(264, 32);
            this.labelFac.TabIndex = 8;
            this.labelFac.Text = "фак.№1501681032";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(397, 32);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Светослав Николаев Славов";
            // 
            // pictureBoxMyPhoto
            // 
            this.pictureBoxMyPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMyPhoto.Name = "pictureBoxMyPhoto";
            this.pictureBoxMyPhoto.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxMyPhoto.TabIndex = 0;
            this.pictureBoxMyPhoto.TabStop = false;
            // 
            // pictureBox_author
            // 
            this.pictureBox_author.Image = global::Bank_System_Svetoslav_Slavov_1501681032.Properties.Resources.Profil;
            this.pictureBox_author.Location = new System.Drawing.Point(574, 27);
            this.pictureBox_author.Name = "pictureBox_author";
            this.pictureBox_author.Size = new System.Drawing.Size(267, 313);
            this.pictureBox_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_author.TabIndex = 12;
            this.pictureBox_author.TabStop = false;
            // 
            // Form_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 481);
            this.Controls.Add(this.pictureBox_author);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSTD);
            this.Controls.Add(this.labelFac);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Author";
            this.Text = "Form_Author";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_author)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSTD;
        private System.Windows.Forms.Label labelFac;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxMyPhoto;
        private System.Windows.Forms.PictureBox pictureBox_author;
    }
}