namespace eems_desktop
{
    partial class teacher_view_exam_question
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
            this.dataGridExamQuestion = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddNewExam = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.selectExamID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExamQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(688, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 23);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "Return To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridExamQuestion
            // 
            this.dataGridExamQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExamQuestion.Location = new System.Drawing.Point(168, 72);
            this.dataGridExamQuestion.Name = "dataGridExamQuestion";
            this.dataGridExamQuestion.Size = new System.Drawing.Size(624, 368);
            this.dataGridExamQuestion.TabIndex = 87;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 13);
            this.lblTitle.TabIndex = 86;
            this.lblTitle.Text = "Exam Question";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(8, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 23);
            this.btnLogout.TabIndex = 84;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAddNewExam
            // 
            this.btnAddNewExam.Location = new System.Drawing.Point(688, 40);
            this.btnAddNewExam.Name = "btnAddNewExam";
            this.btnAddNewExam.Size = new System.Drawing.Size(104, 24);
            this.btnAddNewExam.TabIndex = 97;
            this.btnAddNewExam.Text = "Add New";
            this.btnAddNewExam.UseVisualStyleBackColor = true;
            this.btnAddNewExam.Click += new System.EventHandler(this.btnAddNewExam_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 118;
            this.label8.Text = "Selected:";
            // 
            // selectExamID
            // 
            this.selectExamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectExamID.Location = new System.Drawing.Point(168, 40);
            this.selectExamID.Name = "selectExamID";
            this.selectExamID.ReadOnly = true;
            this.selectExamID.Size = new System.Drawing.Size(128, 20);
            this.selectExamID.TabIndex = 117;
            // 
            // teacher_view_exam_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectExamID);
            this.Controls.Add(this.btnAddNewExam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridExamQuestion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Name = "teacher_view_exam_question";
            this.Text = "teacher_view_exam_question";
            this.Load += new System.EventHandler(this.teacher_view_exam_question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExamQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridExamQuestion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddNewExam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectExamID;
    }
}