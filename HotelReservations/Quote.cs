using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    public class Quote
    {
        public string NumberofNights { get; set; }
        public string RateperNight { get; set; }
        public string Subtotal { get; set; }
        public string Tax { get; set; }
        public string ConvenienceFee { get; set; }
        public string Total { get; set; }

        //Method

        public Quote()
        {
        }

        public Quote(string numberofNights, string rateperNight, string subtotal, string tax, string convenienceFee, string total)
        {
            NumberofNights = numberofNights;
            RateperNight = rateperNight;
            Subtotal = subtotal;
            Tax = tax;
            ConvenienceFee = convenienceFee;
            Total = total;
        }

        //override tostring for datagrid

        public override string ToString()
        {
            string strOutput = "";

            strOutput += "Number of Nights" + Environment.NewLine;
            strOutput += "Rate per Night" + Environment.NewLine;
            strOutput += "Subtotal" + Environment.NewLine;
            strOutput += "Tax" + Environment.NewLine;
            strOutput += "Convenience Fee" + Environment.NewLine;
            strOutput += "Total" + Environment.NewLine;

            return strOutput;
        }

    }
}
