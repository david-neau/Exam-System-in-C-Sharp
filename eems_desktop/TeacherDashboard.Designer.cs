namespace eems_desktop
{
    partial class TeacherDashboard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.selectExamID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.cbxClassID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnOff = new System.Windows.Forms.RadioButton();
            this.radioBtnOn = new System.Windows.Forms.RadioButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(8, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Teacher Dashboard";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(160, 232);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(632, 208);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(688, 80);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(104, 24);
            this.btnQuestion.TabIndex = 117;
            this.btnQuestion.Text = "View Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Selected:";
            // 
            // selectExamID
            // 
            this.selectExamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectExamID.Location = new System.Drawing.Point(664, 192);
            this.selectExamID.Name = "selectExamID";
            this.selectExamID.ReadOnly = true;
            this.selectExamID.Size = new System.Drawing.Size(128, 20);
            this.selectExamID.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 114;
            this.label7.Text = "Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Location = new System.Drawing.Point(288, 192);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 20);
            this.txtDuration.TabIndex = 113;
            // 
            // cbxClassID
            // 
            this.cbxClassID.FormattingEnabled = true;
            this.cbxClassID.Location = new System.Drawing.Point(160, 96);
            this.cbxClassID.Name = "cbxClassID";
            this.cbxClassID.Size = new System.Drawing.Size(200, 21);
            this.cbxClassID.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Class";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 110;
            this.button2.Text = "View Results";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnOff);
            this.groupBox1.Controls.Add(this.radioBtnOn);
            this.groupBox1.Location = new System.Drawing.Point(376, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 40);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autostop";
            // 
            // radioBtnOff
            // 
            this.radioBtnOff.AutoSize = true;
            this.radioBtnOff.Location = new System.Drawing.Point(80, 16);
            this.radioBtnOff.Name = "radioBtnOff";
            this.radioBtnOff.Size = new System.Drawing.Size(39, 17);
            this.radioBtnOff.TabIndex = 1;
            this.radioBtnOff.TabStop = true;
            this.radioBtnOff.Text = "Off";
            this.radioBtnOff.UseVisualStyleBackColor = true;
            // 
            // radioBtnOn
            // 
            this.radioBtnOn.AutoSize = true;
            this.radioBtnOn.Location = new System.Drawing.Point(8, 16);
            this.radioBtnOn.Name = "radioBtnOn";
            this.radioBtnOn.Size = new System.Drawing.Size(39, 17);
            this.radioBtnOn.TabIndex = 0;
            this.radioBtnOn.TabStop = true;
            this.radioBtnOn.Text = "On";
            this.radioBtnOn.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(464, 144);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(296, 20);
            this.dtpEnd.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "End Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(160, 144);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(296, 20);
            this.dtpStart.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Exam List";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 103;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(688, 56);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(104, 24);
            this.btnChangeStatus.TabIndex = 102;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(688, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdate.TabIndex = 101;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(496, 192);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 23);
            this.btnInsert.TabIndex = 100;
            this.btnInsert.Text = "Create";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(160, 192);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(120, 21);
            this.cbxStatus.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Start Date:";
            // 
            // txtExamName
            // 
            this.txtExamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExamName.Location = new System.Drawing.Point(160, 48);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(200, 20);
            this.txtExamName.TabIndex = 94;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(160, 32);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(64, 13);
            this.lblFirstname.TabIndex = 93;
            this.lblFirstname.Text = "Exam Name";
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectExamID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.cbxClassID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Name = "TeacherDashboard";
            this.Text = "TeacherDashboard";
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectExamID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cbxClassID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnOff;
        private System.Windows.Forms.RadioButton radioBtnOn;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label lblFirstname;
    }
}