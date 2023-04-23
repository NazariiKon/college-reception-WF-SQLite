using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CollegeReception.Data;

namespace CollegeReception
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string query = "SELECT s.id, s.full_name, spec.Name, s.pass_number, " +
               "s.last_educational, s.graduation_date, s.award FROM students s " +
               "JOIN specialities spec ON s.speciality_id = spec.Id";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=College.db"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        studentsDataGridView.DataSource = table;
                    }
                }
            }
            setupGrid();
        }

        private void setupGrid()
        {
            studentsDataGridView.Columns[0].HeaderText = "Id";
            studentsDataGridView.Columns[1].HeaderText = "Name";
            studentsDataGridView.Columns[2].HeaderText = "Major";
            studentsDataGridView.Columns[3].HeaderText = "Passport Number";
            studentsDataGridView.Columns[4].HeaderText = "College";
            studentsDataGridView.Columns[5].HeaderText = "Graduation Date";
            studentsDataGridView.Columns[6].HeaderText = "Award";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT s.id, s.full_name, spec.Name, s.pass_number, " +
               "s.last_educational, s.graduation_date, s.award FROM students s " +
               "JOIN specialities spec ON s.speciality_id = spec.Id " +
               "WHERE s.full_name LIKE @searchValue " +
                    "OR spec.Name LIKE @searchValue " +
                    "OR s.pass_number LIKE @searchValue " +
                    "OR s.last_educational LIKE @searchValue " +
                    "OR s.graduation_date LIKE @searchValue " +
                    "OR s.award LIKE @searchValue ";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=College.db"))
            {
                connection.Open();

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@searchValue", "%" + searchBox.Text + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    studentsDataGridView.DataSource = table;
                    setupGrid();
                }
            }
        }

        private void studentsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = studentsDataGridView.SelectedRows[0];
                string[] columnNames = studentsDataGridView.Columns.Cast<DataGridViewColumn>()
                                  .Select(c => c.HeaderText)
                                  .ToArray();
                long id = (long)selectedRow.Cells[0].Value;
                string fullName = selectedRow.Cells[1].Value.ToString();
                string speciality = selectedRow.Cells[2].Value.ToString();
                long passNumber = (long)selectedRow.Cells[3].Value;
                string lastEducational = selectedRow.Cells[4].Value.ToString();
                string graduationDate = selectedRow.Cells[5].Value.ToString();
                string award = selectedRow.Cells[6].Value.ToString();

                // ñîçäàåì íîâûé îáúåêò êëàññà Student è ïðèñâàèâàåì åìó çíà÷åíèÿ èç âûáðàííîé ñòðîêè
                Student selectedStudent = new Student
                {
                    Id = id,
                    FullName = fullName,
                    PassNumber = passNumber,
                    LastEducational = lastEducational,
                    GraduationDate = graduationDate,
                    Award = award,
                    Info = speciality
                };

                StudentForm studentForm = new StudentForm(selectedStudent);
                studentForm.ShowDialog();
            }
        }
    }
}