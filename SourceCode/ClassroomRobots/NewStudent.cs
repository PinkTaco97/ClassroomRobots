using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobots
{
    public partial class NewStudent : Form
    {

        //Reference to the Main form.
        public Main main;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="main"></param>
        public NewStudent(Main main)
        {
            //Initialize the forms components.
            InitializeComponent();

            //Set the main form.
            this.main = main;
        }

        /// <summary>
        /// Called when the form is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewStudent_Closing(object sender, FormClosingEventArgs e)
        {
            //Show the form.
            main.Show();
        }

        /// <summary>
        /// Called when the user clicks the AddStudent Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AddStudent_Click(object sender, EventArgs e)
        {
            //Get the Students name from the form.
            string name = Input_Name.Text;

            //If the name is empty.
            if (String.IsNullOrEmpty(name))
            {
                //Message the user.
                MessageBox.Show("Please enter a name.");

                return;
            }
            else
            {
                //Add a student to the Classroom.
                main.classroom.students.Add(new Student(name, 99, 99));

                //Load the Students
                main.LoadStudents();
            }

        }
    }
}
