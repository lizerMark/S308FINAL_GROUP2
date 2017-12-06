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
using System.IO;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace HotelReservations
{
    /// <summary>
    /// Interaction logic for NewReservation.xaml
    /// </summary>
    public partial class NewReservation : Window
    {
        List<RoomInfo> RoomInfoList;

        public NewReservation()
        {
            InitializeComponent();

            RoomInfoList = new List<HotelReservations.RoomInfo>();

        }


        
        //Set up Nav bar

 

        private void btnMainMenuP2_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newMain = new MainMenu();
            newMain.Show();
            this.Close();
        }

        private void btnNewReservationP2_Click(object sender, RoutedEventArgs e)
        {
            NewReservation newRes = new NewReservation();
            newRes.Show();
            this.Close();
        }

        private void btnRoomManagementP2_Click(object sender, RoutedEventArgs e)
        {
            RoomManagement newRoomMgmt = new RoomManagement();
            newRoomMgmt.Show();
            this.Close();
        }

        private void btnReservationsReportP2_Click(object sender, RoutedEventArgs e)
        {
            ReservationsReport newResReport = new ReservationsReport();
            newResReport.Show();
            this.Close();
        }

        private void btnGetQuoteP2_Click(object sender, RoutedEventArgs e)
        {

            //Declare variables

            string strRoomTypeP2 = cboRoomTypeP2.SelectedIndex.ToString();

            string strCheckInDateP2 = dateCheckInP2.ToString();

            string strCheckOutDateP2 = dateCheckOutP2.ToString();

            string strNumberOfRoomsP2 = sldRoomNumberP2.ToString();

            

   

            //Validate the input
           
            if (strRoomTypeP2 == "-1")
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            if (dateCheckInP2.SelectedDate < DateTime.Today)
            {
                MessageBox.Show("Please select a check-in date that is not in the past");
                return;
            }

            if (dateCheckOutP2.SelectedDate < dateCheckInP2.SelectedDate)
            {
                MessageBox.Show("Please select a check-out date later than the check-in date");
                return;
            }


            //Import room data

            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            OpenFileDialog.Filter = "JSON Files | *.json";

            if(OpenFileDialog.ShowDialog() == true)
            {

                string strFilePath = OpenFileDialog.FileName;

                try
                {
                    StreamReader reader = new StreamReader(strFilePath);
                    string jsonData = reader.ReadToEnd();
                    reader.Close();

                    RoomInfoList = JsonConvert.DeserializeObject<List<RoomInfo>>(jsonData);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error in import process: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You did not select a Room Info file to open");
            }


            //display report (with calculations)

            string strNumberOfNights = Convert.ToString(dateCheckOutP2.SelectedDate - dateCheckInP2.SelectedDate);
            





            Quote quoteNew = new Quote()


        }

        private void btnProceedQuoteP2_Click(object sender, RoutedEventArgs e)
        {
            CustomerDetails custDetails = new HotelReservations.CustomerDetails(new Quote());

            //custDetails.CurrentQuote = new HotelReservations.Quote();
            //custDetails.DoSomething();

            custDetails.Show();
            this.Hide();
        }







        //Proceed with quote should export to JSON (??????)

        //Link Proceed with Quote to Customer Details




    }

}
