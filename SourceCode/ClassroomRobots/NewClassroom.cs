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
    public partial class NewClassroom : Form
    {

        //Reference to the Main form.
        public Main main;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="main"></param>
        public NewClassroom(Main main)
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
        private void NewClassroom_Closing(object sender, FormClosingEventArgs e)
        {
            //Show the form.
            main.Show();
        }

        /// <summary>
        /// Called when the NewClassroom Form is loded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClassroom_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called when the Add Classroom Button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClassroom_Btn_Click(object sender, EventArgs e)
        {
            //Get all of the data from the form.
            string teacher = Input_TeacherName.Text;
            string className = Input_ClassName.Text;
            string roomName = Input_RoomName.Text;
            int size = Decimal.ToInt32(Input_RoomSize.Value);

            //If the teacher string is empty
            if (String.IsNullOrEmpty(teacher))
            {
                //Message the user.
                MessageBox.Show("Please input the teachers name.");

                return;
            }
            //If the class name is empty.
            else if (String.IsNullOrEmpty(className))
            {
                //Message the user.
                MessageBox.Show("Please input the class name.");

                return;
            }
            //If the room name is empty.
            else if (String.IsNullOrEmpty(roomName))
            {
                //Message the user.
                MessageBox.Show("Please input the room name.");

                return;
            }
            else
            {
                //Add a student to the classroom.
                main.classroom = new Classroom(teacher, className, roomName, size);

                //Close this window.
                this.Close();

                main.CreateTable(size);

                //Load The new Classroom into the application
                main.LoadClassroom();

                //Clear the Student table
                main.studentTable.Clear();

                //Show the main window.
                main.Show();
            }
        }
    }
}
