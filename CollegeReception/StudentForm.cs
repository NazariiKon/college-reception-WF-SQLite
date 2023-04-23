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
using System.Xml.Linq;

namespace CollegeReception
{
    public partial class StudentForm : Form
    {
        Student _student = new Student();
        public StudentForm(Student student)
        {
            InitializeComponent();
            _student = student;
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

            query = "SELECT * FROM exam_stream WHERE speciality_id = " + speciality.Id;
            reader = SQLiteReaderHelper.Request(query);
            propertyNames = typeof(ExamStream).GetProperties().Select(prop => prop.Name).ToArray();
            List<ExamStream> examStreams = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<ExamStream>(r, propertyNames));
            reader.Close();

            query = "SELECT * FROM subjects WHERE id = ";
            for (int i = 0; i < examStreams.Count; i++)
            {
                query += examStreams[i].SubjectId;
                if (i + 1 < examStreams.Count) query += " OR id = ";

            }
            reader = SQLiteReaderHelper.Request(query);
            propertyNames = typeof(Subject).GetProperties().Select(prop => prop.Name).ToArray();
            List<Subject> subjects = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Subject>(r, propertyNames));
            reader.Close();

            listBoxExam.DisplayMember = "Name";
            listBoxExam.DataSource = subjects;
        }

        private void listBoxExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject subject = listBoxExam.SelectedItem as Subject;
            string query = "SELECT * FROM assessments WHERE subject_id = " + subject.Id +
                " AND student_id = " + _student.Id;
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            string[] propertyNames = typeof(Assessment).GetProperties().Select(prop => prop.Name).ToArray();
            Assessment assessment = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Assessment>(r, propertyNames)).FirstOrDefault();
            reader.Close();

            query = "SELECT * FROM exam_stream WHERE subject_id = " + subject.Id;
            reader = SQLiteReaderHelper.Request(query);
            propertyNames = typeof(ExamStream).GetProperties().Select(prop => prop.Name).ToArray();
            ExamStream examStream = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<ExamStream>(r, propertyNames)).FirstOrDefault();

            textBoxExamDate.Text = examStream.Date;
            if (DateTime.Parse(examStream.Date) < DateTime.Now)
                textBoxAssesment.Text = assessment.Assesment.ToString();
            else textBoxAssesment.Text = " ";
        }
    }
}
