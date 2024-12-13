using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_controls.user_control
{
    public partial class stundetcontrols : UserControl
    {
        // Declare events to notify the parent form
        public event Action<string, int, string> AddStudent; // Triggered when a student is added
        public event Action<string> SearchStudent;           // Triggered when a search is performed

        public stundetcontrols()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Handle the Add button click event
            if (string.IsNullOrWhiteSpace(name_txt.Text) ||
                string.IsNullOrWhiteSpace(age_text.Text) ||
                string.IsNullOrWhiteSpace(grade_text.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a student.");
                return;
            }

            if (int.TryParse(age_text.Text, out int age)) // Validate age input
            {
                // Trigger the AddStudent event with user input
                AddStudent?.Invoke(name_txt.Text, age, grade_text.Text);

                // Optionally clear the input fields after adding
                name_txt.Clear();
                age_text.Clear();
                grade_text.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Age.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Handle the Search button click event
            if (string.IsNullOrWhiteSpace(name_txt.Text))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            // Trigger the SearchStudent event with the input name
            SearchStudent?.Invoke(name_txt.Text);
        }
    }
}