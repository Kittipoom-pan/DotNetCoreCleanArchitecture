using System;

namespace DotNetCore.Core.Entities
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? Salary { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
