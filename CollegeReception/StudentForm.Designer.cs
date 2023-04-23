namespace CollegeReception
{
    partial class StudentForm
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
            label2 = new Label();
            awardTextBox = new TextBox();
            label1 = new Label();
            educationTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            passIdLabel = new Label();
            passIdTextBox = new TextBox();
            yearGraduationLabel = new Label();
            groupLabel = new Label();
            yearTextBox = new TextBox();
            specialityTextBox = new TextBox();
            label3 = new Label();
            listBoxExam = new ListBox();
            groupTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxId = new TextBox();
            label7 = new Label();
            textBoxAssesment = new TextBox();
            label8 = new Label();
            textBoxExamDate = new TextBox();
            label9 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(13, 147);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 44;
            label2.Text = "Нагороди:";
            // 
            // awardTextBox
            // 
            awardTextBox.Location = new Point(132, 144);
            awardTextBox.Name = "awardTextBox";
            awardTextBox.Size = new Size(284, 27);
            awardTextBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.Location = new Point(13, 81);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 42;
            label1.Text = "Вчився в:";
            // 
            // educationTextBox
            // 
            educationTextBox.Location = new Point(132, 78);
            educationTextBox.Name = "educationTextBox";
            educationTextBox.Size = new Size(284, 27);
            educationTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(13, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(113, 23);
            nameLabel.TabIndex = 34;
            nameLabel.Text = "П.І.Б:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(132, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(284, 27);
            nameTextBox.TabIndex = 1;
            // 
            // passIdLabel
            // 
            passIdLabel.Location = new Point(13, 48);
            passIdLabel.Name = "passIdLabel";
            passIdLabel.Size = new Size(113, 23);
            passIdLabel.TabIndex = 36;
            passIdLabel.Text = "Паспорт:";
            // 
            // passIdTextBox
            // 
            passIdTextBox.Location = new Point(132, 45);
            passIdTextBox.Name = "passIdTextBox";
            passIdTextBox.Size = new Size(284, 27);
            passIdTextBox.TabIndex = 2;
            // 
            // yearGraduationLabel
            // 
            yearGraduationLabel.Location = new Point(13, 113);
            yearGraduationLabel.Name = "yearGraduationLabel";
            yearGraduationLabel.Size = new Size(113, 23);
            yearGraduationLabel.TabIndex = 38;
            yearGraduationLabel.Text = "Рік випуска:";
            // 
            // groupLabel
            // 
            groupLabel.Location = new Point(13, 181);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(113, 23);
            groupLabel.TabIndex = 40;
            groupLabel.Text = "Спеціальність:";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(132, 110);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(284, 27);
            yearTextBox.TabIndex = 46;
            // 
            // specialityTextBox
            // 
            specialityTextBox.Location = new Point(132, 177);
            specialityTextBox.Name = "specialityTextBox";
            specialityTextBox.Size = new Size(284, 27);
            specialityTextBox.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(422, 8);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 48;
            label3.Text = "Екзамени";
            // 
            // listBoxExam
            // 
            listBoxExam.FormattingEnabled = true;
            listBoxExam.ItemHeight = 20;
            listBoxExam.Location = new Point(422, 39);
            listBoxExam.Name = "listBoxExam";
            listBoxExam.Size = new Size(366, 164);
            listBoxExam.TabIndex = 49;
            listBoxExam.SelectedIndexChanged += listBoxExam_SelectedIndexChanged;
            // 
            // groupTextBox
            // 
            groupTextBox.Location = new Point(132, 293);
            groupTextBox.Name = "groupTextBox";
            groupTextBox.ReadOnly = true;
            groupTextBox.Size = new Size(284, 27);
            groupTextBox.TabIndex = 52;
            // 
            // label5
            // 
            label5.Location = new Point(13, 296);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 51;
            label5.Text = "Група:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 216);
            label6.Name = "label6";
            label6.Size = new Size(207, 28);
            label6.TabIndex = 53;
            label6.Text = "Екзаменаційний лист";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(132, 260);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(284, 27);
            textBoxId.TabIndex = 55;
            // 
            // label7
            // 
            label7.Location = new Point(13, 263);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 54;
            label7.Text = "Номер:";
            // 
            // textBoxAssesment
            // 
            textBoxAssesment.Location = new Point(488, 209);
            textBoxAssesment.Name = "textBoxAssesment";
            textBoxAssesment.Size = new Size(300, 27);
            textBoxAssesment.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 212);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 56;
            label8.Text = "Оцінка:";
            // 
            // textBoxExamDate
            // 
            textBoxExamDate.Location = new Point(488, 242);
            textBoxExamDate.Name = "textBoxExamDate";
            textBoxExamDate.ReadOnly = true;
            textBoxExamDate.Size = new Size(300, 27);
            textBoxExamDate.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(422, 245);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 58;
            label9.Text = "Дата:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(13, 432);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(775, 43);
            buttonSave.TabIndex = 60;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(buttonSave);
            Controls.Add(textBoxExamDate);
            Controls.Add(label9);
            Controls.Add(textBoxAssesment);
            Controls.Add(label8);
            Controls.Add(textBoxId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupTextBox);
            Controls.Add(label5);
            Controls.Add(listBoxExam);
            Controls.Add(label3);
            Controls.Add(specialityTextBox);
            Controls.Add(yearTextBox);
            Controls.Add(label2);
            Controls.Add(awardTextBox);
            Controls.Add(label1);
            Controls.Add(educationTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(passIdLabel);
            Controls.Add(passIdTextBox);
            Controls.Add(yearGraduationLabel);
            Controls.Add(groupLabel);
            Name = "StudentForm";
            Text = "Інформація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox awardTextBox;
        private Label label1;
        private TextBox educationTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label passIdLabel;
        private TextBox passIdTextBox;
        private Label yearGraduationLabel;
        private Label groupLabel;
        private TextBox yearTextBox;
        private TextBox specialityTextBox;
        private Label label3;
        private ListBox listBoxExam;
        private Label label4;
        private TextBox groupTextBox;
        private Label label5;
        private Label label6;
        private TextBox textBoxId;
        private Label label7;
        private TextBox textBoxAssesment;
        private Label label8;
        private TextBox textBoxExamDate;
        private Label label9;
        private Button buttonSave;
    }
}