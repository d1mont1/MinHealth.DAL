using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL.Entities
{
    public class Employee
    {
        public string Position { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
