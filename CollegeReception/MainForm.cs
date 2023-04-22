using System.Data.SQLite;
using System.Data;
using System.Drawing;

namespace CollegeReception
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string query = "SELECT s.full_name, spec.Name, s.pass_number, " +
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
            studentsDataGridView.Columns[0].HeaderText = "ФІО";
            studentsDataGridView.Columns[1].HeaderText = "Спеціальність";
            studentsDataGridView.Columns[2].HeaderText = "Паспорт";
            studentsDataGridView.Columns[3].HeaderText = "Вчився в";
            studentsDataGridView.Columns[4].HeaderText = "Закінчив в";
            studentsDataGridView.Columns[4].HeaderText = "Нагороди";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT s.full_name, spec.Name, s.pass_number, " +
               "s.last_educational, s.graduation_date, s.award FROM students s " +
               "JOIN specialities spec ON s.speciality_id = spec.Id " +
               "WHERE s.full_name = @searchValue " +
                    "OR spec.Name = @searchValue " +
                    "OR s.pass_number = @searchValue " +
                    "OR s.last_educational = @searchValue " +
                    "OR s.graduation_date = @searchValue " +
                    "OR s.award = @searchValue ";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=College.db"))
            {
                connection.Open();

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@searchValue", searchBox.Text);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    studentsDataGridView.DataSource = table;
                    setupGrid();
                }
            }

        }
    }
}