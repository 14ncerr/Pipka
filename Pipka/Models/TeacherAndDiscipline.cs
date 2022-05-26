using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.Models
{
    public class TeacherAndDiscipline
    {
        public int Id { get; set; }

        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public Discipline Discipline { get; set; }
        public int DisciplineId { get; set; }

        public List<Schedule> Schedules { get; set; }
    }
}
