using OOAD.DAL;
using OOAD.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD.DTO;

namespace OOAD.View
{
    public partial class MainForm : Form
    {
        int month, year;
        public static int static_month, static_year;
        Appointment_BLL appointmentBLL = new Appointment_BLL();

        private Userlogin userlogin;

        public MainForm(Userlogin user)

        {
            InitializeComponent();
            userlogin = user;
            Userlogin loggedInUser = LoggedInUser.User;
            labelNameuser.Text = appointmentBLL.GetUserFullname(loggedInUser);
            UpdateDataGridView(appointmentBLL.GetAppointmentsForUser(loggedInUser));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            displayDays();
            //UpdateDataGridView(appointmentBLL.GetAppointmentsForUser(userlogin));
        }
        private void UpdateDataGridView(List<Appointment> appointments)
        {
            // Clear existing rows in the DataGridView
           this.datagridview.Rows.Clear();
            
            this.datagridview.Columns.Add("NameAppoint", "Name Appointment");
            this.datagridview.Columns.Add("Location", "Location");
            this.datagridview.Columns.Add("Starttime", "Start Time");
            this.datagridview.Columns.Add("Endtime", "End Time");
            this.datagridview.Columns.Add("AppointmentDate", "Appointment Date");
            this.datagridview.Columns.Add("Description", "Description");

            foreach (Appointment appointment in appointments)
            {
               int rowIndex = this.datagridview.Rows.Add();
               DataGridViewRow row = this.datagridview.Rows[rowIndex];
               row.Cells[1].Value = appointment.NameAppoint;
               row.Cells[2].Value = appointment.Location;
               row.Cells[3].Value = appointment.Starttime.ToString();
               row.Cells[4].Value = appointment.Endtime.ToString();
               row.Cells[5].Value = appointment.AppointmentDate.ToString();
               row.Cells[0].Value = appointment.Description;
            }
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            
            labelMONTH_YEAR.Text = monthname+ "    "+ year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoddtheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            for (int i =1; i<dayoddtheweek; i++)
            {
                UserControl1 ucb = new UserControl1();
                daycontainer.Controls.Add(ucb);
            }
            for (int i=1; i<=days; i++)
            {
                UserControl2 ucD = new UserControl2();
                ucD.days(i);
                daycontainer.Controls.Add(ucD);
            }

        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            // Tăng tháng và điều chỉnh năm nếu cần
            month--;
            if (month <1)
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMONTH_YEAR.Text = monthname + "    " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoddtheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoddtheweek; i++)
            {
                UserControl1 ucb = new UserControl1();
                daycontainer.Controls.Add(ucb);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucD = new UserControl2();
                ucD.days(i);
                daycontainer.Controls.Add(ucD);
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            // Tăng tháng và điều chỉnh năm nếu cần
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            labelMONTH_YEAR.Text = monthname + "    " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoddtheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d") ) + 1;

            for (int i = 1; i < dayoddtheweek; i++)
            {
                UserControl1 ucb = new UserControl1();
                daycontainer.Controls.Add(ucb);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucD = new UserControl2();
                ucD.days(i);
                daycontainer.Controls.Add(ucD);
            }
        }

    }
}
