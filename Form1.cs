using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            UpdateStudentList();
            LoadAdvisors();
        }

        private void LoadAdvisors()
        {
            advisors.Add(new Advisor("Dr.Kham", "CIS"));
            CmbAdvisor.Items.AddRange(advisors.Select(a => a.Name).ToArray());
        }

        private void UpdateStudentList()
        {
            dgvStudents.Rows.Clear();
            lstStuden.Items.Clear(); 
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(student.ID, student.Name, student.Major, student.Grade, student.Advisor.Name);
                lstStuden.Items.Add(student.Name); 
            }
        }

        private void btAddAdvisor_Click(object sender, EventArgs e)
        {
            string advisorName = tb_AdvisorName.Text;
            string advisorDepartment = tb_AdvisorMajor.Text;

            if (string.IsNullOrWhiteSpace(advisorName) || string.IsNullOrWhiteSpace(advisorDepartment))
            {
                MessageBox.Show("Please fill in all the advisor information.");
                return;
            }

            Advisor newAdvisor = new Advisor(advisorName, advisorDepartment);
            advisors.Add(newAdvisor);
            CmbAdvisor.Items.Add(newAdvisor.Name);
            MessageBox.Show("Advisor added successfully");
            tb_AdvisorName.Clear();
            tb_AdvisorMajor.Clear();
        }

        private void btAddSt_Click(object sender, EventArgs e)
        {
            string id = tbStId.Text;
            string name = tbStName.Text;
            string major = tbStMajor.Text;
            double grade;

            if (!double.TryParse(tbGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade.");
                return;
            }

            if (CmbAdvisor.SelectedItem == null)
            {
                MessageBox.Show("Please select an advisor.");
                return;
            }

            if (students.Any(s => s.ID == id))
            {
                MessageBox.Show("Student ID already exists. Please enter a new ID.");
                return;
            }

            string advisorName = CmbAdvisor.SelectedItem.ToString();
            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            Student student = new Student(id, name, major, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);

            UpdateStudentList();
            MessageBox.Show("Student added successfully.");
            tbStId.Clear();
            tbStName.Clear();
            tbStMajor.Clear();
            tbGrade.Clear();
        }

        private void InitializeDataGridView()
        {
            dgvStudents.Columns.Clear(); 
            dgvStudents.Columns.Add("ID", "Student ID");
            dgvStudents.Columns.Add("Name", "Name");
            dgvStudents.Columns.Add("Major", "Major");
            dgvStudents.Columns.Add("Grade", "Grade");
            dgvStudents.Columns.Add("Advisor", "Advisor");
        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = tbSearchStudent.Text.ToLower();
            var filteredStudents = students.Where(s => s.ID.ToLower().Contains(searchText) || s.Name.ToLower().Contains(searchText)).ToList();

            dgvStudents.Rows.Clear();

            if (filteredStudents.Count == 000)
            {
                MessageBox.Show("No data found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (filteredStudents.Count > 0)
            {
                MessageBox.Show("Data found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var student in filteredStudents)
                {
                    dgvStudents.Rows.Add(student.ID, student.Name, student.Major, student.Grade, student.Advisor.Name);
                }
            }
            else
            {
                foreach (var student in filteredStudents)
                {
                    dgvStudents.Rows.Add(student.ID, student.Name, student.Major, student.Grade, student.Advisor.Name);
                }
            }
        }
        private void lstStuden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStuden.SelectedIndex != -1)
            {
                
                string selectedName = lstStuden.SelectedItem.ToString();

                
                Student student = students.FirstOrDefault(s => s.Name == selectedName);

                
                if (student != null)
                {
                    lbStID.Text = student.ID;
                    lbStName.Text = student.Name;
                    lbStMajor.Text = student.Major;
                    lbGrade.Text = student.Grade.ToString();
                    lbAdvisor.Text = student.Advisor.Name;
                }
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudents.SelectedRows[0];

                lbStID.Text = selectedRow.Cells[0].Value.ToString();
                lbStName.Text = selectedRow.Cells[1].Value.ToString();
                lbStMajor.Text = selectedRow.Cells[2].Value.ToString();
                lbGrade.Text = selectedRow.Cells[3].Value.ToString();
                lbAdvisor.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btTopSt_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students recorded.");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            MessageBox.Show($"Top Student: {topStudent.Name} Grade: {topStudent.Grade} ");
        }
    }
}
