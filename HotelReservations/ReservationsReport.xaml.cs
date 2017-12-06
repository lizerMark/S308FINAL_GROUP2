using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelReservations
{
    /// <summary>
    /// Interaction logic for ReservationsReport.xaml
    /// </summary>
    public partial class ReservationsReport : Window
    {
        public ReservationsReport()
        {
            InitializeComponent();

            //Declare variables
            string strDateCheckInP5 = dateCheckInP5.ToString();
            string strDateCheckOutP5 = dateCheckOutP5.ToString();
            string strLastNameP5 = txtLastNameP5.Text.Trim();
            string strRoomTypeP5 = cboRoomTypeP5.SelectedIndex.ToString();
        //Create Nav bar

            //Validate filters

            //"Submit" button
            //1) Import all reservation data
            //2) Apply filters (date range, last name, or both)
            //3) Display filtered results

        }
    }
}
