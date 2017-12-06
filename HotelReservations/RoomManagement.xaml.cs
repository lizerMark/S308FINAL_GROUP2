using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        List<Customers> customerList;
    
    public RoomManagement()
    {
        InitializeComponent();
        customerList = new List<Customers>();
        dtgCustomers.ItemsSource = customerList;

        //Declare Variables
        int intAdminRoomNumberKingP3 = Convert.ToInt32(txtRoomNumberKingP3.Text.Trim());
        int intAdminRoomNumberKingDeluxeP3 = Convert.ToInt32(txtRoomNumberKingDeluxeP3.Text.Trim());
        int intAdminRoomNumberQueenP3 = Convert.ToInt32(txtRoomNumberQueensP3.Text.Trim());
        int intAdminRoomNumberQueenDeluxeP3 = Convert.ToInt32(txtRoomNumberQueensDeluxeP3.Text.Trim());
        int intAdminRoomNumberKingSuiteP3 = Convert.ToInt32(txtRoomNumberKingSuiteP3.Text.Trim());
        int intAdminRoomNumberPresidentialP3 = Convert.ToInt32(txtRoomNumberPresidentialP3.Text.Trim());
        int intInputRoomNumberKingP3 = Convert.ToInt32(txtRoomNumberKing1P3.Text.Trim());
        int intInputRoomNumberKingDeluxeP3 = Convert.ToInt32(txtRoomNumberKingDeluxe1P3.Text.Trim());
        int intInputRoomNumberQueenP3 = Convert.ToInt32(txtRoomNumberQueens1P3.Text.Trim());
        int intInputRoomNumberQueenDeluxeP3 = Convert.ToInt32(txtRoomNumberQueensDeluxe1P3.Text.Trim());
        int intInputRoomNumberKingSuiteP3 = Convert.ToInt32(txtRoomNumberKingSuite1P3.Text.Trim());
        int intInputRoomNumberPresidentialP3 = Convert.ToInt32(txtRoomNumberPresidential1P3.Text.Trim());

        string strAdminRoomNumberKingP3 = Convert.ToString(txtRoomNumberKingP3.Text.Trim());
        string strAdminRoomNumberKingDeluxeP3 = Convert.ToString(txtRoomNumberKingDeluxeP3.Text.Trim());
        string strAdminRoomNumberQueenP3 = Convert.ToString(txtRoomNumberQueensP3.Text.Trim());
        string strAdminRoomNumberQueenDeluxeP3 = Convert.ToString(txtRoomNumberQueensDeluxeP3.Text.Trim());
        string strAdminRoomNumberKingSuiteP3 = Convert.ToString(txtRoomNumberKingSuiteP3.Text.Trim());
        string strAdminRoomNumberPresidentialP3 = Convert.ToString(txtRoomNumberPresidentialP3.Text.Trim());
        string strInputRoomNumberKingP3 = Convert.ToString(txtRoomNumberKing1P3.Text.Trim());
        string strInputRoomNumberKingDeluxeP3 = Convert.ToString(txtRoomNumberKingDeluxe1P3.Text.Trim());
        string strInputRoomNumberQueenP3 = Convert.ToString(txtRoomNumberQueens1P3.Text.Trim());
        string strInputRoomNumberQueenDeluxeP3 = Convert.ToString(txtRoomNumberQueensDeluxe1P3.Text.Trim());
        string strInputRoomNumberKingSuiteP3 = Convert.ToString(txtRoomNumberKingSuite1P3.Text.Trim());
        string strInputRoomNumberPresidentialP3 = Convert.ToString(txtRoomNumberPresidential1P3.Text.Trim());

        double dblAdminPriceKingP3 = Convert.ToDouble(txtPriceKingP3.Text.Trim());
        double dblAdminPriceKingDeluxeP3 = Convert.ToDouble(txtPriceKingDeluxeP3.Text.Trim());
        double dblAdminPriceQueenP3 = Convert.ToDouble(txtPriceQueensP3.Text.Trim());
        double dblAdminPriceQueenDeluxeP3 = Convert.ToDouble(txtPriceQueenDeluxeP3.Text.Trim());
        double dblAdminPriceKingSuiteP3 = Convert.ToDouble(txtPriceKingSuiteP3.Text.Trim());
        double dblAdminPricePresidentialP3 = Convert.ToDouble(txtPricePresidentialP3.Text.Trim());
        double dblInputPriceKingP3 = Convert.ToDouble(txtPriceKing1P3.Text.Trim());
        double dblInputPriceKingDeluxeP3 = Convert.ToDouble(txtPriceKingDeluxe1P3.Text.Trim());
        double dblInputPriceQueenP3 = Convert.ToDouble(txtPriceQueens1P3.Text.Trim());
        double dblInputPriceQueenDeluxeP3 = Convert.ToDouble(txtPriceQueenDeluxe1P3.Text.Trim());
        double dblInputPriceKingSuiteP3 = Convert.ToDouble(txtPriceKingSuite1P3.Text.Trim());
        double dblInputPricePresidentialP3 = Convert.ToDouble(txtPricePresidential1P3.Text.Trim());

        string strAdminPriceKingP3 = Convert.ToString(txtPriceKingP3.Text.Trim());
        string strAdminPriceKingDeluxeP3 = Convert.ToString(txtPriceKingDeluxeP3.Text.Trim());
        string strAdminPriceQueenP3 = Convert.ToString(txtPriceQueensP3.Text.Trim());
        string strAdminPriceQueenDeluxeP3 = Convert.ToString(txtPriceQueenDeluxeP3.Text.Trim());
        string strAdminPriceKingSuiteP3 = Convert.ToString(txtPriceKingSuiteP3.Text.Trim());
        string strAdminPricePresidentialP3 = Convert.ToString(txtPricePresidentialP3.Text.Trim());
        string strInputPriceKingP3 = Convert.ToString(txtPriceKing1P3.Text.Trim());
        string strInputPriceKingDeluxeP3 = Convert.ToString(txtPriceKingDeluxe1P3.Text.Trim());
        string strInputPriceQueenP3 = Convert.ToString(txtPriceQueens1P3.Text.Trim());
        string strInputPriceQueenDeluxeP3 = Convert.ToString(txtPriceQueenDeluxe1P3.Text.Trim());
        string strInputPriceKingSuiteP3 = Convert.ToString(txtPriceKingSuite1P3.Text.Trim());
        string strInputPricePresidentialP3 = Convert.ToString(txtPricePresidential1P3.Text.Trim());

        //Validate input (fields are not required but are either intergers or doubles)

        if (!Int32.TryParse(strInputRoomNumberKingP3, out intInputRoomNumberKingP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strInputRoomNumberKingDeluxeP3, out intInputRoomNumberKingDeluxeP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strInputRoomNumberQueenP3, out intInputRoomNumberQueenP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strInputRoomNumberQueenDeluxeP3, out intInputRoomNumberQueenDeluxeP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strInputRoomNumberKingSuiteP3, out intInputRoomNumberKingSuiteP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strInputRoomNumberPresidentialP3, out intInputRoomNumberPresidentialP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }

        if (!Int32.TryParse(strAdminRoomNumberKingP3, out intAdminRoomNumberKingP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strAdminRoomNumberKingDeluxeP3, out intAdminRoomNumberKingDeluxeP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strAdminRoomNumberQueenP3, out intAdminRoomNumberQueenP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strAdminRoomNumberQueenDeluxeP3, out intAdminRoomNumberQueenDeluxeP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strAdminRoomNumberKingSuiteP3, out intAdminRoomNumberKingSuiteP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }
        if (!Int32.TryParse(strAdminRoomNumberPresidentialP3, out intAdminRoomNumberPresidentialP3))
        {
            MessageBox.Show("Please enter a valid number of rooms.");
        }


        if (!Double.TryParse(strInputPriceKingP3, out dblInputPriceKingP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strInputPriceKingDeluxeP3, out dblInputPriceKingDeluxeP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strInputPriceQueenP3, out dblInputPriceQueenP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strInputPriceQueenDeluxeP3, out dblInputPriceQueenDeluxeP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strInputPriceKingSuiteP3, out dblInputPriceKingSuiteP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strInputPricePresidentialP3, out dblInputPricePresidentialP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strAdminPriceKingP3, out dblAdminPriceKingP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strAdminPriceKingDeluxeP3, out dblAdminPriceKingDeluxeP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strAdminPriceQueenP3, out dblAdminPriceQueenP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strAdminPriceQueenDeluxeP3, out dblAdminPriceQueenDeluxeP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strAdminPriceKingSuiteP3, out dblAdminPriceKingSuiteP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }
        if (!Double.TryParse(strAdminPricePresidentialP3, out dblAdminPricePresidentialP3))
        {
            MessageBox.Show("Please enter a valid price.");
        }


            //Set up nav bar
    private void btnMainMenuP3_Click(object sender, RoutedEventArgs e)
    {
        MainMenu newMain = new MainMenu();
        newMain.Show();
        this.Close();
    }

    private void btnNewReservationP3_Click(object sender, RoutedEventArgs e)
    {
        NewReservation newRes = new NewReservation();
        newRes.Show();
        this.Close();
    }

    private void btnRoomManagementP3_Click(object sender, RoutedEventArgs e)
    {
        RoomManagement newRoomMgmt = new RoomManagement();
        newRoomMgmt.Show();
        this.Close();
    }

    private void btnReservationsReportP3_Click(object sender, RoutedEventArgs e)
    {
        ReservationsReport newResReport = new ReservationsReport();
        newResReport.Show();
        this.Close();
    }



            //Import from text file to left-hand text boxes upon opening

            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Filter = "JSON File | *.json";

                if (openFileDialog.ShowDialog() == true)
                {
                    string strFilePath = openFileDialog.FileName;

                    try
                    {
                        StreamReader reader = new StreamReader(strFilePath);
    string jsonData = reader.ReadToEnd();
    reader.Close();

                        customerList = JsonConvert.DeserializeObject<List<Customers>>(jsonData);
                        dtgCustomers.ItemsSource = customerList;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Error in import process" + Ex.Message);
                    }
                    dtgCustomers.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("You did not select a file to open.");
                }

            }

        //Submit change button is reflected by left-hand text box changing and export

    private void btnSubmit_Click(object sender, RoutedEventArgs e)
{
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "JSON Files | *.json";


        if (saveFileDialog.ShowDialog() == true)
        {
            string strFilePath = saveFileDialog.FileName;

            try
            {
                StreamWriter writer = new StreamWriter(strFilePath, false);
                string jsonData = JsonConvert.SerializeObject(customerList);
                writer.Write(jsonData);
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in export process: " + ex.Message);
            }

            MessageBox.Show("Export completed!" + Environment.NewLine + "File Created: " + strFilePath);
        }
        else
        {
            MessageBox.Show("You did not provide a file to save to");
        }
    }
}
//set file path to properly store data
private string GetFilePath(string extension, bool withTimestamp)
{

    string strFilePath = @"..\..\..\Data\Customers_Test";
    string strTimeStamp = DateTime.Now.Ticks.ToString();

    if (withTimestamp)
    {
        strFilePath += "_" + strTimeStamp;
    }

    strFilePath += "." + extension;

    return strFilePath;

}
}



