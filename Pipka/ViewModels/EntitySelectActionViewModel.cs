using Pipka.Core;
using Pipka.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.ViewModels
{
    public class EntitySelectActionViewModel : ViewModel
    {

        public GroupActionView _groupActionView = new GroupActionView();
        public TeacherActionView _teacherActionView = new TeacherActionView();
        public ScheduleActionView _scheduleActionView = new ScheduleActionView();
        public DisciplineActionView _disciplineActionView { get; set; } = new DisciplineActionView();
        public ClassTimeActionView _classTimeActionView { get; set; } = new ClassTimeActionView();

        private RelayCommand _classTimeActionViewCommand;
        public RelayCommand ClassTimeActionViewCommand
        {
            get
            {
                return _classTimeActionViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _classTimeActionView;
                });
            }
        }

        private RelayCommand _disciplineActionViewCommand;
        public RelayCommand DisciplineActionViewCommand
        {
            get
            {
                return _disciplineActionViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _disciplineActionView;
                });
            }
        }

        private RelayCommand _scheduleActionViewCommand;
        public RelayCommand ScheduleActionViewCommand
        {
            get
            {
                return _scheduleActionViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _scheduleActionView;
                });
            }
        }

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
