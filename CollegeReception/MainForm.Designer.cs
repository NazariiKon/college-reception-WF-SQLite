namespace CollegeReception
{
    partial class MainForm
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
            addButton = new Button();
            searchButton = new Button();
            studentsDataGridView = new DataGridView();
            searchBoxWrapper = new Panel();
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            searchBoxWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(64, 64, 64);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(14, 57);
            addButton.Name = "addButton";
            addButton.Size = new Size(1304, 50);
            addButton.TabIndex = 5;
            addButton.Text = "Додати випускника";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(64, 64, 64);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1120, 9);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(198, 42);
            searchButton.TabIndex = 6;
            searchButton.Text = "Знайти";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            studentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentsDataGridView.BackgroundColor = SystemColors.Control;
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(14, 113);
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.RowHeadersWidth = 51;
            studentsDataGridView.RowTemplate.Height = 29;
            studentsDataGridView.Size = new Size(1304, 608);
            studentsDataGridView.TabIndex = 7;
            studentsDataGridView.DoubleClick += studentsDataGridView_DoubleClick;
            // 
            // searchBoxWrapper
            // 
            searchBoxWrapper.BackColor = Color.White;
            searchBoxWrapper.BorderStyle = BorderStyle.FixedSingle;
            searchBoxWrapper.Controls.Add(searchBox);
            searchBoxWrapper.Location = new Point(14, 9);
            searchBoxWrapper.Name = "searchBoxWrapper";
            searchBoxWrapper.Size = new Size(1100, 40);
            searchBoxWrapper.TabIndex = 8;
            // 
            // searchBox
            // 
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchBox.BackColor = Color.White;
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.ForeColor = Color.Black;
            searchBox.Location = new Point(12, 5);
            searchBox.Margin = new Padding(0);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(1072, 27);
            searchBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 733);
            Controls.Add(searchBoxWrapper);
            Controls.Add(studentsDataGridView);
            Controls.Add(addButton);
            Controls.Add(searchButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Головна сторінка";
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            searchBoxWrapper.ResumeLayout(false);
            searchBoxWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button addButton;
        private Button searchButton;
        private DataGridView studentsDataGridView;
        private Panel searchBoxWrapper;
        private TextBox searchBox;
    }
}