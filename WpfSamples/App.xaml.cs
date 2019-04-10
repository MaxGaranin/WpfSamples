﻿using System.Windows;
using GalaSoft.MvvmLight.Threading;
using Telerik.Windows.Controls;
using WpfSamples.View;
using WpfSamples.View.Async.TaskWithDialog;
using WpfSamples.View.Draw;
using WpfSamples.ViewModel;
using WpfSamples.WpfInfrastructure.Utils;

namespace WpfSamples
{
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }

        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            Init();

            var viewModel = new TestViewModel();
            var view = new TestView {DataContext = viewModel};
            view.Show();
        }

        private void Init()
        {
            StyleManager.ApplicationTheme = new Windows8Theme();

            // Применяет культуру системы к WPF
            LocalePatch.Init();
        }
    }
}