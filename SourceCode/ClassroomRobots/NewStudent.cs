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
    }
}
