using DemoLibrary;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IsaveAddress
    {
        BindingList<AddressMOdel> addresses = new BindingList<AddressMOdel>();
        public MainWindow()
        {
            InitializeComponent();

            addressList.ItemsSource = addresses;

           
        }

        public void SaveAddress(AddressMOdel address)
        {
            addresses.Add(address);
        }

        private void addAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        private void saveperson_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                firstname = firstNameText.Text,
                lastName = LASTNameText.Text,
                IsActive = (activeCheckBox.IsChecked ?? false),
                addresses = addresses.ToList(),

            };

            this.Close();
        }

        private void activeCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}