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
            this.btnAddNewExam = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.selectExamID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExamQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(1080, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 32);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "Return To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridExamQuestion
            // 
            this.dataGridExamQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridExamQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExamQuestion.Location = new System.Drawing.Point(16, 96);
            this.dataGridExamQuestion.Name = "dataGridExamQuestion";
            this.dataGridExamQuestion.Size = new System.Drawing.Size(1232, 576);
            this.dataGridExamQuestion.TabIndex = 87;
            // 
            // btnAddNewExam
            // 
            this.btnAddNewExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewExam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAddNewExam.Location = new System.Drawing.Point(1080, 48);
            this.btnAddNewExam.Name = "btnAddNewExam";
            this.btnAddNewExam.Size = new System.Drawing.Size(168, 32);
            this.btnAddNewExam.TabIndex = 97;
            this.btnAddNewExam.Text = "Add New";
            this.btnAddNewExam.UseVisualStyleBackColor = true;
            this.btnAddNewExam.Click += new System.EventHandler(this.btnAddNewExam_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(16, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 118;
            this.label8.Text = "Selected:";
            // 
            // selectExamID
            // 
            this.selectExamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectExamID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.selectExamID.Location = new System.Drawing.Point(16, 64);
            this.selectExamID.Name = "selectExamID";
            this.selectExamID.ReadOnly = true;
            this.selectExamID.Size = new System.Drawing.Size(184, 25);
            this.selectExamID.TabIndex = 117;
            // 
            // teacher_view_exam_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectExamID);
            this.Controls.Add(this.btnAddNewExam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridExamQuestion);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
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
        private System.Windows.Forms.Button btnAddNewExam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectExamID;
    }
}