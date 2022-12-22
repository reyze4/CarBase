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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CarBase.Model;

namespace CarBase.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
            DGClients.ItemsSource = App.DB.Client.ToList();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedClients = DGClients.SelectedItem as Client;
            if (selectedClients == null)
            {
                MessageBox.Show("Выберите машину");
                return;
            }
            NavigationService.Navigate(new ClientPage(selectedClients));
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }



        private void BAddT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientPage(new Client()));
        }

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
