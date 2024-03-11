using ChangeTheme.Models;
using R3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTheme.ViewModels
{
    public class MainWindowViewModel:ViewModelBase
    {
        public ThemeConfig Config { get; }
        public MainWindowViewModel(ThemeConfig config) : base()
        {
            this.Config = config;
            this.ThemeBoxViewModel = new ThemeBoxViewModel(config);
        }
        public ThemeBoxViewModel ThemeBoxViewModel { get; }
    }
}
