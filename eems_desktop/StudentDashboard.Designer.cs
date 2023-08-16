namespace eems_desktop
{
    partial class StudentDashboard
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
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectExamID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(720, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvExam
            // 
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Location = new System.Drawing.Point(248, 48);
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.Size = new System.Drawing.Size(544, 200);
            this.dgvExam.TabIndex = 10;
            this.dgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellClick);
            this.dgvExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellContentClick);
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(248, 312);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(544, 128);
            this.dgvResult.TabIndex = 11;
            this.dgvResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellContentClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(464, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Selected:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectExamID
            // 
            this.selectExamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectExamID.Location = new System.Drawing.Point(248, 24);
            this.selectExamID.Name = "selectExamID";
            this.selectExamID.ReadOnly = true;
            this.selectExamID.Size = new System.Drawing.Size(208, 20);
            this.selectExamID.TabIndex = 89;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectExamID);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.dgvExam);
            this.Controls.Add(this.btnLogout);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectExamID;
    }
}