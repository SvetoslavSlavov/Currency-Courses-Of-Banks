namespace Bank_System_Svetoslav_Slavov_1501681032
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетНаВалутитеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.валутенКалкулаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ms_MainMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ms_MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(956, 28);
            this.ms_MainMenu.TabIndex = 4;
            this.ms_MainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новToolStripMenuItem,
            this.изходToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новToolStripMenuItem
            // 
            this.новToolStripMenuItem.Name = "новToolStripMenuItem";
            this.новToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.новToolStripMenuItem.Text = "Нов";
            this.новToolStripMenuItem.Click += new System.EventHandler(this.новToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem1
            // 
            this.изходToolStripMenuItem1.Name = "изходToolStripMenuItem1";
            this.изходToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.изходToolStripMenuItem1.Text = "Изход";
            this.изходToolStripMenuItem1.Click += new System.EventHandler(this.изходToolStripMenuItem1_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетНаВалутитеToolStripMenuItem,
            this.валутенКалкулаторToolStripMenuItem});
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // отчетНаВалутитеToolStripMenuItem
            // 
            this.отчетНаВалутитеToolStripMenuItem.Name = "отчетНаВалутитеToolStripMenuItem";
            this.отчетНаВалутитеToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.отчетНаВалутитеToolStripMenuItem.Text = "Отчет на Валутите";
            this.отчетНаВалутитеToolStripMenuItem.Click += new System.EventHandler(this.отчетНаВалутитеToolStripMenuItem_Click);
            // 
            // валутенКалкулаторToolStripMenuItem
            // 
            this.валутенКалкулаторToolStripMenuItem.Name = "валутенКалкулаторToolStripMenuItem";
            this.валутенКалкулаторToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.валутенКалкулаторToolStripMenuItem.Text = "Валутен Калкулатор";
            this.валутенКалкулаторToolStripMenuItem.Click += new System.EventHandler(this.валутенКалкулаторToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заАвтораToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // заАвтораToolStripMenuItem
            // 
            this.заАвтораToolStripMenuItem.Name = "заАвтораToolStripMenuItem";
            this.заАвтораToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.заАвтораToolStripMenuItem.Text = "За автора";
            this.заАвтораToolStripMenuItem.Click += new System.EventHandler(this.заАвтораToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 768);
            this.Controls.Add(this.ms_MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетНаВалутитеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem валутенКалкулаторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заАвтораToolStripMenuItem;
    }
}

