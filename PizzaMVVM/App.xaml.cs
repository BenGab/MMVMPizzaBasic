using GalaSoft.MvvmLight.Ioc;
using PizzaMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PizzaMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public MainViewModel MainVM
        {
            get
            {
               return new MainViewModel();
            }
        }
    }

}
