namespace Bank_System_Svetoslav_Slavov_1501681032
{
    partial class Form_Bank_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bank_Converter));
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_To = new System.Windows.Forms.ComboBox();
            this.comboBox_From = new System.Windows.Forms.ComboBox();
            this.button_choose = new System.Windows.Forms.Button();
            this.comboBox_Banks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(62, 335);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(117, 26);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "Изтрий";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_to
            // 
            this.textBox_to.Enabled = false;
            this.textBox_to.Location = new System.Drawing.Point(438, 280);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(239, 22);
            this.textBox_to.TabIndex = 16;
            // 
            // textBox_from
            // 
            this.textBox_from.Location = new System.Drawing.Point(62, 280);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(239, 22);
            this.textBox_from.TabIndex = 15;
            this.textBox_from.TextChanged += new System.EventHandler(this.textBox_from_TextChanged);
            this.textBox_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_from_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(389, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "В";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "От";
            // 
            // comboBox_To
            // 
            this.comboBox_To.FormattingEnabled = true;
            this.comboBox_To.Location = new System.Drawing.Point(438, 227);
            this.comboBox_To.Name = "comboBox_To";
            this.comboBox_To.Size = new System.Drawing.Size(239, 24);
            this.comboBox_To.TabIndex = 12;
            // 
            // comboBox_From
            // 
            this.comboBox_From.FormattingEnabled = true;
            this.comboBox_From.Location = new System.Drawing.Point(62, 227);
            this.comboBox_From.Name = "comboBox_From";
            this.comboBox_From.Size = new System.Drawing.Size(239, 24);
            this.comboBox_From.TabIndex = 11;
            // 
            // button_choose
            // 
            this.button_choose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_choose.Location = new System.Drawing.Point(393, 65);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(248, 37);
            this.button_choose.TabIndex = 10;
            this.button_choose.Text = "Избери банка";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // comboBox_Banks
            // 
            this.comboBox_Banks.FormattingEnabled = true;
            this.comboBox_Banks.Items.AddRange(new object[] {
            "Alpha Bank",
            "SGE",
            "Alianc",
            "DSK"});
            this.comboBox_Banks.Location = new System.Drawing.Point(62, 72);
            this.comboBox_Banks.Name = "comboBox_Banks";
            this.comboBox_Banks.Size = new System.Drawing.Size(239, 24);
            this.comboBox_Banks.TabIndex = 0;
            this.comboBox_Banks.Text = "--Избери Банка--";
            this.comboBox_Banks.SelectedIndexChanged += new System.EventHandler(this.comboBox_Banks_SelectedIndexChanged);
            // 
            // Form_Bank_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 470);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_to);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_To);
            this.Controls.Add(this.comboBox_From);
            this.Controls.Add(this.button_choose);
            this.Controls.Add(this.comboBox_Banks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Bank_Converter";
            this.Text = "Калкулатор за валутни изчисления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_To;
        private System.Windows.Forms.ComboBox comboBox_From;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.ComboBox comboBox_Banks;
    }
}