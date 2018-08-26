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
        //The path of the file.
        public string path = "";

        /// <summary>
        /// The datatable.
        /// </summary>
        DataTable dataTable = new DataTable();

        /// <summary>
        /// Constructor.
        /// </summary>
        public Main()
        {
            //Initialize the Form.
            InitializeComponent();

            //Create the DataTable
            CreateTable();
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
                path = openFileDialog.FileName;

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
                        else if (!string.IsNullOrEmpty(teacher) && !string.IsNullOrEmpty(className) && !string.IsNullOrEmpty(roomNumber))
                        {
                            //Add a new Student.
                            students.Add(new Student(values[0], Int32.Parse(values[1]), Int32.Parse(values[2])));
                        }
                        else
                        {
                            //message user.
                            MessageBox.Show("Please input a classroom save file.");
                            return;
                        }
                    }
                }
                
                //Create a new Classroom
                Classroom classroom = new Classroom(teacher, className, roomNumber);
                classroom.students = students;

                //Load The new Classroom into the application
                LoadClassroom(classroom);
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
        /// Create the Datatable.
        /// </summary>
        private void CreateTable()
        {
            //Add the columns.
            dataTable.Columns.Add("1");
            dataTable.Columns.Add("2");
            dataTable.Columns.Add("3");
            dataTable.Columns.Add("4");
            dataTable.Columns.Add("5");
            dataTable.Columns.Add("6");
            dataTable.Columns.Add("7");
            dataTable.Columns.Add("8");
            dataTable.Columns.Add("9");
            dataTable.Columns.Add("10");

            //Set the datagrids datasource.
            data.DataSource = dataTable;

            //Load the friends into the table.
            //LoadTable();
        }

        /// <summary>
        /// Load the Students into the DataGrid.
        /// </summary>
        private void LoadStudents()
        {

        }
    }
}
