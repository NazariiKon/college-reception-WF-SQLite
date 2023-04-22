using CollegeReception.Data;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeReception
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            SQLiteDataReader reader = SQLiteReaderHelper.Request(@"SELECT * FROM specialities");
            string[] propertyNames = typeof(Speciality).GetProperties().Select(prop => prop.Name).ToArray();
            List<Speciality> students = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Speciality>(r, propertyNames));
            reader.Close();

            specialityComboBox.DataSource = students;
            specialityComboBox.ValueMember = "Name";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string pass = passIdTextBox.Text;
            string educational = educationTextBox.Text;
            long year = (long)yearGraduationNumericUpDown.Value;
            string award = awardTextBox.Text;
            Speciality speciality = specialityComboBox.SelectedItem as Speciality;

            string query = "INSERT INTO students " +
                "(full_name, pass_number, last_educational, graduation_date, award, speciality_id) " +
                "VALUES(@full_name, @pass_number, @last_educational, @graduation_date, @award, @speciality_id);";
            SQLiteReaderHelper.Request(query, name, pass, educational, year, award, speciality.Id);
            MessageBox.Show("Студент доданий!");
        }
    }
}
