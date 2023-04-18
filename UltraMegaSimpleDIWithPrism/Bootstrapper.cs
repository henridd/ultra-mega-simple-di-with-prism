using Prism.Ioc;
using Prism.Unity;
using System;
using System.Windows;

namespace UltraMegaSimpleDIWithPrism
{
    internal class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            var mainView = new MainView();

            Application.Current.MainWindow = mainView;
            mainView.Show();

            return mainView;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
