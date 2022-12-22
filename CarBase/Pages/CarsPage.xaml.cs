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
    /// Логика взаимодействия для CarsPage.xaml
    /// </summary>
    public partial class CarsPage : Page
    {
        public CarsPage()
        {
            InitializeComponent();
            LVCars.ItemsSource = App.DB.Car.ToList();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedCars = LVCars.SelectedItem as Car;
            if (selectedCars == null)
            {
                MessageBox.Show("Выберите машину");
                return;
            }
            NavigationService.Navigate(new CarPage(selectedCars));
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        

        private void BAddT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CarPage(new Car()));
        }
    }
}
