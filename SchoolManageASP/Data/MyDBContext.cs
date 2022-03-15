using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace bank_service.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext():base("name=SchoolManageDB")
        {

        }
    }
}