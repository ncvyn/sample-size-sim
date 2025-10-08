namespace Sample_Size_Sim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PSTextBox = new TextBox();
            PSButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            PSButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            PercentLabel = new Label();
            MEComboBox = new ComboBox();
            MEButton2 = new RadioButton();
            METextBox = new TextBox();
            MEButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // PSTextBox
            // 
            PSTextBox.BackColor = SystemColors.Window;
            PSTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PSTextBox.Location = new Point(30, 27);
            PSTextBox.MaxLength = 5;
            PSTextBox.Name = "PSTextBox";
            PSTextBox.Size = new Size(46, 23);
            PSTextBox.TabIndex = 0;
            PSTextBox.TextAlign = HorizontalAlignment.Right;
            PSTextBox.KeyPress += PSTextBox_KeyPress;
            // 
            // PSButton1
            // 
            PSButton1.AutoSize = true;
            PSButton1.Checked = true;
            PSButton1.Location = new Point(11, 32);
            PSButton1.Name = "PSButton1";
            PSButton1.Size = new Size(14, 13);
            PSButton1.TabIndex = 1;
            PSButton1.TabStop = true;
            PSButton1.UseVisualStyleBackColor = true;
            PSButton1.CheckedChanged += PSButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PSButton2);
            groupBox1.Controls.Add(PSTextBox);
            groupBox1.Controls.Add(PSButton1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(110, 103);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Population Size";
            // 
            // PSButton2
            // 
            PSButton2.AutoSize = true;
            PSButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PSButton2.Location = new Point(11, 64);
            PSButton2.Name = "PSButton2";
            PSButton2.Size = new Size(62, 19);
            PSButton2.TabIndex = 3;
            PSButton2.TabStop = true;
            PSButton2.Text = "Infinite";
            PSButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PercentLabel);
            groupBox2.Controls.Add(MEComboBox);
            groupBox2.Controls.Add(MEButton2);
            groupBox2.Controls.Add(METextBox);
            groupBox2.Controls.Add(MEButton1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(163, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(110, 103);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Margin of Error";
            // 
            // PercentLabel
            // 
            PercentLabel.AutoSize = true;
            PercentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PercentLabel.Location = new Point(59, 30);
            PercentLabel.Name = "PercentLabel";
            PercentLabel.Size = new Size(17, 15);
            PercentLabel.TabIndex = 4;
            PercentLabel.Text = "%";
            PercentLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // MEComboBox
            // 
            MEComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MEComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MEComboBox.FormattingEnabled = true;
            MEComboBox.Items.AddRange(new object[] { "2%", "5%", "10%" });
            MEComboBox.Location = new Point(30, 63);
            MEComboBox.Name = "MEComboBox";
            MEComboBox.Size = new Size(46, 23);
            MEComboBox.TabIndex = 4;
            // 
            // MEButton2
            // 
            MEButton2.AutoSize = true;
            MEButton2.Checked = true;
            MEButton2.Location = new Point(11, 67);
            MEButton2.Name = "MEButton2";
            MEButton2.Size = new Size(14, 13);
            MEButton2.TabIndex = 3;
            MEButton2.TabStop = true;
            MEButton2.UseVisualStyleBackColor = true;
            MEButton2.CheckedChanged += MEButton2_CheckedChanged;
            // 
            // METextBox
            // 
            METextBox.BackColor = SystemColors.Window;
            METextBox.Enabled = false;
            METextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            METextBox.Location = new Point(30, 27);
            METextBox.MaxLength = 3;
            METextBox.Name = "METextBox";
            METextBox.Size = new Size(31, 23);
            METextBox.TabIndex = 0;
            METextBox.TextAlign = HorizontalAlignment.Right;
            METextBox.KeyPress += METextBox_KeyPress;
            // 
            // MEButton1
            // 
            MEButton1.AutoSize = true;
            MEButton1.Location = new Point(11, 32);
            MEButton1.Name = "MEButton1";
            MEButton1.Size = new Size(14, 13);
            MEButton1.TabIndex = 1;
            MEButton1.UseVisualStyleBackColor = true;
            MEButton1.CheckedChanged += MEButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Sample Size Simulator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox PSTextBox;
        private RadioButton PSButton1;
        private GroupBox groupBox1;
        private RadioButton PSButton2;
        private GroupBox groupBox2;
        private RadioButton MEButton2;
        private RadioButton MEButton1;
        private ComboBox MEComboBox;
        private TextBox METextBox;
        private Label PercentLabel;
    }
}
