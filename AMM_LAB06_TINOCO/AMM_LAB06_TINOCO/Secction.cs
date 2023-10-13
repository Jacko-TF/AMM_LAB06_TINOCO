using System;
using System.Collections.Generic;
using System.Text;

namespace AMM_LAB06_TINOCO
{
    public class Secction:List<Student>
    {
        public string Title { get; set; }
        public List<Student> Students { get;set; }
    }
}
