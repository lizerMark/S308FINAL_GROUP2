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
    /// Interaction logic for CustomerDetails.xaml
    /// </summary>
    public partial class CustomerDetails : Window
    {
        public Quote CurrentQuote { get; set; }

        public CustomerDetails()
        {
            InitializeComponent();

            imgCardP4.Visibility = Visibility.Hidden;
            
        
        }

        public CustomerDetails(Quote curQuote)
        {
            InitializeComponent();

            CurrentQuote = curQuote;

            imgCardP4.Visibility = Visibility.Hidden;


        }

        public void DoSomething()
        {
            //fsdfds
        }


        //Set up Nav Bar
        private void btnMainMenuP4_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newMain = new MainMenu();
            newMain.Show();
            this.Close();
        }

        private void btnNewReservationP4_Click(object sender, RoutedEventArgs e)
        {
            NewReservation newRes = new NewReservation();
            newRes.Show();
            this.Close();
        }

        private void btnRoomManagementP4_Click(object sender, RoutedEventArgs e)
        {
            RoomManagement newRoomMgmt = new RoomManagement();
            newRoomMgmt.Show();
            this.Close();
        }

        private void btnReservationsReportP4_Click(object sender, RoutedEventArgs e)
        {
            ReservationsReport newResReport = new ReservationsReport();
            newResReport.Show();
            this.Close();
        }

        private void btnConfirmP4_Click(object sender, RoutedEventArgs e)
        {
            //Declare variables
            string strFirstNameP4 = txtFirstNameP4.Text.Trim();
            
            string strLastNameP4 = txtLastNameP4.Text.Trim();

            int intPhoneP4;

            string strEmailP4 = txtEmailP4.Text.Trim();

            string strCreditCardTypeP4 = cboCreditCard.SelectedIndex.ToString();

            string strCardNumberP4 = txtCardP4.Text.Trim();

            //Validation
            if (strFirstNameP4 == "")
            {
                MessageBox.Show("Please enter a First Name for the customer");
                return;
            }

            if (strLastNameP4 == "")
            {
                MessageBox.Show("Please enter a Last Name for the customer");
                return;
            }

            if (txtPhoneP4.Text == "")
            {
                MessageBox.Show("Please enter a Phone Number for the customer");
                return;
            }
            else if (!int.TryParse(txtPhoneP4.Text.Trim(),out intPhoneP4))
            {
                MessageBox.Show("Please enter numbers as the Phone Number");
                return;
            }


            string strPhoneP4 = txtPhoneP4.Text.Trim();
            if (strPhoneP4.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit Phone Number");
                return;
            }


            if (strEmailP4.Contains("@") == false)
            {
                MessageBox.Show("Please enter a valid Email address");
                return;
            }

            //Credit Card validation

            long lngOut;
            bool bolValid = false;
            int i;
            int intCheckDigit, intCheckSum = 0;
            string strCardType;

            txtCardP4.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            imgCardP4.Visibility = Visibility.Hidden;

            if(!Int64.TryParse(strCardNumberP4, out lngOut))
            {
                MessageBox.Show("Credit card numbers contain only numbers");
                txtCardP4.Background = new SolidColorBrush(Color.FromRgb(255, 200, 200));
                return;
            }

            if (strCardNumberP4.Length != 13 && strCardNumberP4.Length != 15 && strCardNumberP4.Length != 16)
            {
                MessageBox.Show("Credit card numbers must contain 13, 15, or 16 digits");
                return;
            }

            if (strCardNumberP4.StartsWith("34") || strCardNumberP4.StartsWith("37"))
                strCardType = "AMEX";
            else if (strCardNumberP4.StartsWith("6011"))
                strCardType = "Discover";
            else if (strCardNumberP4.StartsWith("51") || strCardNumberP4.StartsWith("53") || strCardNumberP4.StartsWith("54") || strCardNumberP4.StartsWith("555"))
                strCardType = "MasterCard";
            else if (strCardNumberP4.StartsWith("4"))
                strCardType = "Visa";
            else
                strCardType = "Unknown Card Type";

            strCardNumberP4 = ReverseString(strCardNumberP4);

            for (i = 0; i < strCardNumberP4.Length; i++)
            {
                intCheckDigit = Convert.ToInt32(strCardNumberP4.Substring(i, 1));

                if ((i+1)%2 == 0)
                {
                    intCheckDigit *= 2;
                    if (intCheckDigit>9)
                    {
                        intCheckDigit -= 9;
                    }
                }

                intCheckSum += intCheckDigit;
            }

            if (intCheckSum % 10 == 0)
            {
                bolValid = true;
            }

            if (bolValid)
            {
                switch (strCardType)
                {
                    case "AMEX":
                        imgCardP4.Source = new BitmapImage(new Uri(@"/Image/american_express_logo.png", UriKind.Relative));
                        imgCardP4.Width = 22;
                        imgCardP4.Height = 22;
                        break;
                    case "Discover":
                        imgCardP4.Source = new BitmapImage(new Uri(@"/Image/discover_logo.png", UriKind.Relative));
                        imgCardP4.Width = 32;
                        imgCardP4.Height = 22;
                        break;
                    case "MasterCard":
                        imgCardP4.Source = new BitmapImage(new Uri(@"/Image/mastercard_logo.png", UriKind.Relative));
                        imgCardP4.Width = 37;
                        imgCardP4.Height = 22;
                        break;
                    case "Visa":
                        imgCardP4.Source = new BitmapImage(new Uri(@"/Image/visa_logo.png", UriKind.Relative));
                        imgCardP4.Width = 35;
                        imgCardP4.Height = 22;
                        break;
                }

                imgCardP4.Visibility = Visibility.Visible;
                txtCardP4.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                MessageBox.Show("The credit card is a valid " + strCardType);
            }
            else
            {
                txtCardP4.Background = new SolidColorBrush(Color.FromRgb(255, 200, 200));
                MessageBox.Show("The credit card is not valid");
            }

          






 
            //Confirm button exports to the file and also clears the form
        }

        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
