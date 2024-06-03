using System;
using System.ComponentModel.DataAnnotations;

namespace EMPApis.Models
{
    public class EmployeeModel
    {
        [Key]
        public int ID { get; set; } 
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "Middle name cannot exceed 50 characters")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address1 is required")]
        [MaxLength(100, ErrorMessage = "Address1 cannot exceed 100 characters")]
        public string Address1 { get; set; }

        [MaxLength(100, ErrorMessage = "Address2 cannot exceed 100 characters")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [MaxLength(50, ErrorMessage = "City cannot exceed 50 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [MaxLength(50, ErrorMessage = "State cannot exceed 50 characters")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip code is required")]
        [Range(10000, 99999, ErrorMessage = "Zip code must be a valid 5-digit number")]
        public int Zip { get; set; }

        [Required(ErrorMessage = "Joining date is required")]
        public DateTime JoiningDate { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public int Department { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Salary must be a positive number")]
        public int Salary { get; set; }

        public bool HasLeft { get; set; }
        public DateTime? LeavingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
    public record User(Guid Id, string Name, string Email, string Password, string[] Roles);

}
