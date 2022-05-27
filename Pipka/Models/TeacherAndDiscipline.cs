using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string TeacherFIOAndDiscipline => $"{Teacher.LastName} {Teacher.FirstName[0].ToString().ToUpper()}. {Teacher.MiddleName[0].ToString().ToUpper()}. : {Discipline.Name}";

        public List<Schedule> Schedules { get; set; }
    }
}
