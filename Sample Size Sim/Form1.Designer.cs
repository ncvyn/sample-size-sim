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
            ZSGroupBox = new GroupBox();
            PlusMinLabel1 = new Label();
            ZSComboBox = new ComboBox();
            ZSButton2 = new RadioButton();
            ZSTextBox = new TextBox();
            ZSButton1 = new RadioButton();
            label1 = new Label();
            NPGroupBox = new GroupBox();
            NPButton2 = new RadioButton();
            NPTextBox = new TextBox();
            NPButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            PSGroup.SuspendLayout();
            MEGroup.SuspendLayout();
            FGroup.SuspendLayout();
            ZSGroupBox.SuspendLayout();
            NPGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // PSTextBox
            // 
            PSTextBox.BackColor = SystemColors.Window;
            PSTextBox.Enabled = false;
            PSTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PSTextBox.Location = new Point(29, 30);
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
            PSButton1.Location = new Point(11, 35);
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
            PSGroup.Location = new Point(189, 23);
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
            MEGroup.Location = new Point(315, 23);
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
            PercentLabel.Location = new Point(61, 33);
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
            METextBox.Location = new Point(30, 30);
            METextBox.MaxLength = 3;
            METextBox.Name = "METextBox";
            METextBox.Size = new Size(32, 23);
            METextBox.TabIndex = 0;
            METextBox.Text = "3";
            METextBox.TextAlign = HorizontalAlignment.Right;
            METextBox.KeyPress += ShouldBlockKeyPress;
            // 
            // MEButton1
            // 
            MEButton1.AutoSize = true;
            MEButton1.Location = new Point(11, 35);
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
            FGroup.Location = new Point(63, 23);
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
            // ZSGroupBox
            // 
            ZSGroupBox.Controls.Add(PlusMinLabel1);
            ZSGroupBox.Controls.Add(ZSComboBox);
            ZSGroupBox.Controls.Add(ZSButton2);
            ZSGroupBox.Controls.Add(ZSTextBox);
            ZSGroupBox.Controls.Add(ZSButton1);
            ZSGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZSGroupBox.Location = new Point(442, 23);
            ZSGroupBox.Name = "ZSGroupBox";
            ZSGroupBox.Size = new Size(110, 103);
            ZSGroupBox.TabIndex = 5;
            ZSGroupBox.TabStop = false;
            ZSGroupBox.Text = "Z Score";
            // 
            // PlusMinLabel1
            // 
            PlusMinLabel1.AutoSize = true;
            PlusMinLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlusMinLabel1.Location = new Point(25, 33);
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
            ZSTextBox.Location = new Point(39, 30);
            ZSTextBox.MaxLength = 4;
            ZSTextBox.Name = "ZSTextBox";
            ZSTextBox.Size = new Size(47, 23);
            ZSTextBox.TabIndex = 0;
            ZSTextBox.Text = "2.17";
            ZSTextBox.TextAlign = HorizontalAlignment.Right;
            ZSTextBox.KeyPress += ShouldBlockKeyPress;
            // 
            // ZSButton1
            // 
            ZSButton1.AutoSize = true;
            ZSButton1.Location = new Point(11, 35);
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
            label1.Location = new Point(468, 104);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "±";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // NPGroupBox
            // 
            NPGroupBox.Controls.Add(NPButton2);
            NPGroupBox.Controls.Add(NPTextBox);
            NPGroupBox.Controls.Add(NPButton1);
            NPGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NPGroupBox.Location = new Point(570, 23);
            NPGroupBox.Name = "NPGroupBox";
            NPGroupBox.Size = new Size(151, 103);
            NPGroupBox.TabIndex = 7;
            NPGroupBox.TabStop = false;
            NPGroupBox.Text = "Population Proportion";
            // 
            // NPButton2
            // 
            NPButton2.AutoSize = true;
            NPButton2.Checked = true;
            NPButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NPButton2.Location = new Point(11, 64);
            NPButton2.Name = "NPButton2";
            NPButton2.Size = new Size(40, 19);
            NPButton2.TabIndex = 3;
            NPButton2.TabStop = true;
            NPButton2.Text = "0.5";
            NPButton2.UseVisualStyleBackColor = true;
            NPButton2.CheckedChanged += OnRadioButtonCheck;
            // 
            // NPTextBox
            // 
            NPTextBox.BackColor = SystemColors.Window;
            NPTextBox.Enabled = false;
            NPTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NPTextBox.Location = new Point(28, 30);
            NPTextBox.MaxLength = 5;
            NPTextBox.Name = "NPTextBox";
            NPTextBox.Size = new Size(36, 23);
            NPTextBox.TabIndex = 0;
            NPTextBox.Text = "0.3";
            NPTextBox.TextAlign = HorizontalAlignment.Right;
            NPTextBox.KeyPress += ShouldBlockKeyPress;
            // 
            // NPButton1
            // 
            NPButton1.AutoSize = true;
            NPButton1.Location = new Point(11, 35);
            NPButton1.Name = "NPButton1";
            NPButton1.Size = new Size(14, 13);
            NPButton1.TabIndex = 1;
            NPButton1.UseVisualStyleBackColor = true;
            NPButton1.CheckedChanged += OnRadioButtonCheck;
            // 
            // button1
            // 
            button1.Location = new Point(376, 207);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 8;
            button1.Text = "Simple Random";
            button1.UseVisualStyleBackColor = true;
            button1.Click += B1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(570, 207);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(376, 236);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 11;
            button3.Text = "Systematic";
            button3.UseVisualStyleBackColor = true;
            button3.Click += B3_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(570, 236);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(376, 265);
            button5.Name = "button5";
            button5.Size = new Size(122, 23);
            button5.TabIndex = 13;
            button5.Text = "Stratified Random";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(570, 265);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 12;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(376, 294);
            button7.Name = "button7";
            button7.Size = new Size(122, 23);
            button7.TabIndex = 15;
            button7.Text = "Cluster";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(571, 294);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 14;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new Point(570, 323);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 17;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Enabled = false;
            button10.Location = new Point(570, 352);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 16;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 561);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NPGroupBox);
            Controls.Add(label1);
            Controls.Add(ZSGroupBox);
            Controls.Add(FGroup);
            Controls.Add(MEGroup);
            Controls.Add(PSGroup);
            MaximizeBox = false;
            Name = "Form1";
            Text = "PR 2";
            Load += Form1_Load;
            PSGroup.ResumeLayout(false);
            PSGroup.PerformLayout();
            MEGroup.ResumeLayout(false);
            MEGroup.PerformLayout();
            FGroup.ResumeLayout(false);
            FGroup.PerformLayout();
            ZSGroupBox.ResumeLayout(false);
            ZSGroupBox.PerformLayout();
            NPGroupBox.ResumeLayout(false);
            NPGroupBox.PerformLayout();
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
        private GroupBox ZSGroupBox;
        private Label PlusMinLabel1;
        private ComboBox ZSComboBox;
        private RadioButton ZSButton2;
        private TextBox ZSTextBox;
        private RadioButton ZSButton1;
        private Label label1;
        private GroupBox NPGroupBox;
        private RadioButton NPButton2;
        private TextBox NPTextBox;
        private RadioButton NPButton1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
