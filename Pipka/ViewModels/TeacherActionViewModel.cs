using Microsoft.EntityFrameworkCore;
using Pipka.Core;
using Pipka.Data;
using Pipka.Models;
using Pipka.Views.TeacherActionViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pipka.ViewModels
{
    public class TeacherActionViewModel : ViewModel
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

        public AddNewTeacherView _addNewTeacherView = new AddNewTeacherView();

        private RelayCommand _addNewViewCommand;
        public RelayCommand AddNewViewCommand
        {
            get
            {
                return _addNewViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _addNewTeacherView;
                });
            }
        }

        public EditTeacherView _editTeacherView = new EditTeacherView();

        private RelayCommand _editTeacherViewCommand;
        public RelayCommand EditTeacherViewCommand
        {
            get
            {
                return _editTeacherViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _editTeacherView;
                });
            }
        }


        public DeleteTeacherView _deleteTeacherView = new DeleteTeacherView();

        private RelayCommand _deleteTeacherViewCommand;
        public RelayCommand DeleteTeacherViewCommand
        {
            get
            {
                return _deleteTeacherViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _deleteTeacherView;
                });
            }
        }

    

    }
}
