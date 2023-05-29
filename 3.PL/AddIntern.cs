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
    public partial class AddIntern : Form
    {
        public Employee _Employee;
        InternIServices _Services;
        public AddIntern()
        {
            _Services = new Intern_Services();
            InitializeComponent();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_Services.Add(_Employee, txt_Majors.Text, txt_Semester.Text, txt_University_name.Text));
        }
    }
}
