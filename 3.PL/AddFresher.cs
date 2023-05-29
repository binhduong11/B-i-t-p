using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.Models;
using _2.BUS.Iservices;
using _2.BUS.Services;
namespace _3.PL
{
    public partial class AddFresher : Form
    {
        public Employee _Employee;
        FresherIServices _Services;
        public AddFresher()
        {
            _Services = new Fresher_Services();
            InitializeComponent();
        }

        private void AddFresher_Load(object sender, EventArgs e)
        {
            cbb_Graduation_rank.Items.Add("Giỏi");
            cbb_Graduation_rank.Items.Add("Khá");
            cbb_Graduation_rank.Items.Add("Trung bình");
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_Services.Add(_Employee, dtp_GraduationDate.Value, cbb_Graduation_rank.Text, txt_Education.Text));
        }
    }
}
