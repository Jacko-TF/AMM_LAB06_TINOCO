using System;
using System.Collections.Generic;
using System.Text;

namespace AMM_LAB06_TINOCO
{
    public class Student
    {
        public string Name { get; set; }

        public string LastName {  get; set; }
        public int Age { get; set; }
        public string FullName 
        {
            get
            {
                return $"{LastName}, {Name} - {Age}";
            }
        }
        public Student() { }
    }
}
