using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourtEndahAPI_v1.Request
{
    public class CreatePlayerRequest
    {
        public string play_username { get; set; }
        public string play_password { get; set; }
        public string play_fullname { get; set; }
        public string play_unitno { get; set; }
        public string play_cardno { get; set; }
        public string play_createdate { get; set; }
        public int play_active { get; set; }
    }
}
