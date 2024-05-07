using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OOAD.BLL;
using OOAD.DAL;
using OOAD.DTO;


namespace OOAD.View
{

    public partial class LoginForm : Form
    {
        Userlogin userlogin = new Userlogin();
        //LoggedInUser.User = userlogin;
        //TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            userlogin.Username = textBoxusername.Text;
            userlogin.Password = textBoxPass.Text;

           // Appointment_DAL appointmentDAL = new Appointment_DAL(); // Tạo một thể hiện của Appointment_DAL
           // string getuser = appointmentDAL.CheckLogic(userlogin);
            Appointment_BLL appointmentBLL = new Appointment_BLL();
            string getuser = appointmentBLL.CheckLogic(userlogin);
            LoggedInUser.User = userlogin;
            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "false":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
                default:
                    MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công hệ thống!");
                    // Đóng form hiện tại
                    this.Hide();
                    // Mở MainForm
                    MainForm mainForm = new MainForm(userlogin);
                    mainForm.Show();
                    break;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxusername.Text = "";
            textBoxPass.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
