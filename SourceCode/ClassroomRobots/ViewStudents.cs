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
    public partial class ViewStudents : Form
    {
        /// <summary>
        /// Reference to the main Form.
        /// </summary>
        public Main main;

        /// <summary>
        /// The Binary Tree.
        /// </summary>
        Tree tree = new Tree();

        /// <summary>
        /// The Student Table.
        /// </summary>
        public DataTable studentTable;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="main"></param>
        public ViewStudents(Main main)
        {
            //Initialize the forms components.
            InitializeComponent();

            //Set the main form.
            this.main = main;

            //Create the table.
            CreateTable();
        }

        /// <summary>
        /// Creates the student table.
        /// </summary>
        public void CreateTable()
        {
            //Create the student Table
            studentTable = new DataTable();

            //Add the columns to the table
            studentTable.Columns.Add("Name");
            studentTable.Columns.Add("X");
            studentTable.Columns.Add("Y");

            //Set the Student Datas Data Source.
            StudentData.DataSource = studentTable;

            //Set the minimum width for the columns.
            foreach (DataGridViewColumn column in StudentData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.MinimumWidth = 115;
            }

            //If there are students in the Classroom.
            if (main.classroom.students.Count > 0)
            {
                for (int i = 0; i < main.classroom.students.Count; i++)
                {
                    //Add the number to the Binary Tree.
                    tree.AddValue(main.classroom.students[i]);
                }
            }

            //Load the students into the table
            LoadTable();
        }

        /// <summary>
        /// Loads the students into the table.
        /// </summary>
        public void LoadTable()
        {
            //Traverse the tree.
            tree.Traverse();

            //Create the new row.
            DataRow row;

            //If there are students in the class.
            if (tree.sorted.Count > 0)
            {
                
                //For each Student in the Class.
                for (int i = 0; i < tree.sorted.Count; i++)
                {
                    //Create a new row.
                    row = studentTable.NewRow();

                    //Add the data to the row.
                    row[0] = tree.sorted[i].value.name;
                    row[1] = tree.sorted[i].value.x;
                    row[2] = tree.sorted[i].value.y;

                    //Add the row to the table.
                    studentTable.Rows.Add(row);
                }
            }
        }

        /// <summary>
        /// Called when the window is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewStudents_Closing(object sender, FormClosingEventArgs e)
        {
            //Show the main form.
            main.Show();
        }

        /// <summary>
        /// Called when the Binary Search Button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Search_Click(object sender, EventArgs e)
        {
            //Get the input from the search bar.
            Student student = new Student(Input_Search.Text);

            //Search the Binary tree for the student.
            Node node = tree.Search(student);

            //If the search was successful.
            if(node != null)
            {
                //Set the student to slected in the table.
                StudentData.Rows[node.index].Selected = true;

                //Select the search box.
                Input_Search.SelectAll();
            }
            //The search was unsuccessful.
            else
            {
                //Alert the user that there was no match in the tree.
                MessageBox.Show("Couldn't Find '" + Input_Search.Text + "'");

                //Select the search box.
                Input_Search.SelectAll();
            }
        }
        
        /// <summary>
        /// Called when a Key is down when the search is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serach_KeyDown(object sender, KeyEventArgs e)
        {
            //If the Enter key was pressed.
            if (e.KeyCode == Keys.Enter)
            {
                Button_Search_Click(sender, e);
            }
        }
    }
}
