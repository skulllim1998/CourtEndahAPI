using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourtEndahAPI_v1.Request
{
    public class CreateAdminRequest
    {
        public string admin_username { get; set; }
        public string admin_password { get; set; }
    }
}
