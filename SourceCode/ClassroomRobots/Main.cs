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
        /// The Classroom Table.
        /// </summary>
        public DataTable classroomTable;

        /// <summary>
        /// The Student Table.
        /// </summary>
        public DataTable studentTable;

        /// <summary>
        /// The classroom.
        /// </summary>
        public Classroom classroom = null;

        /// <summary>
        /// The style of the Classroom Desks.
        /// </summary>
        public DataGridViewCellStyle deskStyle = new DataGridViewCellStyle();

        /// <summary>
        /// Constructor.
        /// </summary>
        public Main()
        {
            //Initialize the Form.
            InitializeComponent();

            //Setup the Desk Style.
            deskStyle.BackColor = Color.HotPink;

            //Create the student Table
            studentTable = new DataTable();

            //Add the columns to the table
            studentTable.Columns.Add("Name");
            studentTable.Columns.Add("X");
            studentTable.Columns.Add("Y");

            //Set the Student Datas Data Source.
            StudentData.DataSource = studentTable;

            StudentData.Enabled = false;
        }

        /// <summary>
        /// Called When the Exit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            //If a classroom hasnt already been loaded.
            if (classroom == null)
            {
                //Close the form
                this.Close();
            }
            //There is a classroom object.
            else
            {
                //Whether the user wants to save the current classroom before making a new one.
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);

                //If the result was yes.
                if (result == DialogResult.Yes)
                {
                    //Save the file.
                    SaveAs_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    //Close the form
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Called when the Save button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            //If there is a path to save the file.
            if (!String.IsNullOrEmpty(path))
            {
                //Try to write to the file.
                WriteFile(path);
            }
            else
            {
                //Open the Save AS Dialog.
                SaveAs_Click(sender, e);
            }
        }

        /// <summary>
        /// Called when the Open button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            //If a classroom hasnt already been loaded.
            if(classroom == null)
            {
                //Open the classroom.
                OpenClassroom();
            }
            //There is a classroom object.
            else
            {
                //Whether the user wants to save the current classroom before making a new one.
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);

                //If the result was yes.
                if (result == DialogResult.Yes)
                {
                    //Save the file.
                    SaveAs_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    //Set the classroom to null.
                    classroom = null;

                    //Recall the function
                    Open_Click(sender, e);
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

            //If the user has selected a path to save the file.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Set the file path.
                path = saveFileDialog.FileName;

                //Try to write to the selected file.
                WriteFile(path);
            }
        }

        /// <summary>
        /// Called when the New->Classroom button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClassroom_Btn_Click(object sender, EventArgs e)
        {
            //If a classroom hasnt already been loaded.
            if (classroom == null)
            {
                //Create a New Classrom form.
                NewClassroom newClassroom = new NewClassroom(this);

                //Show the new form.
                newClassroom.Show();

                //Hide the main form.
                this.Hide();
            }
            //There is a classroom object.
            else
            {
                //Whether the user wants to save the current classroom before making a new one.
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);

                //If the result was yes.
                if (result == DialogResult.Yes)
                {
                    //Save the file.
                    SaveAs_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    //Create a New Classrom form.
                    NewClassroom newClassroom = new NewClassroom(this);

                    //Show the new form.
                    newClassroom.Show();

                    //Hide the main form.
                    this.Hide();
                }
            }
        }

        /// <summary>
        /// Load the classroom.
        /// </summary>
        /// <param name="classroom"></param>
        public void LoadClassroom()
        {
            CreateTable(classroom.size);

            //Set the menuitems to enabled.
            MenuItem_New_Student.Enabled = true;
            MenuItem_Save.Enabled = true;
            MenuItem_SaveAs.Enabled = true;
            MenuItem_Veiw_Students.Enabled = true;

            //Set the Techers Name text.
            Input_Teacher.Text = classroom.teacher;
            Input_Teacher.Enabled = true;

            //Set the Class Name's text.
            Input_ClassName.Text = classroom.className;
            Input_ClassName.Enabled = true;

            //Set the Room Number's text.
            Input_RoomNumber.Text = classroom.roomNumber;
            Input_RoomNumber.Enabled = true;

            //Set the Room Size.
            Input_Size.Value = classroom.size;
            Input_Size.Enabled = true;
            button_Update.Enabled = false;

            //If there are students in the class.
            if(classroom.students.Count > 0)
            {
                //For each student.
                for (int i = 0; i < classroom.students.Count; i++)
                {
                    //Get the Student.
                    Student student = classroom.students[i];

                    //If the Student is on the table.
                    if (student.x > 0 && student.y > 0)
                    {
                        ClassroomData.Rows[(student.x - 1)].Cells[(student.y - 1)].Value = student.name;
                    }
                }
            }

            //If there are desks in the class.
            if (classroom.desks.Count > 0)
            {
                //For each Desk.
                for (int i = 0; i < classroom.desks.Count; i++)
                {
                    //Get the Desk
                    Desk desk = classroom.desks[i];

                    ClassroomData.Rows[(desk.x - 1)].Cells[(desk.y - 1)].Style = deskStyle;
                }
            }
        }

        /// <summary>
        /// Create the Table.
        /// </summary>
        public void CreateTable(int size)
        {
            //Create the ClassroomTable.
            classroomTable = new DataTable();

            //Add the columns and rows.
            for (int i = 1; i <= size; i++)
            {
                //Add the column.
                classroomTable.Columns.Add(i.ToString());

                //Create a row.
                DataRow row = classroomTable.NewRow();

                //Add the row to the datatable.
                classroomTable.Rows.Add(row);
            }

            //Set the datagrids datasource.
            ClassroomData.DataSource = classroomTable;

            //Add the row Headers.
            for (int i = 1; i <= classroom.size; i++)
            {
                ClassroomData.Rows[(i - 1)].HeaderCell.Value = i.ToString();
            }

            //Set the column size
            foreach (DataGridViewColumn column in ClassroomData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.MinimumWidth = 100;
                column.Width = 100;
            }
        }

        // Keyboard Shortcuts
        private void Main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //Ctrl + O
            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                //Show the Open Dialog.
                Open_Click(sender, e);
            }
            //Ctrl + S
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                //Show the Save Dialog.
                Save_Click(sender, e);
            }
            //Ctrl + Shift + S
            else if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Shift))
            {
                //Show the Save Dialog.
                SaveAs_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Space && ClassroomData.SelectedCells.Count == 1)
            {
                //Create a Context Menu.
                ContextMenu menu = new ContextMenu();

                //Create the MenuItems
                MenuItem desk = new MenuItem("Desk");
                MenuItem addStudent = new MenuItem("Add Student");

                //Add the MenuItems to the Context Menu.
                menu.MenuItems.Add(desk);
                menu.MenuItems.Add("-");
                menu.MenuItems.Add(addStudent);
                addStudent.MenuItems.Add(new MenuItem("Nathan"));

                Point location = ClassroomData.GetCellDisplayRectangle(ClassroomData.SelectedCells[0].ColumnIndex, ClassroomData.SelectedCells[0].RowIndex, false).Location;
                location.X = location.X + 25;
                location.Y = location.Y + 25;

                //Show the Context Menu.
                menu.Show(ClassroomData, location);
            }
        }

        //Called when the student button is clicked.
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a New Classrom form.
            NewStudent newStudent = new NewStudent(this);

            //Show the new form.
            newStudent.Show();

            //Hide the main form.
            this.Hide();
        }

        //Opens a classrom file.
        private void OpenClassroom()
        {
            //Create an Open Dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Set the filter
            openFileDialog.Filter = "CSV File (*.csv)|*.csv";

            //If the user has selected a file to open.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Set the file path
                path = openFileDialog.FileName;

                //Try to read the File.
                ReadFile(path);
            }
        }

        //Called when the value is changed.
        private void Input_Size_ValueChanged(object sender, EventArgs e)
        {
            //Enable the Update Button.
            button_Update.Enabled = true;
        }

        //Called when the Update button is clicked.
        private void button_Update_Click(object sender, EventArgs e)
        {
            //Set the new classroom size.
            classroom.size = (int)Input_Size.Value;

            //Recreate the classoom table.
            CreateTable(classroom.size);

            //Disable the Update Button.
            button_Update.Enabled = false;
        }

        //Called when the mouse is down on a cell.
        private void ClassroomData_Cell_Mouse_Down(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //Set the selected cell.
                ClassroomData.CurrentCell = ClassroomData.Rows[e.RowIndex].Cells[e.ColumnIndex];

                //Create a Context Menu.
                ContextMenu menu = new ContextMenu();

                //Create the MenuItems
                MenuItem desk = new MenuItem("Desk");
                MenuItem addStudent = new MenuItem("Add Student");

                //Add the MenuItems to the Context Menu.
                menu.MenuItems.Add(desk);
                menu.MenuItems.Add("-");
                menu.MenuItems.Add(addStudent);

                desk.Click += new System.EventHandler(ContextMenu_Click);

                //If there are students in the class.
                if(classroom.students.Count > 0)
                {
                    //For each student in the class.
                    for (int i = 0; i < classroom.students.Count; i++)
                    {
                        //Create the Menuitem.
                        MenuItem student = new MenuItem(classroom.students[i].name);

                        //Add the student to the menu.
                        addStudent.MenuItems.Add(student);

                        //Add the Event Handler.
                        student.Click += new System.EventHandler(ContextMenu_AddStudent_Click);
                    }
                }
                else
                {
                    addStudent.Enabled = false;
                }

                //The location of the menu.
                Point location = ClassroomData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                location.X = location.X + 25;
                location.Y = location.Y + 25;

                //Show the Context Menu.
                menu.Show(ClassroomData, location);
            }
        }

        //Called when a menuItem on the context menu is clicked.
        private void ContextMenu_Click(object sender, EventArgs e)
        {
            //Get the Menu Item
            MenuItem item = (MenuItem)sender;

            //Get the Cruuent Cell.
            DataGridViewCell cell = ClassroomData.CurrentCell;

            //Create a Desk
            Desk desk = new Desk(cell.RowIndex + 1, cell.ColumnIndex + 1);

            //Add the desk to the classroom.
            classroom.desks.Add(desk);

            //Refresh the Classroom Table.
            LoadClassroom();

            //Set the current Cells style.
            //ClassroomData.CurrentCell.Style = deskStyle;

            //UnSelect the cell.
            ClassroomData.CurrentCell = null;
        }

        //Called when a menuItem on the context menu is clicked.
        private void ContextMenu_AddStudent_Click(object sender, EventArgs e)
        {
            //Get the Menu Item.
            MenuItem item = (MenuItem)sender;

            //Get the Student.
            Student student = classroom.students[item.Index];

            //Get the Cruuent Cell.
            DataGridViewCell cell = ClassroomData.CurrentCell;

            //Set the Stuedents X and Y.
            student.x = cell.RowIndex + 1;
            student.y = cell.ColumnIndex + 1;

            //Refresh the Student Table.
            LoadStudents();

            //Refresh the Classroom Table.
            LoadClassroom();
        }

        //Loads the students into the Student table.
        public void LoadStudents()
        {
            //Clear the Student table
            studentTable.Clear();

            //Create the new row.
            DataRow row;

            //For each Student in the Class.
            for (int i = 0; i < classroom.students.Count; i++)
            {
                //Create a new row.
                row = studentTable.NewRow();

                //Add the data to the row.
                row[0] = classroom.students[i].name;
                row[1] = classroom.students[i].x;
                row[2] = classroom.students[i].y;

                //Add the row to the table.
                studentTable.Rows.Add(row);
            }

            //Set the Student Table to enabled.
            StudentData.Enabled = true;
        }

        /// <summary>
        /// Called when the View > Students button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Veiw_Students_Click(object sender, EventArgs e)
        {
            //Create a New Classrom form.
            ViewStudents viewStudents = new ViewStudents(this);

            //Show the new form.
            viewStudents.Show();

            //Hide the main form.
            this.Hide();
        }

        /// <summary>
        /// Called when a key is down on the classroom size field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Size_KeyDown(object sender, KeyEventArgs e)
        {
            //If the enter Key is down.
            if (e.KeyCode == Keys.Enter)
            {
                button_Update_Click(sender, e);
            }
        }

        /// <summary>
        /// Called when the Clear Classroom Button is Clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Classroom_Click(object sender, EventArgs e)
        {
            //Clear all the tables.
            classroom.desks.Clear();

            //If the classroom has students in it.
            if (classroom.students.Count > 0)
            {
                //For each student.
                for (int i = 0; i < classroom.students.Count; i++)
                {
                    classroom.students[i].x = 0;
                    classroom.students[i].y = 0;
                }
            }

            //Refresh the classroom.
            LoadClassroom();
        }

        /// <summary>
        /// Read a file.
        /// </summary>
        /// <param name="path"></param>
        private void ReadFile(string path)
        {
            //The teachers Name.
            string teacher = "";

            //The Class Name.
            string className = "";

            //The Room Number.
            string roomNumber = "";

            //The Size of the classroom.
            int size = 0;

            //The List of students in the class.
            List<Student> students = new List<Student>();

            //The List of desks in the class.
            List<Desk> desks = new List<Desk>();

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
                    //If this line is th Room Size.
                    else if (values[0] == "%SIZE%")
                    {
                        //Set the room size
                        size = Int32.Parse(values[1]);
                    }
                    else if (values[0] == "%DESK%")
                    {
                        //Add a new Desk.
                        desks.Add(new Desk(Int32.Parse(values[1]), Int32.Parse(values[2])));
                    }
                    //else if (!string.IsNullOrEmpty(teacher) && !string.IsNullOrEmpty(className) && !string.IsNullOrEmpty(roomNumber) && size != 0)
                    else if (values[0] == "%STUDENT%")
                    {
                        //Add a new Student.
                        students.Add(new Student(values[1], Int32.Parse(values[2]), Int32.Parse(values[3])));
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
            classroom = new Classroom(teacher, className, roomNumber, size);
            classroom.students = students;
            classroom.desks = desks;

            //Create the Classroom Table
            CreateTable(classroom.size);

            //Load The new Classroom into the application
            LoadClassroom();

            //Load the Students into the student table
            LoadStudents();
        }   

        /// <summary>
        /// Write to a file.
        /// </summary>
        /// <param name="path"></param>
        private void WriteFile(string path)
        {
            //The file path.
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("%TEACHER%," + classroom.teacher);
            sb.AppendLine("%CLASS%," + classroom.className);
            sb.AppendLine("%ROOM%," + classroom.roomNumber);
            sb.AppendLine("%SIZE%," + classroom.size);

            //If there are desks in the classroom
            if(classroom.desks.Count > 0)
            {
                //For each of the desks.
                for (int i = 0; i < classroom.desks.Count; i++)
                {
                    //Make a line in the .csv file for them.
                    sb.AppendLine("%DESK%," + classroom.desks[i].x + "," + classroom.desks[i].y);
                }
            }

            //If there are students in the classroom
            if(classroom.students.Count > 0)
            {
                //For each of the students.
                for (int i = 0; i < classroom.students.Count; i++)
                {
                    //Make a line in the .csv file for them.
                    sb.AppendLine("%STUDENT%," + classroom.students[i].name + "," + classroom.students[i].x + "," + classroom.students[i].y);
                }
            }

            //Clear the .csv file.
            System.IO.File.WriteAllText(@path, string.Empty);

            //Update the .csv file.
            File.AppendAllText(@path, sb.ToString());
        }
    }
}
