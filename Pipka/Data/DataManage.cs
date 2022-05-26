using Pipka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.Data
{
    public static class DataManage
    {
        private static List<Group> _allGroups = new List<Group>();

        public static List<Group> AllGroups
        {
            get { return _allGroups; }
            set
            {
                _allGroups = value;
            }
        }

        private static List<Teacher> _allTeachers = new List<Teacher>();

        public static List<Teacher> AllTeachers
        {
            get { return _allTeachers; }
            set
            {
                _allTeachers = value;
            }
        }
    }
}
