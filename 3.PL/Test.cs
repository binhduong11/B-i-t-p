using _1.DAL.Models;
using _2.BUS.Iservices;
using _2.BUS.Services;
using _3.PL.Validate;
namespace _3.PL
{
    public partial class Test : Form
    {
        
        EmployeesIServices _employeeSevices;
        ExperienceIServices _experienceService;
        CertificateIServices _certificateService;
        Check _check = new Check();
        public Employee _employee = new Employee();
        public int getCertificateID;
        int _id;
        public Test()
        {
            _employeeSevices = new Employees_Services();
            _experienceService = new Experience_Services();
            _certificateService = new Certificate_Services();   
            InitializeComponent();
        }
        public void cbb()
        {
            cbb_loai.Items.Add("Experience");
            cbb_loai.Items.Add("Fresher");
            cbb_loai.Items.Add("Intern");
        }
        public void LoadData(List<Employee> x)
        {
            dtg_view.Rows.Clear();
            dtg_view.ColumnCount = 6;
            dtg_view.Columns[0].Name = "ID";
            dtg_view.Columns[1].Name = "Tên";
            dtg_view.Columns[2].Name = "Ngày sinh";
            dtg_view.Columns[3].Name = "SDT";
            dtg_view.Columns[4].Name = "Email";
            foreach (var a in x)
            {
                dtg_view.Rows.Add(a.ID, a.FullName, a.BirthDay, a.Phone, a.Email);
            }
        }
        private void Test_Load(object sender, EventArgs e)
        {
            cbb();
            LoadData(_employeeSevices.GetAll());
        }
        public Employee? getdata()
        {
            if (_check.CheckBirthDay(dtp_birthday.Value))
            {
                if (_check.CheckMail(txt_email.Text))
                {
                    if (_check.CheckPhone(txt_phone.Text))
                    {
                        _employee.Email = txt_email.Text;
                        _employee.FullName = txt_fullname.Text;
                        _employee.BirthDay = dtp_birthday.Value;
                        _employee.Phone = txt_phone.Text;
                        _employee.Employee_count = _employeeSevices.GetAll().Count + 1;
                        _employee.Employee_type = cbb_loai.Text == "Experience" ? 0 : (cbb_loai.Text == "Fresher" ? 1 : 2);
                        return _employee;
                    }
                    else
                    {
                        MessageBox.Show("SDT khoong hop le");
                        return null;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Email khoong hop le");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Ngayf sinh khoong hop le");
                
            }
            return null;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Employee _obj =  getdata();

            //_obj.Email = txt_email.Text;
            //_obj.FullName = txt_fullname.Text;
            //_obj.BirthDay = dtp_birthday.Value;
            //_obj.Phone = txt_phone.Text;
            //_obj.Employee_count = _employeeSevices.GetAll().Count +1 ;
            //_obj.Employee_type = cbb_loai.Text == "Experience" ? 0 : (cbb_loai.Text == "Fresher" ? 1 : 2);

            if (_obj!= null)
            {
                if (_obj.Employee_type == 0)
                {
                    AddExperience addExperience = new AddExperience();
                    addExperience._Employee = _obj;
                    addExperience.Show();
                    LoadData(_employeeSevices.GetAll());
                    clead();
                }
                if (_obj.Employee_type == 1)
                {
                    AddFresher addFresher = new AddFresher();
                    addFresher._Employee = _obj;
                    addFresher.Show();
                    LoadData(_employeeSevices.GetAll());
                    clead();
                }
                if (_obj.Employee_type == 2)
                {
                    AddIntern addIntern = new AddIntern();
                    addIntern._Employee = _obj;
                    addIntern.Show();
                    LoadData(_employeeSevices.GetAll());
                    clead();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_showinfor_Click(object sender, EventArgs e)
        {
            Employee y = _employeeSevices.GetAll().FirstOrDefault(c => c.ID.ToString() == dtg_view.CurrentRow.Cells[0].Value.ToString());
            txt_show.Text = y.ShowInfor();
        }

        private void dtg_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Employee x = _employeeSevices.GetAll().FirstOrDefault(c => c.ID.ToString() == dtg_view.CurrentRow.Cells[0].Value.ToString());
            txt_email.Text = x.Email;
            txt_phone.Text = x.Phone;
            dtp_birthday.Value = x.BirthDay;
            txt_fullname.Text = x.FullName;
            cbb_loai.Text = x.Employee_type == 0 ? "Experience" : (x.Employee_type == 1 ? "Fresher" : "Intern");
            _id = x.ID;

            if (_certificateService.GetAll().Where(c => c.EmployeeID == _id).ToList() != null)
            {
                LoaddataToCertificates(_certificateService.GetAll().Where(c => c.EmployeeID == _id).ToList());
            }

        }
        public void clead()
        {
            txt_email.Text = null;
            txt_phone.Text = null;
           
            txt_fullname.Text = null;
            txt_show.Text=null;
            _id = 0;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Employee x = getdata();
            Employee y = _employeeSevices.GetAll().FirstOrDefault(c => c.ID.ToString() == dtg_view.CurrentRow.Cells[0].Value.ToString());

            if (x!= null)
            {
                if (x.Employee_type != y.Employee_type)
                {
                    MessageBox.Show("Không thể thay đổi loại");
                    return;
                }
                else
                {
                    MessageBox.Show(_employeeSevices.Update(x,y.ID));
                    LoadData(_employeeSevices.GetAll());
                    clead();
                }
            }
            return;
        }

        private void btn_showme_Click(object sender, EventArgs e)
        {
            Employee y = _employeeSevices.GetAll().FirstOrDefault(c => c.ID.ToString() == dtg_view.CurrentRow.Cells[0].Value.ToString());
            
            if (y is Experience)
            {
                Experience experience = (Experience)y;
                txt_show.Text= experience.ShowInfor(experience.ExpInYear, experience.ProSkill);
            }
            if (y is Fresher)
            {
                Fresher Fresher = (Fresher)y;
                txt_show.Text = Fresher.ShowInfor(Fresher.Graduation_date, Fresher.Graduation_rank, Fresher.Education);
            }
            if (y is Intern)
            {
                Intern Intern = (Intern)y;
                txt_show.Text = Intern.ShowInfor(Intern.Majors, Intern.Semester, Intern.University_name);
            }   
        }
        public void LoaddataToCertificates(List<Certificate> x)
        {
            dtg_Certificate.Rows.Clear();
            dtg_Certificate.ColumnCount = 4;
            dtg_Certificate.Columns[0].Name = "id";
            dtg_Certificate.Columns[1].Name = "Tên";
            dtg_Certificate.Columns[2].Name = "Xếp loại";
            dtg_Certificate.Columns[3].Name = "Thời hạn";
            foreach (var a in x)
            {
                dtg_Certificate.Rows.Add(a.CertificateID, a.CertificateName, a.CertificateRank, a.CertificatedDate);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Certificates certificate = new Certificates();
            certificate.id = (int)dtg_view.CurrentRow.Cells[0].Value;
            certificate.Show();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            int type = cbb_loai.Text == "Experience" ? 0 : (cbb_loai.Text == "Fresher" ? 1 : 2);
            if (cbb_loai.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn 1 loại nhân viên");
            }
            else
            {
                List<Employee> x = _employeeSevices.GetAll().Where(c => c.Employee_type == type).ToList();
                LoadData(x);
            }
        }

        private void buttsuabtn_xoa_Click(object sender, EventArgs e)
        {
            Employee y = _employeeSevices.GetAll().FirstOrDefault(c => c.ID.ToString() == dtg_view.CurrentRow.Cells[0].Value.ToString());
            if (y==null)
            {
                MessageBox.Show("Chọn một đối tượng");
            }
            else
            {
                MessageBox.Show(_employeeSevices.Delete(y));
                LoadData(_employeeSevices.GetAll());
                clead();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Certificates certificate = new Certificates();
            certificate.id = (int)dtg_view.CurrentRow.Cells[0].Value;
            certificate.CertificateID = getCertificateID;
            certificate.Show();
        }

        private void dtg_Certificate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getCertificateID = (int)dtg_Certificate.CurrentRow.Cells[0].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Certificate certificate = _certificateService.GetAll().FirstOrDefault(c => c.CertificateID == getCertificateID);
            if (certificate == null)
            {
                MessageBox.Show("Chưa chọn đối tượng");
            }
            else
            {
                
                MessageBox.Show(_certificateService.Delete(certificate));
            }
        }
    }
}