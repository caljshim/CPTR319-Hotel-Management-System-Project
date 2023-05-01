using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class RoomTypeModel
    {
        public string room_type { get; set; }
        public decimal price { get; set; }
        public string RoomTypeInfo
        {
            get
            {
                return $"{room_type}: {price.ToString("C")}";
            }
        }
    }
}
