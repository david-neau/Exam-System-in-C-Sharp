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
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.selectedUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclearsrcenrollment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotEnrolledStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class_name List";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(648, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 23);
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
            this.dgvEnrolledStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolledStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEnrolledStudents.Location = new System.Drawing.Point(168, 104);
            this.dgvEnrolledStudents.Name = "dgvEnrolledStudents";
            this.dgvEnrolledStudents.Size = new System.Drawing.Size(304, 304);
            this.dgvEnrolledStudents.TabIndex = 24;
            this.dgvEnrolledStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrolledStudents_CellClick);
            // 
            // dgvNotEnrolledStudents
            // 
            this.dgvNotEnrolledStudents.AllowUserToAddRows = false;
            this.dgvNotEnrolledStudents.AllowUserToDeleteRows = false;
            this.dgvNotEnrolledStudents.AllowUserToOrderColumns = true;
            this.dgvNotEnrolledStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotEnrolledStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotEnrolledStudents.Location = new System.Drawing.Point(488, 104);
            this.dgvNotEnrolledStudents.Name = "dgvNotEnrolledStudents";
            this.dgvNotEnrolledStudents.Size = new System.Drawing.Size(304, 304);
            this.dgvNotEnrolledStudents.TabIndex = 25;
            this.dgvNotEnrolledStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotEnrolledStudents_CellClick);
            this.dgvNotEnrolledStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotEnrolledStudents_CellContentClick);
            // 
            // txtsrcenrollment
            // 
            this.txtsrcenrollment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsrcenrollment.Location = new System.Drawing.Point(168, 72);
            this.txtsrcenrollment.Name = "txtsrcenrollment";
            this.txtsrcenrollment.Size = new System.Drawing.Size(144, 20);
            this.txtsrcenrollment.TabIndex = 32;
            // 
            // btnsrcstudentlist
            // 
            this.btnsrcstudentlist.Location = new System.Drawing.Point(648, 72);
            this.btnsrcstudentlist.Name = "btnsrcstudentlist";
            this.btnsrcstudentlist.Size = new System.Drawing.Size(72, 23);
            this.btnsrcstudentlist.TabIndex = 37;
            this.btnsrcstudentlist.Text = "Search";
            this.btnsrcstudentlist.UseVisualStyleBackColor = true;
            this.btnsrcstudentlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsrcstudentlist
            // 
            this.txtsrcstudentlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsrcstudentlist.Location = new System.Drawing.Point(488, 72);
            this.txtsrcstudentlist.Name = "txtsrcstudentlist";
            this.txtsrcstudentlist.Size = new System.Drawing.Size(152, 20);
            this.txtsrcstudentlist.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "All Students";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(728, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnsrcenrollment
            // 
            this.btnsrcenrollment.Location = new System.Drawing.Point(320, 72);
            this.btnsrcenrollment.Name = "btnsrcenrollment";
            this.btnsrcenrollment.Size = new System.Drawing.Size(80, 23);
            this.btnsrcenrollment.TabIndex = 41;
            this.btnsrcenrollment.Text = "Search";
            this.btnsrcenrollment.UseVisualStyleBackColor = true;
            this.btnsrcenrollment.Click += new System.EventHandler(this.btnsrcenrollment_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(392, 416);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 23);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Current Enrollment:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Exam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 23);
            this.button6.TabIndex = 78;
            this.button6.Text = "User";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 23);
            this.button7.TabIndex = 77;
            this.button7.Text = "Class";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 416);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 24);
            this.button8.TabIndex = 86;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // selectedUserID
            // 
            this.selectedUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedUserID.Location = new System.Drawing.Point(376, 16);
            this.selectedUserID.Name = "selectedUserID";
            this.selectedUserID.ReadOnly = true;
            this.selectedUserID.Size = new System.Drawing.Size(208, 20);
            this.selectedUserID.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Selected:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnclearsrcenrollment
            // 
            this.btnclearsrcenrollment.Location = new System.Drawing.Point(408, 72);
            this.btnclearsrcenrollment.Name = "btnclearsrcenrollment";
            this.btnclearsrcenrollment.Size = new System.Drawing.Size(72, 23);
            this.btnclearsrcenrollment.TabIndex = 89;
            this.btnclearsrcenrollment.Text = "Clear";
            this.btnclearsrcenrollment.UseVisualStyleBackColor = true;
            this.btnclearsrcenrollment.Click += new System.EventHandler(this.btnclearsrcenrollment_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 90;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // admin_view_enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnclearsrcenrollment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedUserID);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnsrcenrollment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsrcstudentlist);
            this.Controls.Add(this.txtsrcstudentlist);
            this.Controls.Add(this.txtsrcenrollment);
            this.Controls.Add(this.dgvNotEnrolledStudents);
            this.Controls.Add(this.dgvEnrolledStudents);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "admin_view_enrollment";
            this.Text = "admin_view_enrollment";
            this.Load += new System.EventHandler(this.admin_view_enrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotEnrolledStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox selectedUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclearsrcenrollment;
        private System.Windows.Forms.Button button2;
    }
}