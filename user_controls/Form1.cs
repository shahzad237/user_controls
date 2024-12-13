using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace user_controls
{
    public partial class Form1 : Form
    {
      
        private BindingList<Student> students;

        public Form1()
        {
            InitializeComponent();

            
            students = new BindingList<Student>();

            
            dataGridView1.DataSource = students;

            
            stundetcontrols1.AddStudent += OnAddStudent;
            stundetcontrols1.SearchStudent += OnSearchStudent;
        }

        private void stundetcontrols1_Load(object sender, EventArgs e)
        {
         
        }

       
        private void OnAddStudent(string name, int age, string grade)
        {
            
            students.Add(new Student
            {
                Name = name,
                Age = age,
                Grade = grade
            });

           
            dataGridView1.DataSource = new BindingList<Student>(students);

            MessageBox.Show("Student added successfully!");
        }

       
        private void OnSearchStudent(string name)
        {
           
            var filteredStudents = students
                .Where(student => student.Name.ToLower().Contains(name.ToLower()))
                .ToList();

            
            dataGridView1.DataSource = new BindingList<Student>(filteredStudents);

            // If no results, show a message
            if (!filteredStudents.Any())
            {
                MessageBox.Show("No students found matching the search query.");
            }
        }
    }

    // Student class to represent student data
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }
}
