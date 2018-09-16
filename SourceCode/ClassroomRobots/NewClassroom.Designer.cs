namespace ClassroomRobots
{
    partial class NewClassroom
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
            this.label1 = new System.Windows.Forms.Label();
            this.Input_TeacherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_ClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_RoomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_RoomSize = new System.Windows.Forms.NumericUpDown();
            this.button_AddClassroom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Input_RoomSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            // 
            // Input_TeacherName
            // 
            this.Input_TeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_TeacherName.Location = new System.Drawing.Point(17, 37);
            this.Input_TeacherName.Name = "Input_TeacherName";
            this.Input_TeacherName.Size = new System.Drawing.Size(305, 30);
            this.Input_TeacherName.TabIndex = 1;
            this.Input_TeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // Input_ClassName
            // 
            this.Input_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ClassName.Location = new System.Drawing.Point(17, 116);
            this.Input_ClassName.Name = "Input_ClassName";
            this.Input_ClassName.Size = new System.Drawing.Size(305, 30);
            this.Input_ClassName.TabIndex = 3;
            this.Input_ClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room";
            // 
            // Input_RoomName
            // 
            this.Input_RoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_RoomName.Location = new System.Drawing.Point(19, 197);
            this.Input_RoomName.Name = "Input_RoomName";
            this.Input_RoomName.Size = new System.Drawing.Size(303, 30);
            this.Input_RoomName.TabIndex = 5;
            this.Input_RoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size";
            // 
            // Input_RoomSize
            // 
            this.Input_RoomSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_RoomSize.Location = new System.Drawing.Point(19, 281);
            this.Input_RoomSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Input_RoomSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Input_RoomSize.Name = "Input_RoomSize";
            this.Input_RoomSize.Size = new System.Drawing.Size(303, 30);
            this.Input_RoomSize.TabIndex = 7;
            this.Input_RoomSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input_RoomSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_AddClassroom
            // 
            this.button_AddClassroom.BackColor = System.Drawing.SystemColors.Window;
            this.button_AddClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddClassroom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_AddClassroom.Location = new System.Drawing.Point(19, 337);
            this.button_AddClassroom.Name = "button_AddClassroom";
            this.button_AddClassroom.Size = new System.Drawing.Size(303, 34);
            this.button_AddClassroom.TabIndex = 8;
            this.button_AddClassroom.Text = "Add Classroom";
            this.button_AddClassroom.UseVisualStyleBackColor = false;
            this.button_AddClassroom.Click += new System.EventHandler(this.AddClassroom_Btn_Click);
            // 
            // NewClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(334, 395);
            this.Controls.Add(this.button_AddClassroom);
            this.Controls.Add(this.Input_RoomSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_RoomName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input_ClassName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_TeacherName);
            this.Controls.Add(this.label1);
            this.Name = "NewClassroom";
            this.Text = "New Classroom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewClassroom_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.Input_RoomSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_TeacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Input_ClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Input_RoomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Input_RoomSize;
        private System.Windows.Forms.Button button_AddClassroom;
    }
}