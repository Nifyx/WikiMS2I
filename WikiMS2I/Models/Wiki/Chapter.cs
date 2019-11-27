using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WikiMS2I.Models.Wiki
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Content> ContentsList { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime Date_Updated { get; set; }
    }
}
