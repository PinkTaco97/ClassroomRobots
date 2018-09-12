namespace ClassroomRobots
{
    partial class ViewStudents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Input_Search = new System.Windows.Forms.TextBox();
            this.StudentData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Button_Search);
            this.panel1.Controls.Add(this.Input_Search);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 53);
            this.panel1.TabIndex = 0;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(262, 14);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(86, 30);
            this.Button_Search.TabIndex = 1;
            this.Button_Search.Text = "Binary Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Input_Search
            // 
            this.Input_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Search.Location = new System.Drawing.Point(13, 15);
            this.Input_Search.Name = "Input_Search";
            this.Input_Search.Size = new System.Drawing.Size(243, 27);
            this.Input_Search.TabIndex = 0;
            this.Input_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Serach_KeyDown);
            // 
            // StudentData
            // 
            this.StudentData.AllowUserToAddRows = false;
            this.StudentData.AllowUserToDeleteRows = false;
            this.StudentData.AllowUserToResizeColumns = false;
            this.StudentData.AllowUserToResizeRows = false;
            this.StudentData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StudentData.Location = new System.Drawing.Point(-1, 46);
            this.StudentData.MultiSelect = false;
            this.StudentData.Name = "StudentData";
            this.StudentData.RowHeadersVisible = false;
            this.StudentData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentData.Size = new System.Drawing.Size(362, 319);
            this.StudentData.TabIndex = 1;
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 361);
            this.Controls.Add(this.StudentData);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 400);
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewStudents_Closing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.TextBox Input_Search;
        private System.Windows.Forms.DataGridView StudentData;
    }
}