using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleEmployeeManagement.Model
{
    public partial class Employee
    {
        [Key]
        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        [Column("First_Name")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column("Last_Name")]
        [StringLength(100)]
        public string LastName { get; set; }
        public int? Age { get; set; }
        [Column("Email_Id")]
        [StringLength(500)]
        public string EmailId { get; set; }
        [Column("Mobile_Number")]
        [StringLength(20)]
        public string MobileNumber { get; set; }
    }
}
