using Pipka.Core;
using Pipka.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.ViewModels
{
    public class StarterViewModel : ViewModel
    {
        public EntitySelectActionWindow _entitySelectActionWindow;

        private RelayCommand _entitySelectActionWindowCommand;
        public RelayCommand EntitySelectActionWindowCommand
        {
            get
            {
                return _entitySelectActionWindowCommand ?? new RelayCommand(obj =>
                {
                    _entitySelectActionWindow = new EntitySelectActionWindow();
                    _entitySelectActionWindow.ShowDialog();
                });
            }
        }




        public object _currentView { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
    }
}
