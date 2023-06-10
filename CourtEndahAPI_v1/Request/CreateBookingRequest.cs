using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourtEndahAPI_v1.DomainClasses;

namespace CourtEndahAPI_v1.Request
{
    public class CreateBookingRequest
    {
        public string book_date { get; set; }
        public string book_time { get; set; }
        public int court_id { get; set; }
        public int play_id { get; set; }
        public string book_createdate { get; set; }
        public int book_active { get; set; }
    }
}
