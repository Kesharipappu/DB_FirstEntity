using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB_FirstEntity.Models
{
    //DTO->Data Transfer Object
    public class EmployeeDetails
    {
        //employee POCO->Plain Old CLR Object
        public int EId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Address POCO->Plain Old CLR Object
        public string AddressLine { get; set; } 
        public string State { get; set; }
        public string City { get; set; }

    }
}