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
    //The main form class
    public partial class Main : Form
    {
        //Constructor
        public Main()
        {
            InitializeComponent();
        }

        //Called When the Exit button is clicked
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
