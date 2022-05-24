using Pipka.Core;
using Pipka.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.ViewModels
{
    public class AddNewEntityViewModel : ViewModel
    {

        public GroupActionView _groupActionView = new GroupActionView();
        public TeacherActionView _teacherActionView = new TeacherActionView();

        private RelayCommand _teacherctionViewCommand;
        public RelayCommand TeacherteacherActionViewCommand
        {
            get
            {
                return _teacherctionViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _teacherActionView;
                });
            }
        }

        private RelayCommand _groupActionViewCommand;
        public RelayCommand GroupActionViewCommand
        {
            get
            {
                return _groupActionViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _groupActionView;
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
