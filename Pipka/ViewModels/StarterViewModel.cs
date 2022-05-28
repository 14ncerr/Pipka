using Microsoft.EntityFrameworkCore;
using Pipka.Core;
using Pipka.Data;
using Pipka.Models;
using Pipka.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pipka.ViewModels
{
    public class StarterViewModel : ViewModel
    {
        public Schedule SelectedItem { get; set; }
        public DateTime SelectedDate { get; set; }
        public Group SelectedGroup { get; set; }



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

        private RelayCommand _deleteFilters;
        public RelayCommand DeleteFilters
        {
            get
            {
                return _deleteFilters ?? new RelayCommand(obj =>
                {
                    ((ListView)obj).ItemsSource = AllSchedules;
                    ((ListView)obj).Items.Refresh();
                });
            }
        }

        private RelayCommand _applyFilters;
        public RelayCommand ApplyFilters
        {
            get
            {
                return _applyFilters ?? new RelayCommand(obj =>
                {
                    try
                    { 
                    AllChosenSchedules = AllSchedules.FindAll(s => s.Date == SelectedDate).FindAll(s => s.Group == SelectedGroup);
                    ((ListView)obj).ItemsSource = AllChosenSchedules;
                    ((ListView)obj).Items.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка, значения не выбраны" + ex.ToString());
                    }
                });
            }
        }

        #region Lists

        private List<Group> _allGroups = new List<Group>();
        public List<Group> AllGroups
        {
            get { return _allGroups; }
            set
            {
                _allGroups = value;
            }
        }

        private List<Schedule> _allChosenSchedules = new List<Schedule>();
        public List<Schedule> AllChosenSchedules
        {
            get { return _allChosenSchedules; }
            set
            {
                _allChosenSchedules = value;
            }
        }

        private List<Schedule> _allSchedules = new List<Schedule>();
        public List<Schedule> AllSchedules
        {
            get { return _allSchedules; }
            set
            {
                _allSchedules = value;
            }
        }

        private List<TeacherAndDiscipline> _allTeacherAndDisciplines = new List<TeacherAndDiscipline>();
        public List<TeacherAndDiscipline> AllTeacherAndDisciplines
        {
            get { return _allTeacherAndDisciplines; }
            set
            {
                _allTeacherAndDisciplines = value;
            }
        }

        #endregion

        public StarterViewModel()
        {
            using (ApplicationContext ac = new())
            {
                AllSchedules = ac.Schedules.Include(s => s.Group)
                    .Include(s => s.ClassTime)
                    .Include(s => s.TeacherAndDiscipline)
                    .ToList();

                AllTeacherAndDisciplines = ac.TeacherAndDisciplines.Include(tAD => tAD.Teacher)
                    .Include(tAD => tAD.Discipline).ToList();

                AllGroups = ac.Groups.ToList();
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
