using OOAD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OOAD.DAL
{
    public class DBHelper
    {

        public static string CheckLogicDTO(Userlogin taikhoan)
        {
            string user = null;

            try
            {
                using (SqlConnection conn = Connect())
                {
                    conn.Open();
                    string query = "SELECT Username FROM users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Username", taikhoan.Username);
                    command.Parameters.AddWithValue("@Password", taikhoan.Password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                user = reader.GetString(0);
                            }
                        }
                        else
                        {
                            user = "false";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            return user;
        }

        private static SqlConnection Connect()
        {
            string strcon = @"Data Source=AITRAN\MSSQLSERVER02;Initial Catalog=OOAD;Integrated Security=True;Encrypt=False";
            return new SqlConnection(strcon);
        }

     //   public string 
        public static string GetUserFullname(Userlogin user)
        {
            string fullname = null;

            try
            {
                using (SqlConnection conn = Connect())
                {
                    conn.Open();
                    string query = "SELECT Fullname FROM users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                fullname = reader.GetString(reader.GetOrdinal("Fullname"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            return fullname;
        }
        public List<Appointment> GetAppointmentsForUser(Userlogin user)
        {
            List<Appointment> appointments = new List<Appointment>();
            Userlogin loggedInUser = LoggedInUser.User;
            try
            { 
                using (SqlConnection conn = Connect())
                {
                    conn.Open();
                    string query = @"SELECT NameAppoint, Description, Location, Starttime, Endtime,
                             FROM Appointments
                             WHERE Appointments.IDuser = @IDuser";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@IDuser", loggedInUser.IDuser);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.NameAppoint = reader.GetString(reader.GetOrdinal("NameAppoint"));
                            appointment.Description = reader.GetString(reader.GetOrdinal("Description"));
                            appointment.Location = reader.GetString(reader.GetOrdinal("Location"));
                            appointment.Starttime = reader.GetTimeSpan(reader.GetOrdinal("Starttime"));
                            appointment.Endtime = reader.GetTimeSpan(reader.GetOrdinal("Endtime"));
                            appointment.AppointmentDate = reader.GetDateTime(reader.GetOrdinal("AppointmentDate"));
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            return appointments;
        }
        public bool SaveAppointment(Appointment appointment)
        {
            try
            {
                using (SqlConnection conn = Connect())
                {
                    conn.Open();
                    string query = "INSERT INTO Appointments (IDuser, NameAppoint, Location, Starttime, Endtime, Description) VALUES (@IDuser, @NameAppoint, @Location, @Starttime, @Endtime, @Description)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@IDuser", LoggedInUser.User.IDuser);
                    command.Parameters.AddWithValue("@NameAppoint", appointment.NameAppoint);
                    command.Parameters.AddWithValue("@Location", appointment.Location);
                    command.Parameters.AddWithValue("@Starttime", appointment.Starttime);
                    command.Parameters.AddWithValue("@Endtime", appointment.Endtime);
                    command.Parameters.AddWithValue("@Description", appointment.Description);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }


    }
}
