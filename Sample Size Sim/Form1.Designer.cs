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
            PSGroup = new GroupBox();
            PSButton2 = new RadioButton();
            MEGroup = new GroupBox();
            PercentLabel = new Label();
            MEComboBox = new ComboBox();
            MEButton2 = new RadioButton();
            METextBox = new TextBox();
            MEButton1 = new RadioButton();
            FGroup = new GroupBox();
            CochranButton = new RadioButton();
            SlovinButton = new RadioButton();
            groupBox1 = new GroupBox();
            PlusMinLabel1 = new Label();
            ZSComboBox = new ComboBox();
            ZSButton2 = new RadioButton();
            ZSTextBox = new TextBox();
            ZSButton1 = new RadioButton();
            label1 = new Label();
            PSGroup.SuspendLayout();
            MEGroup.SuspendLayout();
            FGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PSTextBox
            // 
            PSTextBox.BackColor = SystemColors.Window;
            PSTextBox.Enabled = false;
            PSTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PSTextBox.Location = new Point(30, 27);
            PSTextBox.MaxLength = 5;
            PSTextBox.Name = "PSTextBox";
            PSTextBox.Size = new Size(46, 23);
            PSTextBox.TabIndex = 0;
            PSTextBox.Text = "457";
            PSTextBox.TextAlign = HorizontalAlignment.Right;
            PSTextBox.KeyPress += ShouldBlockKeyPress;
            // 
            // PSButton1
            // 
            PSButton1.AutoSize = true;
            PSButton1.Location = new Point(11, 32);
            PSButton1.Name = "PSButton1";
            PSButton1.Size = new Size(14, 13);
            PSButton1.TabIndex = 1;
            PSButton1.UseVisualStyleBackColor = true;
            PSButton1.CheckedChanged += OnRadioButtonCheck;
            // 
            // PSGroup
            // 
            PSGroup.Controls.Add(PSButton2);
            PSGroup.Controls.Add(PSTextBox);
            PSGroup.Controls.Add(PSButton1);
            PSGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PSGroup.Location = new Point(163, 39);
            PSGroup.Name = "PSGroup";
            PSGroup.Size = new Size(110, 103);
            PSGroup.TabIndex = 2;
            PSGroup.TabStop = false;
            PSGroup.Text = "Population Size";
            // 
            // PSButton2
            // 
            PSButton2.AutoSize = true;
            PSButton2.Checked = true;
            PSButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PSButton2.Location = new Point(11, 64);
            PSButton2.Name = "PSButton2";
            PSButton2.Size = new Size(62, 19);
            PSButton2.TabIndex = 3;
            PSButton2.TabStop = true;
            PSButton2.Text = "Infinite";
            PSButton2.UseVisualStyleBackColor = true;
            // 
            // MEGroup
            // 
            MEGroup.Controls.Add(PercentLabel);
            MEGroup.Controls.Add(MEComboBox);
            MEGroup.Controls.Add(MEButton2);
            MEGroup.Controls.Add(METextBox);
            MEGroup.Controls.Add(MEButton1);
            MEGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MEGroup.Location = new Point(289, 39);
            MEGroup.Name = "MEGroup";
            MEGroup.Size = new Size(110, 103);
            MEGroup.TabIndex = 3;
            MEGroup.TabStop = false;
            MEGroup.Text = "Margin of Error";
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
            MEButton2.CheckedChanged += OnRadioButtonCheck;
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
            METextBox.Text = "3";
            METextBox.TextAlign = HorizontalAlignment.Right;
            METextBox.KeyPress += ShouldBlockKeyPress;
            // 
            // MEButton1
            // 
            MEButton1.AutoSize = true;
            MEButton1.Location = new Point(11, 32);
            MEButton1.Name = "MEButton1";
            MEButton1.Size = new Size(14, 13);
            MEButton1.TabIndex = 1;
            MEButton1.UseVisualStyleBackColor = true;
            MEButton1.CheckedChanged += OnRadioButtonCheck;
            // 
            // FGroup
            // 
            FGroup.Controls.Add(CochranButton);
            FGroup.Controls.Add(SlovinButton);
            FGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FGroup.Location = new Point(37, 38);
            FGroup.Name = "FGroup";
            FGroup.Size = new Size(110, 103);
            FGroup.TabIndex = 4;
            FGroup.TabStop = false;
            FGroup.Text = "Formula";
            // 
            // CochranButton
            // 
            CochranButton.AutoSize = true;
            CochranButton.Checked = true;
            CochranButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CochranButton.Location = new Point(11, 64);
            CochranButton.Name = "CochranButton";
            CochranButton.Size = new Size(70, 19);
            CochranButton.TabIndex = 3;
            CochranButton.TabStop = true;
            CochranButton.Text = "Cochran";
            CochranButton.UseVisualStyleBackColor = true;
            CochranButton.CheckedChanged += UpdateFormula;
            // 
            // SlovinButton
            // 
            SlovinButton.AutoSize = true;
            SlovinButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SlovinButton.Location = new Point(11, 32);
            SlovinButton.Name = "SlovinButton";
            SlovinButton.Size = new Size(57, 19);
            SlovinButton.TabIndex = 1;
            SlovinButton.Text = "Slovin";
            SlovinButton.UseVisualStyleBackColor = true;
            SlovinButton.CheckedChanged += UpdateFormula;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PlusMinLabel1);
            groupBox1.Controls.Add(ZSComboBox);
            groupBox1.Controls.Add(ZSButton2);
            groupBox1.Controls.Add(ZSTextBox);
            groupBox1.Controls.Add(ZSButton1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(416, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(110, 103);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Z Score";
            // 
            // PlusMinLabel1
            // 
            PlusMinLabel1.AutoSize = true;
            PlusMinLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlusMinLabel1.Location = new Point(25, 30);
            PlusMinLabel1.Name = "PlusMinLabel1";
            PlusMinLabel1.Size = new Size(15, 15);
            PlusMinLabel1.TabIndex = 4;
            PlusMinLabel1.Text = "±";
            PlusMinLabel1.TextAlign = ContentAlignment.TopRight;
            // 
            // ZSComboBox
            // 
            ZSComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ZSComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZSComboBox.FormattingEnabled = true;
            ZSComboBox.Items.AddRange(new object[] { "2.33", "1.96", "1.65" });
            ZSComboBox.Location = new Point(40, 63);
            ZSComboBox.Name = "ZSComboBox";
            ZSComboBox.Size = new Size(46, 23);
            ZSComboBox.TabIndex = 4;
            // 
            // ZSButton2
            // 
            ZSButton2.AutoSize = true;
            ZSButton2.Checked = true;
            ZSButton2.Location = new Point(11, 67);
            ZSButton2.Name = "ZSButton2";
            ZSButton2.Size = new Size(14, 13);
            ZSButton2.TabIndex = 3;
            ZSButton2.TabStop = true;
            ZSButton2.UseVisualStyleBackColor = true;
            ZSButton2.CheckedChanged += OnRadioButtonCheck;
            // 
            // ZSTextBox
            // 
            ZSTextBox.BackColor = SystemColors.Window;
            ZSTextBox.Enabled = false;
            ZSTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZSTextBox.Location = new Point(39, 27);
            ZSTextBox.MaxLength = 4;
            ZSTextBox.Name = "ZSTextBox";
            ZSTextBox.Size = new Size(47, 23);
            ZSTextBox.TabIndex = 0;
            ZSTextBox.TextAlign = HorizontalAlignment.Right;
            ZSTextBox.KeyPress += ShouldBlockKeyPress;
            // 
            // ZSButton1
            // 
            ZSButton1.AutoSize = true;
            ZSButton1.Location = new Point(11, 32);
            ZSButton1.Name = "ZSButton1";
            ZSButton1.Size = new Size(14, 13);
            ZSButton1.TabIndex = 1;
            ZSButton1.UseVisualStyleBackColor = true;
            ZSButton1.CheckedChanged += OnRadioButtonCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 104);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "±";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(FGroup);
            Controls.Add(MEGroup);
            Controls.Add(PSGroup);
            MaximizeBox = false;
            Name = "Form1";
            Text = "-=";
            PSGroup.ResumeLayout(false);
            PSGroup.PerformLayout();
            MEGroup.ResumeLayout(false);
            MEGroup.PerformLayout();
            FGroup.ResumeLayout(false);
            FGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PSTextBox;
        private RadioButton PSButton1;
        private GroupBox PSGroup;
        private RadioButton PSButton2;
        private GroupBox MEGroup;
        private RadioButton MEButton2;
        private RadioButton MEButton1;
        private ComboBox MEComboBox;
        private TextBox METextBox;
        private Label PercentLabel;
        private GroupBox FGroup;
        private RadioButton CochranButton;
        private TextBox textBox1;
        private RadioButton SlovinButton;
        private GroupBox groupBox1;
        private Label PlusMinLabel1;
        private ComboBox ZSComboBox;
        private RadioButton ZSButton2;
        private TextBox ZSTextBox;
        private RadioButton ZSButton1;
        private Label label1;
    }
}
