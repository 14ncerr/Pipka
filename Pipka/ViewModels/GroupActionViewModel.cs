using Microsoft.EntityFrameworkCore;
using Pipka.Core;
using Pipka.Data;
using Pipka.Models;
using Pipka.Views.GroupActionViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pipka.ViewModels
{
    public class GroupActionViewModel : ViewModel
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

        public AddNewGroupView _addNewGroupView = new AddNewGroupView();

        private RelayCommand _addNewViewCommand;
        public RelayCommand AddNewViewCommand
        {
            get
            {
                return _addNewViewCommand ?? new RelayCommand(obj =>
                {
                    CurrentView = _addNewGroupView;
                });
            }
        }
       

        public DeleteGroupView _deleteGroupView = new DeleteGroupView();

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
        }




    }
}
