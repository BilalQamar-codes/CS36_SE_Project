using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BL
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } // Navigation property to access related user

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Qualifications { get; set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public bool Active { get; set; }

        public Teacher()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public Teacher(int userId, string firstName, string lastName, DateTime dateOfBirth, string gender,
            string address, string phoneNumber, string email, string qualifications, DateTime createdAt, DateTime updatedAt, bool active)
            : this()
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Qualifications = qualifications;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Active = active;
        }
    }

}
