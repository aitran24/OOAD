using OOAD.DAL;
using OOAD.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OOAD.BLL
{
    internal class Appointment_BLL
    {
       
            Appointment_DAL tkAccess = new Appointment_DAL();
            public string CheckLogic(Userlogin taikhoan)
            {
                // Kiểm tra nghiệp vụ
                string info = tkAccess.CheckLogic(taikhoan);
                return info;
            }
        public string GetUserFullname(Userlogin user)
        {
            string fullname = DBHelper.GetUserFullname(user);
            return fullname;
        }
            public List<Appointment> GetAppointmentsForUser(Userlogin currentUser)
            {   
                List<Appointment> appointments = new List<Appointment>();
                try
                {
                    DBHelper dbHelper = new DBHelper();
                    appointments = dbHelper.GetAppointmentsForUser(currentUser);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            return appointments;
            }
        }
    }

