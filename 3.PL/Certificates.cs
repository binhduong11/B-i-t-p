using _1.DAL.Models;
using _2.BUS.Iservices;
using _2.BUS.Services;

namespace _3.PL
{
    public partial class Certificates : Form
    {
        CertificateIServices _certificateService;
        public int id;
        public int CertificateID;
        public Certificates()
        {
            _certificateService = new Certificate_Services();
            InitializeComponent();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int randomNumber = random.Next(1, 1000);
            Certificate certificate = new Certificate();
            //certificate.CertificateID = randomNumber;
            certificate.EmployeeID = id;
            certificate.CertificateRank = cbb_rank.Text;
            certificate.CertificatedDate = dtp_date.Value;
            certificate.CertificateName = txt_name.Text;
            MessageBox.Show(_certificateService.Add(certificate));

        }

        private void Certificates_Load(object sender, EventArgs e)
        {
            loadCbb();
        }
        public void loadCbb()
        {
            cbb_rank.Items.Add("Giỏi");
            cbb_rank.Items.Add("Khá");
            cbb_rank.Items.Add("Trung bình");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Certificate certificate = _certificateService.GetAll().FirstOrDefault(c=>c.CertificateID == CertificateID);
            if (certificate == null)
            {
                MessageBox.Show("Chưa chọn đối tượng");
            }
            else
            {
                certificate.CertificateRank = cbb_rank.Text;
                certificate.CertificatedDate = dtp_date.Value;
                certificate.CertificateName = txt_name.Text;
                MessageBox.Show(_certificateService.Update(certificate));
            }
        }
    }
}
