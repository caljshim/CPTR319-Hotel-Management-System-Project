using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public class DataAccess
    {
        //The following methods configure data from the Users table, and are used by the AddGuests.cs user control file.
        public bool checkUserExists(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<UserModel>($"select * from Users where user_name = '{username}'").ToList();
                if (output.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<UserModel> LoginUser(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<UserModel>($"select * from Users where user_name = '{ username }' and user_password = '{ password }'").ToList();
                return output;
            }
        }

        public void AddUser(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<UserModel>($"insert into Users values ('{username}', '{password}')");
            }
        }

        public void DeleteUser(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<UserModel>($"delete from Users where user_name='{ username }' and user_password='{ password }'");
            }
        }

        public DataTable SearchUser(string username)
        {
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Users where user_name like '{username}%'", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //The following methods configure data from the Guests table, and are used by the AddGuests.cs user control file.
        public bool checkGuestExists(string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<GuestModel>($"select * from Guests where email_address = '{email}'").ToList();
                if (output.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void RegisterGuest(string firstname, string lastname, long phonenumber, string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<GuestModel>($"insert into Guests values ('{firstname}', '{lastname}', {phonenumber}, '{email}')");
            }
        }

        public DataTable SearchGuests(string email)
        {
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Guests where email_address like '{email}%'", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void DeleteGuest(string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<UserModel>($"delete from Guests where email_address='{email}'");
            }
        }

        //The following methods configure data from the Rooms table, and are used by the AddRooms.cs user control file.
        public bool checkRoomExists(int room_number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<RoomModel>($"select * from Rooms where room_number = '{room_number}'").ToList();
                if (output.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void AddRoom(string room_type, int room_number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<RoomModel>($"insert into Rooms values ({Convert.ToInt32(room_number)}, '{room_type}')");
            }
        }
        public DataTable SearchRooms(string room_number)
        {
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Rooms where room_number like '{room_number}%'", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void DeleteRoom(int room_number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<UserModel>($"delete from Rooms where room_number={Convert.ToInt32(room_number)}");
            }
        }

        //The following methods configure data from the RoomType table, and are used by the AddRooms.cs user control file.
        public bool checkRoomTypeExists(string room_type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<RoomTypeModel>($"select * from RoomType where room_type = '{room_type}'").ToList();
                if (output.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void AddRoomType(string  room_type, decimal price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<RoomTypeModel>($"insert into RoomType values ('{room_type}', {price})");
            }
        }

        public DataTable updateRoomTypeList()
        {
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from RoomType order by price asc", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public List<RoomTypeModel> updateRoomTypeComboBox()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<RoomTypeModel>($"select * from RoomType order by price asc").ToList();
                return output;
            }
        }

        public void DeleteRoomType(string room_type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<RoomTypeModel>($"delete from RoomType where room_type = '{room_type}'");
            }
        }

        //The following methods configure data from the Reservations table, and are used by the AddReservations.cs user control file.

        public List<RoomModel> checkAvailableRooms(string check_in_date, string check_out_date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<RoomModel>($"select * from Rooms where room_number not in (select room_number from Reservations where '{check_in_date}' between check_in and check_out or '{check_out_date}' between check_in and check_out)").ToList();
                return output;
            }
        }

        public decimal GetPrice(string room_type)
        {
            decimal price = 0;
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            SqlCommand cmd = new SqlCommand($"select price from RoomType where room_type = '{room_type}'", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                price = rd.GetDecimal(rd.GetOrdinal("price"));
            }
            conn.Close();
            return price;
        }

        public void AddReservation(int room_number, string email, string check_in, string check_out, decimal price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<RoomTypeModel>($"insert into Reservations values ({room_number}, '{email}', '{check_in}', '{check_out}', {price})");
            }
        }

        public DataTable SearchReservation(string email)
        {
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Reservations where email_address like '{email}%' order by check_in asc", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void DeleteReservation(int reservation_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<RoomTypeModel>($"delete from Reservations where reservation_id = {reservation_id}");
            }
        }

        //The following methods are used to count the number of tuples in each database. They're primarily used in the Dashboard.cs user control file.

        public int CountGuests()
        {
            int count = 0;
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            SqlCommand cmd = new SqlCommand($"select count(*) from Guests", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                count = rd.GetInt32(0);
            }
            conn.Close();
            return count;
        }

        public int CountRooms()
        {
            int count = 0;
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            SqlCommand cmd = new SqlCommand($"select count(*) from Rooms", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                count = rd.GetInt32(0);
            }
            conn.Close();
            return count;
        }

        public int CountCurrentReservations()
        {
            int count = 0;
            DateTime today = DateTime.Today;
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            SqlCommand cmd = new SqlCommand($"select count(*) from Reservations where '{today.ToString("yyyy-MM-dd")}' between check_in and check_out", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                count = rd.GetInt32(0);
            }
            conn.Close();
            return count;
        }

        public int CountEmployees()
        {
            int count = 0;
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            SqlCommand cmd = new SqlCommand($"select count(*) from Users", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                count = rd.GetInt32(0);
            }
            conn.Close();
            return count;
        }

        //The following methods are used to configure data from the Amenities table. They're primarily used in the Dashboard.cs user control file.

        public void AddAmenity(string amenity_name, string description)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<AmenityModel>($"insert into Amenities values ('{amenity_name}', '{description}')");
            }
        }

        public List<AmenityModel> UpdateAmenityList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                var output = connection.Query<AmenityModel>($"select amenity_id, amenity_name from Amenities").ToList();
                return output;
            }
        }

        public void DeleteAmenity(int amenity_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<AmenityModel>($"delete from Amenities where amenity_id = {amenity_id}");
            }
        }

        public void EditAmenity(int amenity_id, string amenity_name, string description)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("connstring")))
            {
                connection.Query<AmenityModel>($"update Amenities set amenity_name = '{amenity_name}', description = '{description}' where amenity_id = {amenity_id}");
            }
        }

        public List<string> GetAmenityNameAndDesc(int amenity_id)
        {
            List<string> NameAndDesc = new List<string>();
            SqlConnection conn = new SqlConnection(Helper.CnnVal("connstring"));
            SqlCommand cmd = new SqlCommand($"select amenity_name, description from Amenities where amenity_id = {amenity_id}", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                NameAndDesc.Add(rd.GetString(0));
                NameAndDesc.Add(rd.GetString(1));
            }
            conn.Close();
            return NameAndDesc;
        }
    }
}
