namespace eems_desktop
{
    partial class student_view_class
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewClass = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(688, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 23);
            this.btnBack.TabIndex = 81;
            this.btnBack.Text = "Return To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 24);
            this.btnSearch.TabIndex = 80;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFirstname
            // 
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstname.Location = new System.Drawing.Point(160, 40);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(200, 20);
            this.txtFirstname.TabIndex = 79;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(160, 16);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(63, 13);
            this.lblFirstname.TabIndex = 78;
            this.lblFirstname.Text = "Class Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 24);
            this.button2.TabIndex = 76;
            this.button2.Text = "View Exam";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(160, 72);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(632, 368);
            this.dataGridViewUsers.TabIndex = 74;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 13);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "My Class";
            // 
            // btnViewClass
            // 
            this.btnViewClass.Location = new System.Drawing.Point(8, 32);
            this.btnViewClass.Name = "btnViewClass";
            this.btnViewClass.Size = new System.Drawing.Size(144, 23);
            this.btnViewClass.TabIndex = 72;
            this.btnViewClass.Text = "My Class";
            this.btnViewClass.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(8, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 23);
            this.btnLogout.TabIndex = 71;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 82;
            this.button3.Text = "My Exam";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 83;
            this.button4.Text = "My Result";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // student_view_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnViewClass);
            this.Controls.Add(this.btnLogout);
            this.Name = "student_view_class";
            this.Text = "student_view_class";
            this.Load += new System.EventHandler(this.student_view_class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewClass;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}