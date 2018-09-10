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
        //Reference to the Main form.
        public Main main;

        //The Binary Tree.
        Tree tree = new Tree();

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

            for (int i = 0; i < main.classroom.students.Count; i++)
            {
                //Add the number to the Binary Tree.
                tree.AddValue(main.classroom.students[i]);
            }

            LoadTable();
        }

        /// <summary>
        /// Loads the students into the table.
        /// </summary>
        public void LoadTable()
        {

        }
    }
}
