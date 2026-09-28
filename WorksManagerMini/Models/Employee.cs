using System;
using System.ComponentModel.DataAnnotations;

namespace WorksManagerMini.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; }

        [Required]

        public string Department { get; set; } = string.Empty;

        public string Designation { get; set; } = string.Empty;

        public string Status { get; set; } = "Active";

        public DateTime JoiningDate { get; set; } = DateTime.Now;
    }
}