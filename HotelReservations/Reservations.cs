using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    public class Reservations
    {
        public string Checkin_Date { get; set; }
        public string NumberofNights { get; set; }
        public string RoomType { get; set; }
        public string NumberofRooms { get; set; }
        public string RateperNight { get; set; }
        public string Subtotal { get; set; }
        public string Tax { get; set; }
        public string ConvenienceFee { get; set; }
        public string Total { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        //method

        public Reservations()
        {
        }

        public Reservations(string checkin_Date, string numberofNights, string roomType, string number)


    }
}
