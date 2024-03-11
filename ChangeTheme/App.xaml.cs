using ChangeTheme.Models;
using ChangeTheme.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ChangeTheme
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            this.Config = ThemeConfig.Load();
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            var mainWindow = new Views.MainWindow();
            mainWindow.DataContext = new MainWindowViewModel(this.Config);
            mainWindow.Closing += MainWindow_Closing;
            this.MainWindow = mainWindow;
            mainWindow.Show();
        }
        public ThemeConfig Config { get; private set; }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Config.Save();
        }
    }

}
