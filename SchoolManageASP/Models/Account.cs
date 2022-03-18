using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManageASP.Models
{
    public class Account
    {

        public int id { get; set; }
        public int username { get; set; }
        public int fullname { get; set; }
        public int password { get; set; }
        public int email { get; set; }
        public int numberPhone { get; set; }
        public int status { get; set; }
    }
}