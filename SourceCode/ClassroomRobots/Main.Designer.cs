namespace ClassroomRobots
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Update = new System.Windows.Forms.Button();
            this.StudentData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_Size = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_Teacher = new System.Windows.Forms.TextBox();
            this.Input_ClassName = new System.Windows.Forms.TextBox();
            this.Input_RoomNumber = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_New_Classroom = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_New_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Veiw = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_Veiw_Students = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripButton();
            this.ClassroomData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_Size)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassroomData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.StudentData);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Input_Size);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Input_Teacher);
            this.panel1.Controls.Add(this.Input_ClassName);
            this.panel1.Controls.Add(this.Input_RoomNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 687);
            this.panel1.TabIndex = 0;
            // 
            // button_Update
            // 
            this.button_Update.Enabled = false;
            this.button_Update.Location = new System.Drawing.Point(171, 236);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(140, 30);
            this.button_Update.TabIndex = 12;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // StudentData
            // 
            this.StudentData.AllowUserToAddRows = false;
            this.StudentData.AllowUserToDeleteRows = false;
            this.StudentData.AllowUserToResizeColumns = false;
            this.StudentData.AllowUserToResizeRows = false;
            this.StudentData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StudentData.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentData.Location = new System.Drawing.Point(13, 315);
            this.StudentData.MultiSelect = false;
            this.StudentData.Name = "StudentData";
            this.StudentData.RowHeadersVisible = false;
            this.StudentData.RowHeadersWidth = 4;
            this.StudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentData.Size = new System.Drawing.Size(303, 357);
            this.StudentData.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Students";
            // 
            // Input_Size
            // 
            this.Input_Size.Enabled = false;
            this.Input_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Size.Location = new System.Drawing.Point(11, 236);
            this.Input_Size.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Input_Size.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Input_Size.Name = "Input_Size";
            this.Input_Size.Size = new System.Drawing.Size(154, 30);
            this.Input_Size.TabIndex = 9;
            this.Input_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input_Size.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Input_Size.ValueChanged += new System.EventHandler(this.Input_Size_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teacher:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Input_Teacher
            // 
            this.Input_Teacher.Enabled = false;
            this.Input_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Teacher.Location = new System.Drawing.Point(13, 38);
            this.Input_Teacher.Name = "Input_Teacher";
            this.Input_Teacher.Size = new System.Drawing.Size(300, 30);
            this.Input_Teacher.TabIndex = 4;
            this.Input_Teacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Input_ClassName
            // 
            this.Input_ClassName.Enabled = false;
            this.Input_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ClassName.Location = new System.Drawing.Point(13, 102);
            this.Input_ClassName.Name = "Input_ClassName";
            this.Input_ClassName.Size = new System.Drawing.Size(300, 30);
            this.Input_ClassName.TabIndex = 3;
            this.Input_ClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Input_RoomNumber
            // 
            this.Input_RoomNumber.Enabled = false;
            this.Input_RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_RoomNumber.Location = new System.Drawing.Point(11, 165);
            this.Input_RoomNumber.Name = "Input_RoomNumber";
            this.Input_RoomNumber.Size = new System.Drawing.Size(300, 30);
            this.Input_RoomNumber.TabIndex = 2;
            this.Input_RoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.MenuItem_Veiw,
            this.MenuItem_Help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_New,
            this.MenuItem_Open,
            this.toolStripSeparator2,
            this.MenuItem_Save,
            this.MenuItem_SaveAs,
            this.toolStripSeparator1,
            this.MenuItem_Exit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // MenuItem_New
            // 
            this.MenuItem_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_New_Classroom,
            this.MenuItem_New_Student});
            this.MenuItem_New.Name = "MenuItem_New";
            this.MenuItem_New.Size = new System.Drawing.Size(114, 22);
            this.MenuItem_New.Text = "New";
            // 
            // MenuItem_New_Classroom
            // 
            this.MenuItem_New_Classroom.Name = "MenuItem_New_Classroom";
            this.MenuItem_New_Classroom.Size = new System.Drawing.Size(130, 22);
            this.MenuItem_New_Classroom.Text = "Classroom";
            this.MenuItem_New_Classroom.Click += new System.EventHandler(this.NewClassroom_Btn_Click);
            // 
            // MenuItem_New_Student
            // 
            this.MenuItem_New_Student.Enabled = false;
            this.MenuItem_New_Student.Name = "MenuItem_New_Student";
            this.MenuItem_New_Student.Size = new System.Drawing.Size(130, 22);
            this.MenuItem_New_Student.Text = "Student";
            this.MenuItem_New_Student.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.Size = new System.Drawing.Size(114, 22);
            this.MenuItem_Open.Text = "Open";
            this.MenuItem_Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Enabled = false;
            this.MenuItem_Save.Name = "MenuItem_Save";
            this.MenuItem_Save.Size = new System.Drawing.Size(114, 22);
            this.MenuItem_Save.Text = "Save";
            this.MenuItem_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // MenuItem_SaveAs
            // 
            this.MenuItem_SaveAs.Enabled = false;
            this.MenuItem_SaveAs.Name = "MenuItem_SaveAs";
            this.MenuItem_SaveAs.Size = new System.Drawing.Size(114, 22);
            this.MenuItem_SaveAs.Text = "Save As";
            this.MenuItem_SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(114, 22);
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuItem_Veiw
            // 
            this.MenuItem_Veiw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuItem_Veiw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Veiw_Students});
            this.MenuItem_Veiw.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Veiw.Image")));
            this.MenuItem_Veiw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuItem_Veiw.Name = "MenuItem_Veiw";
            this.MenuItem_Veiw.Size = new System.Drawing.Size(45, 22);
            this.MenuItem_Veiw.Text = "View";
            // 
            // MenuItem_Veiw_Students
            // 
            this.MenuItem_Veiw_Students.Name = "MenuItem_Veiw_Students";
            this.MenuItem_Veiw_Students.Size = new System.Drawing.Size(120, 22);
            this.MenuItem_Veiw_Students.Text = "Students";
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuItem_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuItem_Help.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Help.Image")));
            this.MenuItem_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(36, 22);
            this.MenuItem_Help.Text = "Help";
            this.MenuItem_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ClassroomData
            // 
            this.ClassroomData.AllowUserToAddRows = false;
            this.ClassroomData.AllowUserToDeleteRows = false;
            this.ClassroomData.AllowUserToResizeColumns = false;
            this.ClassroomData.AllowUserToResizeRows = false;
            this.ClassroomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassroomData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassroomData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ClassroomData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassroomData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassroomData.ColumnHeadersHeight = 50;
            this.ClassroomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClassroomData.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClassroomData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassroomData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ClassroomData.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassroomData.Location = new System.Drawing.Point(334, 25);
            this.ClassroomData.MinimumSize = new System.Drawing.Size(650, 0);
            this.ClassroomData.MultiSelect = false;
            this.ClassroomData.Name = "ClassroomData";
            this.ClassroomData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassroomData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassroomData.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassroomData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ClassroomData.RowTemplate.Height = 50;
            this.ClassroomData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassroomData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ClassroomData.ShowEditingIcon = false;
            this.ClassroomData.ShowRowErrors = false;
            this.ClassroomData.Size = new System.Drawing.Size(650, 687);
            this.ClassroomData.TabIndex = 3;
            this.ClassroomData.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClassroomData_Cell_Mouse_Down);
            this.ClassroomData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.ClassroomData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(1000, 736);
            this.Name = "Main";
            this.Text = "Classroom Robots";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_Size)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassroomData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MenuItem_Help;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_New_Classroom;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_New_Student;
        private System.Windows.Forms.ToolStripDropDownButton MenuItem_Veiw;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Veiw_Students;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_Teacher;
        private System.Windows.Forms.TextBox Input_ClassName;
        private System.Windows.Forms.TextBox Input_RoomNumber;
        private System.Windows.Forms.DataGridView ClassroomData;
        private System.Windows.Forms.NumericUpDown Input_Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView StudentData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

