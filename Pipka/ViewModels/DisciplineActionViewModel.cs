using Pipka.Core;
using Pipka.Views.DisciplineActionViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.ViewModels
{
    public class DisciplineActionViewModel : ViewModel
    {
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

        public AddNewDisciplineView _addNewDisciplineView = new AddNewDisciplineView();

        private RelayCommand _addNewViewCommand;
        public RelayCommand AddNewViewCommand
        {
            get
            {
                return _addNewViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _addNewDisciplineView;
                });
            }
        }


        public DeleteDisciplineView _deleteDisciplineView = new DeleteDisciplineView();

        private RelayCommand _deleteViewCommand;
        public RelayCommand DeleteViewCommand
        {
            get
            {
                return _deleteViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _deleteDisciplineView;
                });
            }
        }

    }
}
