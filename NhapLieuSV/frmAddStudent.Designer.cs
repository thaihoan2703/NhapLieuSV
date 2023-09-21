namespace NhapLieuSV
{
    partial class frmAddStudent
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
            this.lblStdID = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblStdAvgScore = new System.Windows.Forms.Label();
            this.txtStdID = new System.Windows.Forms.TextBox();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.txtAvgScore = new System.Windows.Forms.TextBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.Location = new System.Drawing.Point(55, 46);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(50, 13);
            this.lblStdID.TabIndex = 0;
            this.lblStdID.Text = "Ma so sv";
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Location = new System.Drawing.Point(55, 89);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(58, 13);
            this.lblStdName.TabIndex = 0;
            this.lblStdName.Text = "Ho va Ten";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(55, 144);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(32, 13);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Khoa";
            // 
            // lblStdAvgScore
            // 
            this.lblStdAvgScore.AutoSize = true;
            this.lblStdAvgScore.Location = new System.Drawing.Point(55, 197);
            this.lblStdAvgScore.Name = "lblStdAvgScore";
            this.lblStdAvgScore.Size = new System.Drawing.Size(48, 13);
            this.lblStdAvgScore.TabIndex = 0;
            this.lblStdAvgScore.Text = "Diem TB";
            // 
            // txtStdID
            // 
            this.txtStdID.Location = new System.Drawing.Point(137, 38);
            this.txtStdID.Name = "txtStdID";
            this.txtStdID.Size = new System.Drawing.Size(100, 20);
            this.txtStdID.TabIndex = 1;
            // 
            // txtStdName
            // 
            this.txtStdName.Location = new System.Drawing.Point(137, 86);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(221, 20);
            this.txtStdName.TabIndex = 1;
            // 
            // txtAvgScore
            // 
            this.txtAvgScore.Location = new System.Drawing.Point(137, 197);
            this.txtAvgScore.Name = "txtAvgScore";
            this.txtAvgScore.Size = new System.Drawing.Size(100, 20);
            this.txtAvgScore.TabIndex = 1;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Ngôn Ngữ Anh",
            "Quản Trị Kinh Doanh"});
            this.cmbFaculty.Location = new System.Drawing.Point(137, 144);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(208, 21);
            this.cmbFaculty.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Them moi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(307, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 353);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.txtAvgScore);
            this.Controls.Add(this.txtStdName);
            this.Controls.Add(this.txtStdID);
            this.Controls.Add(this.lblStdAvgScore);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblStdName);
            this.Controls.Add(this.lblStdID);
            this.Name = "frmAddStudent";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblStdAvgScore;
        private System.Windows.Forms.TextBox txtStdID;
        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.TextBox txtAvgScore;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}