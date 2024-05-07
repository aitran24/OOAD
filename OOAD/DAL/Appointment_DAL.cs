using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD.BLL;
using OOAD.DAL;
using OOAD.DTO;
using System.Data;
using System.Xml.Linq;

namespace OOAD.DAL
{
    public class Appointment_DAL
    {

     
        public string CheckLogic(Userlogin taikhoan)
            {
            if (string.IsNullOrEmpty(taikhoan.Username))
            {
                return "requeid_taikhoan";
            }

            if (string.IsNullOrEmpty(taikhoan.Password))
            {
                return "requeid_password";
            }
            string info = DBHelper.CheckLogicDTO(taikhoan);
                return info;
            }



    }
}
