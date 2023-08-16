namespace eems_desktop
{
    partial class AdminDashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(8, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(8, 64);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(144, 23);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(8, 96);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(144, 23);
            this.btnExam.TabIndex = 2;
            this.btnExam.Text = "Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(8, 32);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(144, 23);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Label lblTitle;
    }
}