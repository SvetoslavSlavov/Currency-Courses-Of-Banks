namespace Bank_System_Svetoslav_Slavov_1501681032
{
    partial class Form_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Report));
            this.label_show = new System.Windows.Forms.Label();
            this.comboBox_select = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.listBox_bank_report = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Enabled = false;
            this.label_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_show.Location = new System.Drawing.Point(63, 81);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(146, 25);
            this.label_show.TabIndex = 0;
            this.label_show.Text = "Виж отчет на:";
            this.label_show.Visible = false;
            // 
            // comboBox_select
            // 
            this.comboBox_select.Enabled = false;
            this.comboBox_select.FormattingEnabled = true;
            this.comboBox_select.Items.AddRange(new object[] {
            "Alpha Bank",
            "SGE",
            "Alianc",
            "DSK"});
            this.comboBox_select.Location = new System.Drawing.Point(220, 81);
            this.comboBox_select.Name = "comboBox_select";
            this.comboBox_select.Size = new System.Drawing.Size(201, 24);
            this.comboBox_select.TabIndex = 1;
            this.comboBox_select.Text = "---Избор на Банка---";
            this.comboBox_select.Visible = false;
            this.comboBox_select.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_SelectedIndexChanged);
            this.comboBox_select.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_select_KeyPress);
            // 
            // button_refresh
            // 
            this.button_refresh.Enabled = false;
            this.button_refresh.Location = new System.Drawing.Point(454, 77);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(132, 28);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "Обнови";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Visible = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(220, 151);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(201, 55);
            this.button_show.TabIndex = 3;
            this.button_show.Text = "Покажи";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // listBox_bank_report
            // 
            this.listBox_bank_report.Enabled = false;
            this.listBox_bank_report.FormattingEnabled = true;
            this.listBox_bank_report.ItemHeight = 16;
            this.listBox_bank_report.Location = new System.Drawing.Point(68, 245);
            this.listBox_bank_report.Name = "listBox_bank_report";
            this.listBox_bank_report.Size = new System.Drawing.Size(518, 212);
            this.listBox_bank_report.TabIndex = 4;
            this.listBox_bank_report.Visible = false;
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 478);
            this.Controls.Add(this.listBox_bank_report);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.comboBox_select);
            this.Controls.Add(this.label_show);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Report";
            this.Text = "Отчет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_show;
        private System.Windows.Forms.ComboBox comboBox_select;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.ListBox listBox_bank_report;
    }
}