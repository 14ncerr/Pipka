using Pipka.Core;
using Pipka.Data;
using Pipka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pipka.ViewModels.ScheduleActionViewModels
{
    public class AddNewScheduleViewModel
    {
        public DateTime SelectedDate { get; set; }
        public TeacherAndDiscipline SelectedTeacherAndDiscipline { get; set; }
        public ClassTime SelectedClassTime { get; set; }
        public Group SelectedGroup { get; set; }


        public AddNewScheduleViewModel()
        {
            AllTeacherAndDisciplines = DataManage.AllTeacherAndDisciplines;
            AllGroups = DataManage.AllGroups;
            AllClassTimes = DataManage.AllClassTimes;
        }


        public RelayCommand _addNewCommand;

        public RelayCommand AddNewScheduleCommand 
        { 
            get
            {
                return _addNewCommand ?? new RelayCommand(obj =>
                {
                using (ApplicationContext ac = new ApplicationContext())
                {
                        try
                        {
                            Schedule schedule = new Schedule()
                            {
                                GroupId = SelectedGroup.Id,
                                TeacherAndDisciplineId = SelectedTeacherAndDiscipline.Id,
                                ClassTimeId = SelectedClassTime.Id,
                                Date = SelectedDate
                            };


                            ac.Schedules.Add(schedule);
                            schedule.TeacherAndDiscipline = SelectedTeacherAndDiscipline;
                            schedule.ClassTime = SelectedClassTime;
                            schedule.Group = SelectedGroup;
                            DataManage.AllSchedules.Add(schedule);
                            ac.SaveChanges();
                            MessageBox.Show($"Запись {schedule.Date.Day} " + $"{schedule.Date.Month} {schedule.Date.Year} " +
                                $"{schedule.TeacherAndDiscipline.TeacherFIOAndDiscipline} " +
                                $"{schedule.Group.Name} " +
                                $"{schedule.ClassTime.FullView} добавлена" );
                            SetNullToProperties();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            SetNullToProperties();
                        }
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

        private List<TeacherAndDiscipline> _allTeacherAndDisciplines = new List<TeacherAndDiscipline>();
        public List<TeacherAndDiscipline> AllTeacherAndDisciplines
        {
            get { return _allTeacherAndDisciplines; }
            set
            {
                _allTeacherAndDisciplines = value;
            }
        }

        private List<ClassTime> _allClassTimes = new List<ClassTime>();
        public List<ClassTime> AllClassTimes
        {
            get { return _allClassTimes; }
            set
            {
                _allClassTimes = value;
            }
        }

        #endregion

        private void SetNullToProperties()
        {
            SelectedDate = DateTime.Now;
            SelectedClassTime = null;
            SelectedGroup  = null;
            SelectedTeacherAndDiscipline = null;
        }
    }
}
