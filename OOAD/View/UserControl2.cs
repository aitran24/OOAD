using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD.View
{
    public partial class UserControl2 : UserControl
    { 
        public static string static_day;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            labeldays.Text = numday + ""; 
        }

        private void UserControl2_Click(object sender, EventArgs e)
        {
            static_day = labeldays.Text;
            timer1.Start();
            FormSetAppointment formSetAppointment = new FormSetAppointment();
            formSetAppointment.Show();
        }
        private void displayEvent()
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            //gọi hàm đíplay
            displayEvent();
        }

        private void labelEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
