using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public virtual Discipline Discipline { get; set; }
        public int DisciplineId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public virtual Group Group { get; set; }
        public int GroupId { get; set; }

        public virtual ClassTime ClassTime { get; set; }
        public int ClassTimeId { get; set; }
    }
}
