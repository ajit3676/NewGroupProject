using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewGroupProject.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }

}