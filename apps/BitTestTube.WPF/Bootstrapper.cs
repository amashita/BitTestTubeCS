using Microsoft.Practices.Unity;
using Prism.Unity;
using BitTestTube.WPF.Views;
using System.Windows;

namespace BitTestTube.WPF
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
