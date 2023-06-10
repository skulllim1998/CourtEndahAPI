using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourtEndahAPI_v1.DomainClasses
{
    public class COURT_T
    {
        public int court_id { get; set; }
        public string court_type { get; set; }
        public int court_active { get; set; }
    }
}
