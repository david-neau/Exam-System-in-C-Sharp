namespace eems_desktop
{
    partial class admin_view_exam
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUserID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnOff = new System.Windows.Forms.RadioButton();
            this.radioBtnOn = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cbxClassID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectExamID = new System.Windows.Forms.TextBox();
            this.btnQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Exam List";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(688, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 23);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Return To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 42;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(688, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(512, 192);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 23);
            this.btnInsert.TabIndex = 40;
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
            this.cbxStatus.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Status";
            // 
            // cbxUserID
            // 
            this.cbxUserID.FormattingEnabled = true;
            this.cbxUserID.Location = new System.Drawing.Point(160, 96);
            this.cbxUserID.Name = "cbxUserID";
            this.cbxUserID.Size = new System.Drawing.Size(200, 21);
            this.cbxUserID.TabIndex = 37;
            this.cbxUserID.SelectedIndexChanged += new System.EventHandler(this.cbxUserID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Start Date:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(160, 80);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(47, 13);
            this.lblContact.TabIndex = 30;
            this.lblContact.Text = "Teacher";
            // 
            // txtExamName
            // 
            this.txtExamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExamName.Location = new System.Drawing.Point(160, 48);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(200, 20);
            this.txtExamName.TabIndex = 27;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(160, 32);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(64, 13);
            this.lblFirstname.TabIndex = 26;
            this.lblFirstname.Text = "Exam Name";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToOrderColumns = true;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.Location = new System.Drawing.Point(160, 240);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(632, 200);
            this.table.TabIndex = 25;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(160, 144);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(296, 20);
            this.dtpStart.TabIndex = 48;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(464, 144);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(296, 20);
            this.dtpEnd.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "End Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnOff);
            this.groupBox1.Controls.Add(this.radioBtnOn);
            this.groupBox1.Location = new System.Drawing.Point(376, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 40);
            this.groupBox1.TabIndex = 51;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "View Results";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "EEMS";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 23);
            this.button5.TabIndex = 83;
            this.button5.Text = "Exam";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 82;
            this.button3.Text = "User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 23);
            this.button6.TabIndex = 81;
            this.button6.Text = "Class";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 416);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 24);
            this.button7.TabIndex = 85;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cbxClassID
            // 
            this.cbxClassID.FormattingEnabled = true;
            this.cbxClassID.Location = new System.Drawing.Point(376, 96);
            this.cbxClassID.Name = "cbxClassID";
            this.cbxClassID.Size = new System.Drawing.Size(200, 21);
            this.cbxClassID.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Class";
            // 
            // txtDuration
            // 
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Location = new System.Drawing.Point(288, 192);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 20);
            this.txtDuration.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Duration";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(592, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Selected:";
            // 
            // selectExamID
            // 
            this.selectExamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectExamID.Location = new System.Drawing.Point(664, 192);
            this.selectExamID.Name = "selectExamID";
            this.selectExamID.ReadOnly = true;
            this.selectExamID.Size = new System.Drawing.Size(128, 20);
            this.selectExamID.TabIndex = 90;
            this.selectExamID.TextChanged += new System.EventHandler(this.ClassInfo_TextChanged);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(688, 104);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(104, 24);
            this.btnQuestion.TabIndex = 92;
            this.btnQuestion.Text = "Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            // 
            // admin_view_exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectExamID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.cbxClassID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.table);
            this.Name = "admin_view_exam";
            this.Text = "admin_view_exam";
            this.Load += new System.EventHandler(this.admin_view_exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnOff;
        private System.Windows.Forms.RadioButton radioBtnOn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cbxClassID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectExamID;
        private System.Windows.Forms.Button btnQuestion;
    }
}