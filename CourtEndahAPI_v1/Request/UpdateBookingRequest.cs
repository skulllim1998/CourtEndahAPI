using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourtEndahAPI_v1.Request
{
    public class UpdateBookingRequest
    {
        public string book_date { get; set; }
        public string book_time { get; set; }
        public int court_id { get; set; }
    }
}
