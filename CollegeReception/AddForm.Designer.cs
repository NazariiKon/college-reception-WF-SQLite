namespace CollegeReception
{
    partial class AddForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            passIdLabel = new Label();
            passIdTextBox = new TextBox();
            yearGraduationLabel = new Label();
            yearGraduationNumericUpDown = new NumericUpDown();
            groupLabel = new Label();
            specialityComboBox = new ComboBox();
            addButton = new Button();
            label1 = new Label();
            educationTextBox = new TextBox();
            label2 = new Label();
            awardTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)yearGraduationNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(12, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(113, 23);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "П.І.Б:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(131, 9);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(284, 27);
            nameTextBox.TabIndex = 16;
            // 
            // passIdLabel
            // 
            passIdLabel.Location = new Point(12, 45);
            passIdLabel.Name = "passIdLabel";
            passIdLabel.Size = new Size(113, 23);
            passIdLabel.TabIndex = 19;
            passIdLabel.Text = "Паспорт:";
            // 
            // passIdTextBox
            // 
            passIdTextBox.Location = new Point(131, 42);
            passIdTextBox.Name = "passIdTextBox";
            passIdTextBox.Size = new Size(284, 27);
            passIdTextBox.TabIndex = 20;
            // 
            // yearGraduationLabel
            // 
            yearGraduationLabel.Location = new Point(12, 110);
            yearGraduationLabel.Name = "yearGraduationLabel";
            yearGraduationLabel.Size = new Size(113, 23);
            yearGraduationLabel.TabIndex = 21;
            yearGraduationLabel.Text = "Рік випуска:";
            // 
            // yearGraduationNumericUpDown
            // 
            yearGraduationNumericUpDown.Location = new Point(131, 108);
            yearGraduationNumericUpDown.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            yearGraduationNumericUpDown.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            yearGraduationNumericUpDown.Name = "yearGraduationNumericUpDown";
            yearGraduationNumericUpDown.Size = new Size(284, 27);
            yearGraduationNumericUpDown.TabIndex = 22;
            yearGraduationNumericUpDown.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // groupLabel
            // 
            groupLabel.Location = new Point(10, 177);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(113, 23);
            groupLabel.TabIndex = 27;
            groupLabel.Text = "Спеціальність:";
            // 
            // specialityComboBox
            // 
            specialityComboBox.Location = new Point(131, 174);
            specialityComboBox.Name = "specialityComboBox";
            specialityComboBox.Size = new Size(282, 28);
            specialityComboBox.TabIndex = 28;
            // 
            // addButton
            // 
            addButton.Location = new Point(10, 208);
            addButton.Name = "addButton";
            addButton.Size = new Size(403, 36);
            addButton.TabIndex = 29;
            addButton.Text = "Додати";
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 30;
            label1.Text = "Вчився в:";
            // 
            // educationTextBox
            // 
            educationTextBox.Location = new Point(131, 75);
            educationTextBox.Name = "educationTextBox";
            educationTextBox.Size = new Size(284, 27);
            educationTextBox.TabIndex = 31;
            // 
            // label2
            // 
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 32;
            label2.Text = "Нагороди:";
            // 
            // awardTextBox
            // 
            awardTextBox.Location = new Point(131, 141);
            awardTextBox.Name = "awardTextBox";
            awardTextBox.Size = new Size(284, 27);
            awardTextBox.TabIndex = 33;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 251);
            Controls.Add(label2);
            Controls.Add(awardTextBox);
            Controls.Add(label1);
            Controls.Add(educationTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(passIdLabel);
            Controls.Add(passIdTextBox);
            Controls.Add(yearGraduationLabel);
            Controls.Add(yearGraduationNumericUpDown);
            Controls.Add(groupLabel);
            Controls.Add(specialityComboBox);
            Controls.Add(addButton);
            Name = "AddForm";
            Text = "Додавання абітурієнта";
            ((System.ComponentModel.ISupportInitialize)yearGraduationNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label passIdLabel;
        private TextBox passIdTextBox;
        private Label yearGraduationLabel;
        private NumericUpDown yearGraduationNumericUpDown;
        private Label groupLabel;
        private ComboBox specialityComboBox;
        private Button addButton;
        private Label label1;
        private TextBox educationTextBox;
        private Label label2;
        private TextBox awardTextBox;
    }
}