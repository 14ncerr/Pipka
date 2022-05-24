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
        public AddNewEntityWindow _addNewEntityWindow = new AddNewEntityWindow();

        private RelayCommand _addNewEntityWindowCommand;
        public RelayCommand AddNewEntityWindowCommand
        {
            get
            {
                return _addNewEntityWindowCommand ?? new RelayCommand(obj =>
                {
                    _addNewEntityWindow.ShowDialog();
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
