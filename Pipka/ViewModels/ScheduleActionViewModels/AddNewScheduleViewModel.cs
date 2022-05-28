using Pipka.Data;
using Pipka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void SetNullToProperties()
        {
            SelectedDate = DateTime.Now;
            SelectedClassTime = null;
            SelectedGroup  = null;
            SelectedTeacherAndDiscipline = null;
        }
    }
}
