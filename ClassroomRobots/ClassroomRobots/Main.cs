using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClassroomRobots
{
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called When the Exit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        /// <summary>
        /// Called when the Save button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Called when the Open button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            //Create an Open Dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Set the filter
            openFileDialog.Filter = "CSV File (*.csv)|*.csv";

            //If the user has selected a file to open.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of the file.
                string path = openFileDialog.FileName;

                //The teachers Name.
                string teacher = "";

                //The Class Name.
                string className = "";

                //The Room Number.
                string roomNumber = "";

                //The List of students in the class.
                List<Student> students = new List<Student>();

                //Read the file.
                using (var reader = new StreamReader(@path))
                {
                    //While there are still lines in the file.
                    while (!reader.EndOfStream)
                    {
                        //Read the current line.
                        var line = reader.ReadLine();

                        //Split the line into the seperate values.
                        var values = line.Split(',');

                        //If this line is the Teacher.
                        if (values[0] == "%TEACHER%")
                        {
                            //Set the teachers name
                            teacher = values[1];
                        }
                        //If this line is the Class.
                        else if (values[0] == "%CLASS%")
                        {
                            //Set the class name
                            className = values[1];
                        }
                        //If this line is the Room Number.
                        else if (values[0] == "%ROOM%")
                        {
                            //Set the room number
                            roomNumber = values[1];
                        }
                        else
                        {

                            MessageBox.Show("Name: " + values[0] + "\n X: " + values[1] + "\n Y: " + values[2]);
                            //Add a new Student.
                            students.Add(new Student(values[0], Int32.Parse(values[1]), Int32.Parse(values[2])));
                        }
                    }
                }

                //After we read the file.
                //Check to see if we have all the requirments.

                if (string.IsNullOrEmpty(teacher) || string.IsNullOrEmpty(className) || string.IsNullOrEmpty(roomNumber))
                {
                    MessageBox.Show("Please input a classroom save file.");
                    MessageBox.Show("Teacher: " + teacher + "\n Class: " + className + "\n Room: " + roomNumber);
                }
                else
                {
                    //Create a new Classroom
                    Classroom classroom = new Classroom(teacher, className, roomNumber);
                    classroom.students = students;

                    //Load The new Classroom into the application
                    LoadClassroom(classroom);
                }
            }
        }

        /// <summary>
        /// Called when the Save As button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAs_Click(object sender, EventArgs e)
        {
            //Create a Save Dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Set the Filter
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv";

            //Show the Dialog
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Called when the New->Classroom button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClassroom_Btn_Click(object sender, EventArgs e)
        {
            //Create a New Classrom form.
            NewClassroom newClassroom = new NewClassroom(this);

            //Show the new form.
            newClassroom.Show();

            //Hide the main form.
            this.Hide();
        }

        /// <summary>
        /// Load the classroom.
        /// </summary>
        /// <param name="classroom"></param>
        private void LoadClassroom(Classroom classroom)
        {
            //Set the Techers Name text.
            Teacher_Input.Text = classroom.teacher;
            Teacher_Input.Enabled = true;

            //Set the Class Name's text.
            ClassName_Input.Text = classroom.className;
            ClassName_Input.Enabled = true;

            //Set the Room Number's text.
            RoomNumber_Input.Text = classroom.roomNumber;
            RoomNumber_Input.Enabled = true;
        }

        /// <summary>
        /// Load the Students into the DataGrid.
        /// </summary>
        private void LoadStudents()
        {

        }
    }
}
