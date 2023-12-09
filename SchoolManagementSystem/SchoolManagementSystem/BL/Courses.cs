using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BL
{
    public class Course
    {
       
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; }
        
        public Course(string name, string description, int teacherId, DateTime? createdAt, DateTime? updatedAt, bool active)
        {
            Name = name;
            Description = description;
            TeacherId = teacherId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Active = active;
        }
    }

}
