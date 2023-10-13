using System;
using System.Collections.Generic;
using System.Text;

namespace AMM_LAB06_TINOCO
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public string FullName
        {
            get
            {
                return $"{Lastname}, {Name}";
            }
        }
    }
}
