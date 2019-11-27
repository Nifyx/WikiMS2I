using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WikiMS2I.Models.Wiki
{
    public class Content
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime Date_Updated { get; set; }
    }
}
