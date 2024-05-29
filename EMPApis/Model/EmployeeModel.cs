using System;
using System.ComponentModel.DataAnnotations;

namespace EMPApis.Models
{
    public class EmployeeModel
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Department { get; set; }
        public int Salary { get; set; }
        public bool HasLeft { get; set; }
        public DateTime? LeavingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
