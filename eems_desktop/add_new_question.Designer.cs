namespace eems_desktop
{
    partial class add_new_question
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
            this.btnInsertMCQ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmqcquestiontext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.rboption4iscorrect = new System.Windows.Forms.RadioButton();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.rboption3iscorrect = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rboption1iscorrect = new System.Windows.Forms.RadioButton();
            this.rboption2iscorrect = new System.Windows.Forms.RadioButton();
            this.cbxQuestionType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInsertTF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtrue = new System.Windows.Forms.RadioButton();
            this.txttfquestiontext = new System.Windows.Forms.TextBox();
            this.rbfalse = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertMCQ
            // 
            this.btnInsertMCQ.Location = new System.Drawing.Point(8, 352);
            this.btnInsertMCQ.Name = "btnInsertMCQ";
            this.btnInsertMCQ.Size = new System.Drawing.Size(232, 24);
            this.btnInsertMCQ.TabIndex = 101;
            this.btnInsertMCQ.Text = "Create";
            this.btnInsertMCQ.UseVisualStyleBackColor = true;
            this.btnInsertMCQ.Click += new System.EventHandler(this.btnInsertMCQ_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 104;
            this.label1.Text = "Question Type";
            // 
            // txtmqcquestiontext
            // 
            this.txtmqcquestiontext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmqcquestiontext.Location = new System.Drawing.Point(8, 56);
            this.txtmqcquestiontext.Multiline = true;
            this.txtmqcquestiontext.Name = "txtmqcquestiontext";
            this.txtmqcquestiontext.Size = new System.Drawing.Size(232, 88);
            this.txtmqcquestiontext.TabIndex = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOption4);
            this.groupBox1.Controls.Add(this.txtOption3);
            this.groupBox1.Controls.Add(this.rboption4iscorrect);
            this.groupBox1.Controls.Add(this.txtOption2);
            this.groupBox1.Controls.Add(this.txtOption1);
            this.groupBox1.Controls.Add(this.rboption3iscorrect);
            this.groupBox1.Controls.Add(this.btnInsertMCQ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rboption1iscorrect);
            this.groupBox1.Controls.Add(this.txtmqcquestiontext);
            this.groupBox1.Controls.Add(this.rboption2iscorrect);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(120, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 384);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutiple Choice";
            this.groupBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "Is Correct";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 109;
            this.label6.Text = "Option Text";
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(8, 312);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(176, 25);
            this.txtOption4.TabIndex = 6;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(8, 272);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(176, 25);
            this.txtOption3.TabIndex = 5;
            // 
            // rboption4iscorrect
            // 
            this.rboption4iscorrect.AutoSize = true;
            this.rboption4iscorrect.Location = new System.Drawing.Point(208, 320);
            this.rboption4iscorrect.Name = "rboption4iscorrect";
            this.rboption4iscorrect.Size = new System.Drawing.Size(14, 13);
            this.rboption4iscorrect.TabIndex = 3;
            this.rboption4iscorrect.TabStop = true;
            this.rboption4iscorrect.UseVisualStyleBackColor = true;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(8, 232);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(176, 25);
            this.txtOption2.TabIndex = 4;
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(8, 192);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(176, 25);
            this.txtOption1.TabIndex = 3;
            // 
            // rboption3iscorrect
            // 
            this.rboption3iscorrect.AutoSize = true;
            this.rboption3iscorrect.Location = new System.Drawing.Point(208, 280);
            this.rboption3iscorrect.Name = "rboption3iscorrect";
            this.rboption3iscorrect.Size = new System.Drawing.Size(14, 13);
            this.rboption3iscorrect.TabIndex = 2;
            this.rboption3iscorrect.TabStop = true;
            this.rboption3iscorrect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 108;
            this.label2.Text = "Question Text";
            // 
            // rboption1iscorrect
            // 
            this.rboption1iscorrect.AutoSize = true;
            this.rboption1iscorrect.Location = new System.Drawing.Point(208, 200);
            this.rboption1iscorrect.Name = "rboption1iscorrect";
            this.rboption1iscorrect.Size = new System.Drawing.Size(14, 13);
            this.rboption1iscorrect.TabIndex = 1;
            this.rboption1iscorrect.TabStop = true;
            this.rboption1iscorrect.UseVisualStyleBackColor = true;
            // 
            // rboption2iscorrect
            // 
            this.rboption2iscorrect.AutoSize = true;
            this.rboption2iscorrect.Location = new System.Drawing.Point(208, 240);
            this.rboption2iscorrect.Name = "rboption2iscorrect";
            this.rboption2iscorrect.Size = new System.Drawing.Size(14, 13);
            this.rboption2iscorrect.TabIndex = 0;
            this.rboption2iscorrect.TabStop = true;
            this.rboption2iscorrect.UseVisualStyleBackColor = true;
            // 
            // cbxQuestionType
            // 
            this.cbxQuestionType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbxQuestionType.FormattingEnabled = true;
            this.cbxQuestionType.Location = new System.Drawing.Point(112, 32);
            this.cbxQuestionType.Name = "cbxQuestionType";
            this.cbxQuestionType.Size = new System.Drawing.Size(161, 25);
            this.cbxQuestionType.TabIndex = 107;
            this.cbxQuestionType.SelectedIndexChanged += new System.EventHandler(this.cbxQuestionType_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInsertTF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbtrue);
            this.groupBox2.Controls.Add(this.txttfquestiontext);
            this.groupBox2.Controls.Add(this.rbfalse);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(376, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 216);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "True / False";
            this.groupBox2.Visible = false;
            // 
            // btnInsertTF
            // 
            this.btnInsertTF.Location = new System.Drawing.Point(8, 184);
            this.btnInsertTF.Name = "btnInsertTF";
            this.btnInsertTF.Size = new System.Drawing.Size(232, 24);
            this.btnInsertTF.TabIndex = 111;
            this.btnInsertTF.Text = "Create";
            this.btnInsertTF.UseVisualStyleBackColor = true;
            this.btnInsertTF.Click += new System.EventHandler(this.btnInsertTF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "Question Text";
            // 
            // rbtrue
            // 
            this.rbtrue.AutoSize = true;
            this.rbtrue.Location = new System.Drawing.Point(120, 152);
            this.rbtrue.Name = "rbtrue";
            this.rbtrue.Size = new System.Drawing.Size(51, 21);
            this.rbtrue.TabIndex = 1;
            this.rbtrue.TabStop = true;
            this.rbtrue.Text = "True";
            this.rbtrue.UseVisualStyleBackColor = true;
            // 
            // txttfquestiontext
            // 
            this.txttfquestiontext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttfquestiontext.Location = new System.Drawing.Point(8, 56);
            this.txttfquestiontext.Multiline = true;
            this.txttfquestiontext.Name = "txttfquestiontext";
            this.txttfquestiontext.Size = new System.Drawing.Size(232, 88);
            this.txttfquestiontext.TabIndex = 109;
            // 
            // rbfalse
            // 
            this.rbfalse.AutoSize = true;
            this.rbfalse.Location = new System.Drawing.Point(184, 152);
            this.rbfalse.Name = "rbfalse";
            this.rbfalse.Size = new System.Drawing.Size(55, 21);
            this.rbfalse.TabIndex = 0;
            this.rbfalse.TabStop = true;
            this.rbfalse.Text = "False";
            this.rbfalse.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(936, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 32);
            this.btnBack.TabIndex = 114;
            this.btnBack.Text = "Return To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.panel1.TabIndex = 115;
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
            // add_new_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbxQuestionType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "add_new_question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Question";
            this.Load += new System.EventHandler(this.add_new_question_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsertMCQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmqcquestiontext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxQuestionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.RadioButton rboption4iscorrect;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.RadioButton rboption3iscorrect;
        private System.Windows.Forms.RadioButton rboption1iscorrect;
        private System.Windows.Forms.RadioButton rboption2iscorrect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtrue;
        private System.Windows.Forms.RadioButton rbfalse;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttfquestiontext;
        private System.Windows.Forms.Button btnInsertTF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnUser;
    }
}