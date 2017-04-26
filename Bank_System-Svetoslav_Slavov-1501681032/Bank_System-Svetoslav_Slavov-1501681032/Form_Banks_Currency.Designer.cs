namespace Bank_System_Svetoslav_Slavov_1501681032
{
    partial class Form_Banks_Currency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Banks_Currency));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete_Currency = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.label_equal = new System.Windows.Forms.Label();
            this.lbl_ToBGN = new System.Windows.Forms.Label();
            this.textBox_Lv = new System.Windows.Forms.TextBox();
            this.comboBox_select_value = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox_Banks = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox_Currency = new System.Windows.Forms.ListBox();
            this.groupBox_Banks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Избери валута";
            // 
            // button_Delete_Currency
            // 
            this.button_Delete_Currency.Location = new System.Drawing.Point(545, 517);
            this.button_Delete_Currency.Name = "button_Delete_Currency";
            this.button_Delete_Currency.Size = new System.Drawing.Size(75, 23);
            this.button_Delete_Currency.TabIndex = 55;
            this.button_Delete_Currency.Text = "Изтрий";
            this.button_Delete_Currency.UseVisualStyleBackColor = true;
            this.button_Delete_Currency.Click += new System.EventHandler(this.button_Delete_Currency_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(401, 517);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 54;
            this.button_Add.Text = "Добави";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(537, 461);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(100, 22);
            this.textBox_value.TabIndex = 53;
            this.textBox_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_value_KeyPress);
            // 
            // label_equal
            // 
            this.label_equal.AutoSize = true;
            this.label_equal.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_equal.Location = new System.Drawing.Point(500, 455);
            this.label_equal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_equal.Name = "label_equal";
            this.label_equal.Size = new System.Drawing.Size(30, 31);
            this.label_equal.TabIndex = 52;
            this.label_equal.Text = "=";
            // 
            // lbl_ToBGN
            // 
            this.lbl_ToBGN.AutoSize = true;
            this.lbl_ToBGN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ToBGN.Location = new System.Drawing.Point(536, 431);
            this.lbl_ToBGN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ToBGN.Name = "lbl_ToBGN";
            this.lbl_ToBGN.Size = new System.Drawing.Size(86, 17);
            this.lbl_ToBGN.TabIndex = 51;
            this.lbl_ToBGN.Text = "BGN (лeвa)";
            // 
            // textBox_Lv
            // 
            this.textBox_Lv.Enabled = false;
            this.textBox_Lv.Location = new System.Drawing.Point(392, 461);
            this.textBox_Lv.Name = "textBox_Lv";
            this.textBox_Lv.Size = new System.Drawing.Size(100, 22);
            this.textBox_Lv.TabIndex = 50;
            this.textBox_Lv.Text = "1";
            // 
            // comboBox_select_value
            // 
            this.comboBox_select_value.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_select_value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_value.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_select_value.FormattingEnabled = true;
            this.comboBox_select_value.Items.AddRange(new object[] {
            "Британска лира(GBP)",
            "Евро(EUR)",
            "Руска рубла(RUB)",
            "Щатски долар(USD)",
            "Японска йена(JPY)"});
            this.comboBox_select_value.Location = new System.Drawing.Point(392, 380);
            this.comboBox_select_value.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_select_value.Name = "comboBox_select_value";
            this.comboBox_select_value.Size = new System.Drawing.Size(199, 28);
            this.comboBox_select_value.TabIndex = 49;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(406, 288);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(259, 39);
            this.button_Delete.TabIndex = 48;
            this.button_Delete.Text = "Изтриване на селектираните данни";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox_Banks
            // 
            this.groupBox_Banks.Controls.Add(this.radioButton4);
            this.groupBox_Banks.Controls.Add(this.radioButton3);
            this.groupBox_Banks.Controls.Add(this.radioButton2);
            this.groupBox_Banks.Controls.Add(this.radioButton1);
            this.groupBox_Banks.Location = new System.Drawing.Point(406, 22);
            this.groupBox_Banks.Name = "groupBox_Banks";
            this.groupBox_Banks.Size = new System.Drawing.Size(300, 260);
            this.groupBox_Banks.TabIndex = 47;
            this.groupBox_Banks.TabStop = false;
            this.groupBox_Banks.Text = "Банки";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 174);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(102, 21);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Банка ДСК";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 127);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(181, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Алианц Банк България";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(280, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Societe Generale Експресбанк (SGEB)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Alpha Bank";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox_Currency
            // 
            this.listBox_Currency.FormattingEnabled = true;
            this.listBox_Currency.ItemHeight = 16;
            this.listBox_Currency.Location = new System.Drawing.Point(19, 22);
            this.listBox_Currency.Name = "listBox_Currency";
            this.listBox_Currency.Size = new System.Drawing.Size(319, 500);
            this.listBox_Currency.TabIndex = 46;
            // 
            // Form_Banks_Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Delete_Currency);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.label_equal);
            this.Controls.Add(this.lbl_ToBGN);
            this.Controls.Add(this.textBox_Lv);
            this.Controls.Add(this.comboBox_select_value);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.groupBox_Banks);
            this.Controls.Add(this.listBox_Currency);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Banks_Currency";
            this.Text = "Обслужващи банки и основни валути ";
            this.groupBox_Banks.ResumeLayout(false);
            this.groupBox_Banks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete_Currency;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label_equal;
        private System.Windows.Forms.Label lbl_ToBGN;
        private System.Windows.Forms.TextBox textBox_Lv;
        private System.Windows.Forms.ComboBox comboBox_select_value;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox_Banks;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox_Currency;
    }
}