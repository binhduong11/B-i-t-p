namespace _3.PL
{
    partial class AddExperience
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
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_expInYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_proskill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(519, 256);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(94, 29);
            this.btn_xacnhan.TabIndex = 0;
            this.btn_xacnhan.Text = "xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số năm kinh nghiệm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_expInYear
            // 
            this.txt_expInYear.Location = new System.Drawing.Point(519, 112);
            this.txt_expInYear.Name = "txt_expInYear";
            this.txt_expInYear.Size = new System.Drawing.Size(125, 27);
            this.txt_expInYear.TabIndex = 2;
            this.txt_expInYear.TextChanged += new System.EventHandler(this.txt_expInYear_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kĩ năng chuyên môn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_proskill
            // 
            this.txt_proskill.Location = new System.Drawing.Point(519, 159);
            this.txt_proskill.Name = "txt_proskill";
            this.txt_proskill.Size = new System.Drawing.Size(125, 27);
            this.txt_proskill.TabIndex = 2;
            this.txt_proskill.TextChanged += new System.EventHandler(this.txt_proskill_TextChanged);
            // 
            // AddExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 416);
            this.Controls.Add(this.txt_proskill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_expInYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xacnhan);
            this.Name = "AddExperience";
            this.Text = "AddExperience";
            this.Load += new System.EventHandler(this.AddExperience_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_xacnhan;
        private Label label1;
        private TextBox txt_expInYear;
        private Label label2;
        private TextBox txt_proskill;
    }
}