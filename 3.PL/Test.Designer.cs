namespace _3.PL
{
    partial class Test
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.dtg_view = new System.Windows.Forms.DataGridView();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.buttsuabtn_xoa = new System.Windows.Forms.Button();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.btn_showinfor = new System.Windows.Forms.Button();
            this.btn_showme = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_loc = new System.Windows.Forms.Button();
            this.dtg_Certificate = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Certificate)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(64, 279);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên";
            // 
            // cbb_loai
            // 
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Location = new System.Drawing.Point(197, 208);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(151, 28);
            this.cbb_loai.TabIndex = 2;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(197, 127);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(250, 27);
            this.dtp_birthday.TabIndex = 3;
            // 
            // dtg_view
            // 
            this.dtg_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_view.Location = new System.Drawing.Point(0, 454);
            this.dtg_view.Name = "dtg_view";
            this.dtg_view.RowHeadersWidth = 51;
            this.dtg_view.RowTemplate.Height = 29;
            this.dtg_view.Size = new System.Drawing.Size(1258, 180);
            this.dtg_view.TabIndex = 4;
            this.dtg_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_CellContentClick);
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(197, 45);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(125, 27);
            this.txt_fullname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SDT";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(197, 84);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(125, 27);
            this.txt_phone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(197, 160);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(125, 27);
            this.txt_email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(197, 279);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 29);
            this.btn_sua.TabIndex = 0;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // buttsuabtn_xoa
            // 
            this.buttsuabtn_xoa.Location = new System.Drawing.Point(317, 279);
            this.buttsuabtn_xoa.Name = "buttsuabtn_xoa";
            this.buttsuabtn_xoa.Size = new System.Drawing.Size(94, 29);
            this.buttsuabtn_xoa.TabIndex = 0;
            this.buttsuabtn_xoa.Text = "Xóa";
            this.buttsuabtn_xoa.UseVisualStyleBackColor = true;
            this.buttsuabtn_xoa.Click += new System.EventHandler(this.buttsuabtn_xoa_Click);
            // 
            // txt_show
            // 
            this.txt_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_show.Location = new System.Drawing.Point(34, 401);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(645, 20);
            this.txt_show.TabIndex = 6;
            // 
            // btn_showinfor
            // 
            this.btn_showinfor.Location = new System.Drawing.Point(105, 357);
            this.btn_showinfor.Name = "btn_showinfor";
            this.btn_showinfor.Size = new System.Drawing.Size(94, 29);
            this.btn_showinfor.TabIndex = 7;
            this.btn_showinfor.Text = "ShowInfornfor";
            this.btn_showinfor.UseVisualStyleBackColor = true;
            this.btn_showinfor.Click += new System.EventHandler(this.btn_showinfor_Click);
            // 
            // btn_showme
            // 
            this.btn_showme.Location = new System.Drawing.Point(228, 357);
            this.btn_showme.Name = "btn_showme";
            this.btn_showme.Size = new System.Drawing.Size(94, 29);
            this.btn_showme.TabIndex = 7;
            this.btn_showme.Text = "ShowMe";
            this.btn_showme.UseVisualStyleBackColor = true;
            this.btn_showme.Click += new System.EventHandler(this.btn_showme_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(913, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1032, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(1152, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(371, 208);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(177, 29);
            this.btn_loc.TabIndex = 8;
            this.btn_loc.Text = "Hiển thị theo loại";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // dtg_Certificate
            // 
            this.dtg_Certificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Certificate.Location = new System.Drawing.Point(805, 120);
            this.dtg_Certificate.Name = "dtg_Certificate";
            this.dtg_Certificate.RowHeadersWidth = 51;
            this.dtg_Certificate.RowTemplate.Height = 29;
            this.dtg_Certificate.Size = new System.Drawing.Size(453, 188);
            this.dtg_Certificate.TabIndex = 9;
            this.dtg_Certificate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Certificate_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Certificate";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 634);
            this.Controls.Add(this.dtg_Certificate);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_showme);
            this.Controls.Add(this.btn_showinfor);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.dtg_view);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_loai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttsuabtn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Name = "Test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Certificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_them;
        private Label label1;
        private ComboBox cbb_loai;
        private DateTimePicker dtp_birthday;
        private DataGridView dtg_view;
        private TextBox txt_fullname;
        private Label label2;
        private TextBox txt_phone;
        private Label label3;
        private TextBox txt_email;
        private Label label4;
        private Label label6;
        private Button btn_sua;
        private Button buttsuabtn_xoa;
        private TextBox txt_show;
        private Button btn_showinfor;
        private Button btn_showme;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_loc;
        private DataGridView dtg_Certificate;
        private Label label5;
    }
}