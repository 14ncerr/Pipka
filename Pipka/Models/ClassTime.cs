using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.Models
{
    public class ClassTime
    {
        public int Id { get; set; }

        public int ClassPos { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [NotMapped]
        public string FullView => $"{ClassPos}) {StartTime.TimeOfDay} - {EndTime.TimeOfDay}";

        public List<Schedule> Schedules { get; set; }
    }
}
