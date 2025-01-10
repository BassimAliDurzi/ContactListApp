using System.Diagnostics;
using System.IO;
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
using Business.Models;

namespace ContactListMainApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            var contact = new Contact()
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                Email = Email.Text,
                PhoneNumber = PhoneNumber.Text,
                Street = Street.Text,
                PostalCode = PostalCode.Text,
                City = City.Text,
            };

            ContactsList.Items.Add(contact);
            FirstName.Clear();
            LastName.Clear();
            Email.Clear();
            PhoneNumber.Clear();
            Street.Clear();
            PostalCode.Clear();
            City.Clear();
        }
    }
}