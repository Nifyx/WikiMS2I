using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WikiMS2I.Models.Wiki
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public List<Chapter> ChaptersList { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime Date_Updated { get; set; }
    }
}
