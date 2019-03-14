﻿using Remotely_Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Remotely_Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            if (MainWindowViewModel.Current?.ScreenCasterProcess?.HasExited == false)
            {
                MainWindowViewModel.Current.ScreenCasterProcess.Kill();
            }
        }
    }
}