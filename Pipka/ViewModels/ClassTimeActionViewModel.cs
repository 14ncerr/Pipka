using Pipka.Core;
using Pipka.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Pipka.ViewModels
{
    public class ClassTimeActionViewModel : ViewModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private RelayCommand _1stClassTime;
        public RelayCommand FirstClassTime
        {
            get
            {
                return _1stClassTime ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        StartTime = db.ClassTimes.FirstOrDefault(time => time.Id == 1).StartTime;
                        EndTime = db.ClassTimes.FirstOrDefault(time => time.Id == 1).EndTime;
                    }
                });
            }
        }

        private RelayCommand _2ndClassTime;
        public RelayCommand SecondClassTime
        {
            get
            {
                return _2ndClassTime ?? new RelayCommand(obj =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        StartTime = db.ClassTimes.FirstOrDefault(time => time.Id == 2).StartTime;
                        EndTime = db.ClassTimes.FirstOrDefault(time => time.Id == 2).EndTime;
                    }
                });
            }
        }
    }
}
