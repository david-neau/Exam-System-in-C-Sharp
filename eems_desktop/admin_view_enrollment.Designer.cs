namespace eems_desktop
{
    partial class admin_view_enrollment
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
            this.dgvEnrolledStudents = new System.Windows.Forms.DataGridView();
            this.dgvNotEnrolledStudents = new System.Windows.Forms.DataGridView();
            this.txtsrcenrollment = new System.Windows.Forms.TextBox();
            this.btnsrcstudentlist = new System.Windows.Forms.Button();
            this.txtsrcstudentlist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnsrcenrollment = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclearsrcenrollment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotEnrolledStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(1112, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 32);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Return To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvEnrolledStudents
            // 
            this.dgvEnrolledStudents.AllowUserToAddRows = false;
            this.dgvEnrolledStudents.AllowUserToDeleteRows = false;
            this.dgvEnrolledStudents.AllowUserToOrderColumns = true;
            this.dgvEnrolledStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrolledStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolledStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEnrolledStudents.Location = new System.Drawing.Point(112, 128);
            this.dgvEnrolledStudents.Name = "dgvEnrolledStudents";
            this.dgvEnrolledStudents.Size = new System.Drawing.Size(560, 504);
            this.dgvEnrolledStudents.TabIndex = 24;
            this.dgvEnrolledStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrolledStudents_CellClick);
            // 
            // dgvNotEnrolledStudents
            // 
            this.dgvNotEnrolledStudents.AllowUserToAddRows = false;
            this.dgvNotEnrolledStudents.AllowUserToDeleteRows = false;
            this.dgvNotEnrolledStudents.AllowUserToOrderColumns = true;
            this.dgvNotEnrolledStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotEnrolledStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotEnrolledStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotEnrolledStudents.Location = new System.Drawing.Point(688, 128);
            this.dgvNotEnrolledStudents.Name = "dgvNotEnrolledStudents";
            this.dgvNotEnrolledStudents.Size = new System.Drawing.Size(560, 504);
            this.dgvNotEnrolledStudents.TabIndex = 25;
            this.dgvNotEnrolledStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotEnrolledStudents_CellClick);
            this.dgvNotEnrolledStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotEnrolledStudents_CellContentClick);
            // 
            // txtsrcenrollment
            // 
            this.txtsrcenrollment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsrcenrollment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtsrcenrollment.Location = new System.Drawing.Point(112, 96);
            this.txtsrcenrollment.Name = "txtsrcenrollment";
            this.txtsrcenrollment.Size = new System.Drawing.Size(136, 25);
            this.txtsrcenrollment.TabIndex = 32;
            // 
            // btnsrcstudentlist
            // 
            this.btnsrcstudentlist.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnsrcstudentlist.Location = new System.Drawing.Point(840, 88);
            this.btnsrcstudentlist.Name = "btnsrcstudentlist";
            this.btnsrcstudentlist.Size = new System.Drawing.Size(72, 31);
            this.btnsrcstudentlist.TabIndex = 37;
            this.btnsrcstudentlist.Text = "Search";
            this.btnsrcstudentlist.UseVisualStyleBackColor = true;
            this.btnsrcstudentlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsrcstudentlist
            // 
            this.txtsrcstudentlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsrcstudentlist.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtsrcstudentlist.Location = new System.Drawing.Point(688, 96);
            this.txtsrcstudentlist.Name = "txtsrcstudentlist";
            this.txtsrcstudentlist.Size = new System.Drawing.Size(144, 25);
            this.txtsrcstudentlist.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(688, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "All Students";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAdd.Location = new System.Drawing.Point(1168, 640);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 32);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnsrcenrollment
            // 
            this.btnsrcenrollment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnsrcenrollment.Location = new System.Drawing.Point(256, 88);
            this.btnsrcenrollment.Name = "btnsrcenrollment";
            this.btnsrcenrollment.Size = new System.Drawing.Size(80, 31);
            this.btnsrcenrollment.TabIndex = 41;
            this.btnsrcenrollment.Text = "Search";
            this.btnsrcenrollment.UseVisualStyleBackColor = true;
            this.btnsrcenrollment.Click += new System.EventHandler(this.btnsrcenrollment_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRemove.Location = new System.Drawing.Point(592, 640);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 32);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(112, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Current Enrollment:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedUserID
            // 
            this.selectedUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.selectedUserID.Location = new System.Drawing.Point(112, 32);
            this.selectedUserID.Name = "selectedUserID";
            this.selectedUserID.ReadOnly = true;
            this.selectedUserID.Size = new System.Drawing.Size(208, 25);
            this.selectedUserID.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(112, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Selected:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnclearsrcenrollment
            // 
            this.btnclearsrcenrollment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnclearsrcenrollment.Location = new System.Drawing.Point(344, 88);
            this.btnclearsrcenrollment.Name = "btnclearsrcenrollment";
            this.btnclearsrcenrollment.Size = new System.Drawing.Size(72, 31);
            this.btnclearsrcenrollment.TabIndex = 89;
            this.btnclearsrcenrollment.Text = "Clear";
            this.btnclearsrcenrollment.UseVisualStyleBackColor = true;
            this.btnclearsrcenrollment.Click += new System.EventHandler(this.btnclearsrcenrollment_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button2.Location = new System.Drawing.Point(920, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 31);
            this.button2.TabIndex = 90;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 681);
            this.panel1.TabIndex = 91;
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnExam.ForeColor = System.Drawing.Color.White;
            this.btnExam.Image = global::eems_desktop.Properties.Resources.icons8_exam_50;
            this.btnExam.Location = new System.Drawing.Point(8, 200);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(80, 80);
            this.btnExam.TabIndex = 2;
            this.btnExam.Text = "Exam";
            this.btnExam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::eems_desktop.Properties.Resources.icons8_door_50;
            this.btnLogout.Location = new System.Drawing.Point(8, 592);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 80);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Image = global::eems_desktop.Properties.Resources.icons8_class_50__1_;
            this.btnClass.Location = new System.Drawing.Point(8, 8);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(80, 80);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Class";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::eems_desktop.Properties.Resources.icons8_user_50;
            this.btnUser.Location = new System.Drawing.Point(8, 104);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(80, 80);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // admin_view_enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvEnrolledStudents);
            this.Controls.Add(this.txtsrcenrollment);
            this.Controls.Add(this.btnsrcenrollment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclearsrcenrollment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedUserID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsrcstudentlist);
            this.Controls.Add(this.txtsrcstudentlist);
            this.Controls.Add(this.dgvNotEnrolledStudents);
            this.Controls.Add(this.btnBack);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "admin_view_enrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Enrollment";
            this.Load += new System.EventHandler(this.admin_view_enrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotEnrolledStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvEnrolledStudents;
        private System.Windows.Forms.DataGridView dgvNotEnrolledStudents;
        private System.Windows.Forms.TextBox txtsrcenrollment;
        private System.Windows.Forms.Button btnsrcstudentlist;
        private System.Windows.Forms.TextBox txtsrcstudentlist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnsrcenrollment;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclearsrcenrollment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnUser;
    }
}