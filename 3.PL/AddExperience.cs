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
    public partial class AddExperience : Form
    {
        public Employee _Employee;
        
        EmployeesIServices _employeeSevices;
        ExperienceIServices _experienceService;
        public AddExperience()
        {
            _employeeSevices = new Employees_Services();
            _experienceService = new Experience_Services();
            InitializeComponent();
        }

        private void AddExperience_Load(object sender, EventArgs e)
        {

        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show(_experienceService.Add(_Employee, Convert.ToInt32(txt_expInYear.Text), txt_proskill.Text));
            txt_expInYear.Text = _Employee.Employee_type.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_expInYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_proskill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
