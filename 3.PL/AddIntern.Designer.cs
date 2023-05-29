namespace _3.PL
{
    partial class AddIntern
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
            this.txt_Semester = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Majors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_University_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Semester
            // 
            this.txt_Semester.Location = new System.Drawing.Point(429, 193);
            this.txt_Semester.Name = "txt_Semester";
            this.txt_Semester.Size = new System.Drawing.Size(125, 27);
            this.txt_Semester.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Học kỳ";
            // 
            // txt_Majors
            // 
            this.txt_Majors.Location = new System.Drawing.Point(429, 146);
            this.txt_Majors.Name = "txt_Majors";
            this.txt_Majors.Size = new System.Drawing.Size(125, 27);
            this.txt_Majors.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chuyên ngành";
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(429, 290);
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
            this.label3.Location = new System.Drawing.Point(269, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trường";
            // 
            // txt_University_name
            // 
            this.txt_University_name.Location = new System.Drawing.Point(429, 242);
            this.txt_University_name.Name = "txt_University_name";
            this.txt_University_name.Size = new System.Drawing.Size(125, 27);
            this.txt_University_name.TabIndex = 6;
            // 
            // AddIntern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 464);
            this.Controls.Add(this.txt_University_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Semester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Majors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xacnhan);
            this.Name = "AddIntern";
            this.Text = "AddIntern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Semester;
        private Label label2;
        private TextBox txt_Majors;
        private Label label1;
        private Button btn_xacnhan;
        private Label label3;
        private TextBox txt_University_name;
    }
}