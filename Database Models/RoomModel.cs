using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class RoomModel
    {
        public int room_number { get; set; }
        public string room_type { get; set; }
        public string FullInfo
        {
            get
            {
                return $"#{room_number}: {room_type}";
            }
        }
    }
}
