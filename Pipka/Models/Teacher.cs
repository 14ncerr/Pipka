using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [NotMapped]
        public string FullName => $"{LastName} {FirstName} {MiddleName}";

        public List<TeacherAndDiscipline> TeacherAndDisciplines { get; set; }
    }
}
