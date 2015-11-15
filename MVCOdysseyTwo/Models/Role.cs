using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCOdysseyTwo.Models
{
    public class Role
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public virtual Movie movie { get; set; }

        public virtual Actor actor { get; set; }
    }
}