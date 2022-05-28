using Pipka.Core;
using Pipka.Views.ScheduleActionViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.ViewModels
{
    public class ScheduleActionViewModel : ViewModel
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

        public AddNewScheduleView _addNewScheduleView = new AddNewScheduleView();

        private RelayCommand _addNewViewCommand;
        public RelayCommand AddNewViewCommand
        {
            get
            {
                return _addNewViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _addNewScheduleView;
                });
            }
        }


     /*   public DeleteGroupView _deleteGroupView = new DeleteGroupView();

        private RelayCommand _deleteViewCommand;
        public RelayCommand DeleteViewCommand
        {
            get
            {
                return _deleteViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _deleteGroupView;
                });
            }
        }*/
    }
}
