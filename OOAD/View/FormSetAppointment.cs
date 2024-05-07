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
using OOAD.DAL;
using OOAD.DTO;
namespace OOAD.View
{
    public partial class FormSetAppointment : Form
    {
        public FormSetAppointment()
        {
            InitializeComponent();
        }

        private void FormSetAppointment_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = UserControl2.static_day + "/"+ MainForm.static_month + "/" + MainForm.static_year;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string location = textBoxLocation.Text;
            Appointment appointment = new Appointment();
            appointment.Description = richTextBoxdescription.Text;
            appointment.NameAppoint = textBoxTieuDe.Text;
            appointment.Endtime = dateTimePickerendtime.Value.TimeOfDay;
            appointment.Starttime = dateTimePickerstarttime.Value.TimeOfDay;
            appointment.Location = location;
            appointment.IDuser = LoggedInUser.User.IDuser;

            DBHelper dbManager = new DBHelper();
            bool success = dbManager.SaveAppointment(appointment);

                if (success)
                {
                    MessageBox.Show("Cuộc hẹn đã được lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Lưu cuộc hẹn thất bại. Vui lòng thử lại sau!");
                
            }


        }


    }
}
