using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class ReservationModel
    {
        public int reservation_id { get; set; }
        public int room_number { get; set; }
        public string email_address { get; set; }
        public string check_in { get; set; }
        public string check_out { get; set; }
        public int price { get; set; }
    }
}
