using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BL
{
    public class Class
    {
        public Class(string name, string level, DateTime? createdAt, DateTime? updatedAt, bool active)
        {
            Name = name;
            Level = level;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Active = active;
        }

        public Class()
        {
        }

        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; }
    }
}
