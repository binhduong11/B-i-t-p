namespace _3.PL
{
    partial class AddFresher
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
            this.txt_Education = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Graduation_rank = new System.Windows.Forms.ComboBox();
            this.dtp_GraduationDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_Education
            // 
            this.txt_Education.Location = new System.Drawing.Point(508, 196);
            this.txt_Education.Name = "txt_Education";
            this.txt_Education.Size = new System.Drawing.Size(125, 27);
            this.txt_Education.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thời gian tốt nghiệp";
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(508, 293);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(94, 29);
            this.btn_xacnhan.TabIndex = 3;
            this.btn_xacnhan.Text = "xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xếp loạt tốt nghiệp";
            // 
            // cbb_Graduation_rank
            // 
            this.cbb_Graduation_rank.FormattingEnabled = true;
            this.cbb_Graduation_rank.Location = new System.Drawing.Point(508, 242);
            this.cbb_Graduation_rank.Name = "cbb_Graduation_rank";
            this.cbb_Graduation_rank.Size = new System.Drawing.Size(151, 28);
            this.cbb_Graduation_rank.TabIndex = 9;
            // 
            // dtp_GraduationDate
            // 
            this.dtp_GraduationDate.Location = new System.Drawing.Point(508, 152);
            this.dtp_GraduationDate.Name = "dtp_GraduationDate";
            this.dtp_GraduationDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_GraduationDate.TabIndex = 10;
            // 
            // AddFresher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 470);
            this.Controls.Add(this.dtp_GraduationDate);
            this.Controls.Add(this.cbb_Graduation_rank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Education);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xacnhan);
            this.Name = "AddFresher";
            this.Text = "AddFresher";
            this.Load += new System.EventHandler(this.AddFresher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Education;
        private Label label2;
        private Label label1;
        private Button btn_xacnhan;
        private Label label3;
        private ComboBox cbb_Graduation_rank;
        private DateTimePicker dtp_GraduationDate;
    }
}