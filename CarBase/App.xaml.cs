using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CarBase.Model;

namespace CarBase
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static BaseAutoEntities1 DB = new BaseAutoEntities1();
        public static Employee LoggedEmployee;

    }
}
