namespace ClassroomRobots
{
    partial class NewStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.Input_Name = new System.Windows.Forms.TextBox();
            this.Button_AddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Input_Name
            // 
            this.Input_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Name.Location = new System.Drawing.Point(17, 37);
            this.Input_Name.Name = "Input_Name";
            this.Input_Name.Size = new System.Drawing.Size(305, 30);
            this.Input_Name.TabIndex = 1;
            // 
            // Button_AddStudent
            // 
            this.Button_AddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddStudent.Location = new System.Drawing.Point(17, 98);
            this.Button_AddStudent.Name = "Button_AddStudent";
            this.Button_AddStudent.Size = new System.Drawing.Size(305, 33);
            this.Button_AddStudent.TabIndex = 2;
            this.Button_AddStudent.Text = "Add Student";
            this.Button_AddStudent.UseVisualStyleBackColor = true;
            this.Button_AddStudent.Click += new System.EventHandler(this.Button_AddStudent_Click);
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(334, 162);
            this.Controls.Add(this.Button_AddStudent);
            this.Controls.Add(this.Input_Name);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewStudent_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_Name;
        private System.Windows.Forms.Button Button_AddStudent;
    }
}