using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
   
        public partial class EmployeePage : Page
        {
            Employee contextEmployee;
            public EmployeePage(Employee employee)
            {
                InitializeComponent();
                
                contextEmployee = employee;
                DataContext = contextEmployee;
            }

            private void BSave_Click(object sender, RoutedEventArgs e)
            {
                string error = "";

                if (contextEmployee.id == 0)
                    App.DB.Employee.Add(contextEmployee);
                App.DB.SaveChanges();
                NavigationService.GoBack();
            }

            private void BCancel_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.GoBack();
            }

            

            private void FullName_PreviewTextInput(object sender, TextCompositionEventArgs e)
            {
                if (Regex.IsMatch(e.Text, @"[A-zА-я]") == false)
                {
                    e.Handled = true;
                }
            }

            private void Digits_PreviewTextInput(object sender, TextCompositionEventArgs e)
            {
                if (Regex.IsMatch(e.Text, @"[0-9]") == false)
                {
                    e.Handled = true;
                }
            }

            private void BEditImage_Click(object sender, RoutedEventArgs e)
            {
                 var dialog = new OpenFileDialog();
                 if (dialog.ShowDialog().GetValueOrDefault())
                 {
                    contextEmployee.Image = File.ReadAllBytes(dialog.FileName);
                    DataContext = null;
                    DataContext = contextEmployee;
                 }
            }

        }
    }
