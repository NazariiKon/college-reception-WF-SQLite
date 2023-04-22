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
    public partial class StudentForm : Form
    {
        public StudentForm(Student student)
        {
            InitializeComponent();
            nameTextBox.Text = student.FullName;
            passIdTextBox.Text = student.PassNumber.ToString();
            educationTextBox.Text = student.LastEducational;
            yearTextBox.Text = student.GraduationDate;
            awardTextBox.Text = student.Award;
            specialityTextBox.Text = student.Info;

            string query = "SELECT * FROM specialities WHERE name = '" + student.Info + "'";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            string[] propertyNames = typeof(Speciality).GetProperties().Select(prop => prop.Name).ToArray();
            Speciality speciality = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Speciality>(r, propertyNames)).FirstOrDefault();
            reader.Close();

            Random rand = new Random();
            textBoxId.Text = rand.Next(1, 1000).ToString();
            groupTextBox.Text = speciality.ShortName;
        }
    }
}
