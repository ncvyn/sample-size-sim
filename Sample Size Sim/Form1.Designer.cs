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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            SSButton = new Button();
            groupBox1 = new GroupBox();
            SSTextBox = new TextBox();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            PlayButton = new Button();
            RB9 = new RadioButton();
            label3 = new Label();
            RB8 = new RadioButton();
            RB7 = new RadioButton();
            RB6 = new RadioButton();
            RB5 = new RadioButton();
            label2 = new Label();
            RB4 = new RadioButton();
            RB3 = new RadioButton();
            RB2 = new RadioButton();
            RB1 = new RadioButton();
            button1 = new Button();
            DescriptionLabel = new Label();
            PSGroup.SuspendLayout();
            MEGroup.SuspendLayout();
            FGroup.SuspendLayout();
            ZSGroupBox.SuspendLayout();
            NPGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            PSGroup.Location = new Point(146, 12);
            PSGroup.Name = "PSGroup";
            PSGroup.Size = new Size(96, 95);
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
            MEGroup.Location = new Point(256, 12);
            MEGroup.Name = "MEGroup";
            MEGroup.Size = new Size(96, 95);
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
            FGroup.Location = new Point(36, 12);
            FGroup.Name = "FGroup";
            FGroup.Size = new Size(96, 95);
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
            ZSGroupBox.Location = new Point(366, 12);
            ZSGroupBox.Name = "ZSGroupBox";
            ZSGroupBox.Size = new Size(96, 95);
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
            label1.Location = new Point(391, 79);
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
            NPGroupBox.Location = new Point(476, 12);
            NPGroupBox.Name = "NPGroupBox";
            NPGroupBox.Size = new Size(96, 95);
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
            // SSButton
            // 
            SSButton.Location = new Point(13, 62);
            SSButton.Name = "SSButton";
            SSButton.Size = new Size(68, 23);
            SSButton.TabIndex = 9;
            SSButton.Text = "=";
            SSButton.UseVisualStyleBackColor = true;
            SSButton.Click += SSButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SSTextBox);
            groupBox1.Controls.Add(SSButton);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(586, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(96, 95);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sample Size";
            // 
            // SSTextBox
            // 
            SSTextBox.BackColor = SystemColors.Window;
            SSTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SSTextBox.Location = new Point(13, 21);
            SSTextBox.MaxLength = 5;
            SSTextBox.Name = "SSTextBox";
            SSTextBox.ReadOnly = true;
            SSTextBox.Size = new Size(68, 35);
            SSTextBox.TabIndex = 1;
            SSTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PlayButton);
            groupBox2.Controls.Add(RB9);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(RB8);
            groupBox2.Controls.Add(RB7);
            groupBox2.Controls.Add(RB6);
            groupBox2.Controls.Add(RB5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(RB4);
            groupBox2.Controls.Add(RB3);
            groupBox2.Controls.Add(RB2);
            groupBox2.Controls.Add(RB1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(574, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 306);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sampling Techniques";
            // 
            // PlayButton
            // 
            PlayButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayButton.Location = new Point(121, 132);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(39, 36);
            PlayButton.TabIndex = 13;
            PlayButton.Text = " ▶";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayAnimation;
            // 
            // RB9
            // 
            RB9.AutoSize = true;
            RB9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB9.Location = new Point(11, 269);
            RB9.Name = "RB9";
            RB9.Size = new Size(77, 19);
            RB9.TabIndex = 12;
            RB9.Text = "Purposive";
            RB9.UseVisualStyleBackColor = true;
            RB9.CheckedChanged += DoUpdateDescription;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 153);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 11;
            label3.Text = "Non-probability";
            // 
            // RB8
            // 
            RB8.AutoSize = true;
            RB8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB8.Location = new Point(11, 245);
            RB8.Name = "RB8";
            RB8.Size = new Size(58, 19);
            RB8.TabIndex = 10;
            RB8.Text = "Quota";
            RB8.UseVisualStyleBackColor = true;
            RB8.CheckedChanged += DoUpdateDescription;
            // 
            // RB7
            // 
            RB7.AutoSize = true;
            RB7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB7.Location = new Point(11, 221);
            RB7.Name = "RB7";
            RB7.Size = new Size(73, 19);
            RB7.TabIndex = 9;
            RB7.Text = "Snowball";
            RB7.UseVisualStyleBackColor = true;
            RB7.CheckedChanged += DoUpdateDescription;
            // 
            // RB6
            // 
            RB6.AutoSize = true;
            RB6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB6.Location = new Point(11, 197);
            RB6.Name = "RB6";
            RB6.Size = new Size(75, 19);
            RB6.TabIndex = 8;
            RB6.Text = "Voluntary";
            RB6.UseVisualStyleBackColor = true;
            RB6.CheckedChanged += DoUpdateDescription;
            // 
            // RB5
            // 
            RB5.AutoSize = true;
            RB5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB5.Location = new Point(11, 173);
            RB5.Name = "RB5";
            RB5.Size = new Size(94, 19);
            RB5.TabIndex = 7;
            RB5.Text = "Convenience";
            RB5.UseVisualStyleBackColor = true;
            RB5.CheckedChanged += DoUpdateDescription;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 24);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Probability";
            // 
            // RB4
            // 
            RB4.AutoSize = true;
            RB4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB4.Location = new Point(11, 116);
            RB4.Name = "RB4";
            RB4.Size = new Size(62, 19);
            RB4.TabIndex = 5;
            RB4.Text = "Cluster";
            RB4.UseVisualStyleBackColor = true;
            RB4.CheckedChanged += DoUpdateDescription;
            // 
            // RB3
            // 
            RB3.AutoSize = true;
            RB3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB3.Location = new Point(11, 92);
            RB3.Name = "RB3";
            RB3.Size = new Size(120, 19);
            RB3.TabIndex = 4;
            RB3.Text = "Stratified Random";
            RB3.UseVisualStyleBackColor = true;
            RB3.CheckedChanged += DoUpdateDescription;
            // 
            // RB2
            // 
            RB2.AutoSize = true;
            RB2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB2.Location = new Point(11, 68);
            RB2.Name = "RB2";
            RB2.Size = new Size(82, 19);
            RB2.TabIndex = 3;
            RB2.Text = "Systematic";
            RB2.UseVisualStyleBackColor = true;
            RB2.CheckedChanged += DoUpdateDescription;
            // 
            // RB1
            // 
            RB1.AutoSize = true;
            RB1.Checked = true;
            RB1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB1.Location = new Point(11, 44);
            RB1.Name = "RB1";
            RB1.Size = new Size(109, 19);
            RB1.TabIndex = 1;
            RB1.TabStop = true;
            RB1.Text = "Simple Random";
            RB1.UseVisualStyleBackColor = true;
            RB1.CheckedChanged += DoUpdateDescription;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(700, 13);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 20;
            button1.Text = "Credits";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Credits;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(583, 444);
            DescriptionLabel.MaximumSize = new Size(160, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(74, 15);
            DescriptionLabel.TabIndex = 21;
            DescriptionLabel.Text = "(description)";
            DescriptionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 561);
            Controls.Add(DescriptionLabel);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(NPGroupBox);
            Controls.Add(label1);
            Controls.Add(ZSGroupBox);
            Controls.Add(FGroup);
            Controls.Add(MEGroup);
            Controls.Add(PSGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Samplifier";
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button SSButton;
        private GroupBox groupBox1;
        private TextBox SSTextBox;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private RadioButton RB2;
        private RadioButton RB1;
        private Label label2;
        private RadioButton RB4;
        private RadioButton RB3;
        private RadioButton RB9;
        private Label label3;
        private RadioButton RB8;
        private RadioButton RB7;
        private RadioButton RB6;
        private RadioButton RB5;
        private Button PlayButton;
        private Button button1;
        private Label DescriptionLabel;
    }
}
