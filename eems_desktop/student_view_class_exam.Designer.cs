namespace eems_desktop
{
    partial class student_view_class_exam
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewClass = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(688, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 24);
            this.button4.TabIndex = 96;
            this.button4.Text = "Start Exam";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(688, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 23);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "Return To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 24);
            this.btnSearch.TabIndex = 93;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFirstname
            // 
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstname.Location = new System.Drawing.Point(160, 40);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(152, 20);
            this.txtFirstname.TabIndex = 92;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(160, 24);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(63, 13);
            this.lblFirstname.TabIndex = 91;
            this.lblFirstname.Text = "Class Name";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(160, 72);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(632, 368);
            this.dataGridViewUsers.TabIndex = 87;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 13);
            this.lblTitle.TabIndex = 86;
            this.lblTitle.Text = "Class Exam List";
            // 
            // btnViewClass
            // 
            this.btnViewClass.Location = new System.Drawing.Point(8, 32);
            this.btnViewClass.Name = "btnViewClass";
            this.btnViewClass.Size = new System.Drawing.Size(144, 23);
            this.btnViewClass.TabIndex = 85;
            this.btnViewClass.Text = "My Class";
            this.btnViewClass.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(8, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 23);
            this.btnLogout.TabIndex = 84;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // student_view_class_exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnViewClass);
            this.Controls.Add(this.btnLogout);
            this.Name = "student_view_class_exam";
            this.Text = "student_view_class_exam";
            this.Load += new System.EventHandler(this.student_view_class_exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewClass;
        private System.Windows.Forms.Button btnLogout;
    }
}