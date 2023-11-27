using DemoLibrary;
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

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        IsaveAddress _parent;
        public AddressEntry(IsaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void SaveAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressMOdel address = new AddressMOdel
            {
                StreetAddress = streetAddressText.Text,
                City = CityText.Text,
                State = StateText.Text,
                ZipCode = ZipCodeText.Text,

            };

            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
