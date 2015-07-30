using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WX.WFA.Main
{
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            if (e.Exception is InvalidOperationException)
                e.Handled = true;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        protected override void OnStartup(StartupEventArgs e)
        {
            var v = new WX.WFA.MainFrame.W_Login();
            var vm = new WX.WFA.MainFrame.VM_Login();
            v.DataContext = vm;
            vm.BindedWindow = v;
            v.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            v.Show();
            /*
            var v = new WX.WFA.MainFrame.W_MainFrame();
            var vm = new WX.WFA.MainFrame.VM_MainFrame();
            v.DataContext = vm;
            v.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            v.WindowState = WindowState.Maximized;
            v.Show();
            */
            base.OnStartup(e);

        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

        }
    }
}
