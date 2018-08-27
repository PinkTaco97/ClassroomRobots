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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Teacher_Input = new System.Windows.Forms.TextBox();
            this.ClassName_Input = new System.Windows.Forms.TextBox();
            this.RoomNumber_Input = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.NewClassroom_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Teacher_Input);
            this.panel1.Controls.Add(this.ClassName_Input);
            this.panel1.Controls.Add(this.RoomNumber_Input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 687);
            this.panel1.TabIndex = 0;
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
            // Teacher_Input
            // 
            this.Teacher_Input.Enabled = false;
            this.Teacher_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Input.Location = new System.Drawing.Point(13, 38);
            this.Teacher_Input.Name = "Teacher_Input";
            this.Teacher_Input.Size = new System.Drawing.Size(300, 30);
            this.Teacher_Input.TabIndex = 4;
            this.Teacher_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClassName_Input
            // 
            this.ClassName_Input.Enabled = false;
            this.ClassName_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName_Input.Location = new System.Drawing.Point(13, 102);
            this.ClassName_Input.Name = "ClassName_Input";
            this.ClassName_Input.Size = new System.Drawing.Size(300, 30);
            this.ClassName_Input.TabIndex = 3;
            this.ClassName_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomNumber_Input
            // 
            this.RoomNumber_Input.Enabled = false;
            this.RoomNumber_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumber_Input.Location = new System.Drawing.Point(11, 165);
            this.RoomNumber_Input.Name = "RoomNumber_Input";
            this.RoomNumber_Input.Size = new System.Drawing.Size(300, 30);
            this.RoomNumber_Input.TabIndex = 2;
            this.RoomNumber_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripButton1});
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
            this.New,
            this.Open,
            this.toolStripSeparator2,
            this.Save,
            this.SaveAs,
            this.toolStripSeparator1,
            this.Exit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // New
            // 
            this.New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewClassroom_Btn,
            this.studentToolStripMenuItem});
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(152, 22);
            this.New.Text = "New";
            // 
            // NewClassroom_Btn
            // 
            this.NewClassroom_Btn.Name = "NewClassroom_Btn";
            this.NewClassroom_Btn.Size = new System.Drawing.Size(130, 22);
            this.NewClassroom_Btn.Text = "Classroom";
            this.NewClassroom_Btn.Click += new System.EventHandler(this.NewClassroom_Btn_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(152, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(152, 22);
            this.SaveAs.Text = "Save As";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton2.Text = "View";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "Help";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.data.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeight = 50;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Cursor = System.Windows.Forms.Cursors.Default;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(334, 25);
            this.data.MinimumSize = new System.Drawing.Size(650, 0);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data.RowTemplate.Height = 50;
            this.data.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.data.ShowEditingIcon = false;
            this.data.ShowRowErrors = false;
            this.data.Size = new System.Drawing.Size(650, 687);
            this.data.TabIndex = 3;
            this.data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Main";
            this.Text = "Classroom Robots";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NewClassroom_Btn;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Teacher_Input;
        private System.Windows.Forms.TextBox ClassName_Input;
        private System.Windows.Forms.TextBox RoomNumber_Input;
        private System.Windows.Forms.DataGridView data;
    }
}

