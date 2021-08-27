using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }
}
