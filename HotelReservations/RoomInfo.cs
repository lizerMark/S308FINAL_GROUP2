using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    public class RoomInfo
    {
        public string RoomType { get; set; }
        public string Amount { get; set; }
        public string Rate { get; set; }

        //Method
        public RoomInfo()
        {
        }

        public RoomInfo(string roomType, string amount, string rate)
        {
            RoomType = roomType;
            Amount = amount;
            Rate = rate;
        }

   
    }
}
