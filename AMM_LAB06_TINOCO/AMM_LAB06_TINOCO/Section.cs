using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AMM_LAB06_TINOCO
{
    public class Section: ObservableCollection<Student>
    {
        public string LongName { get; set; }
        public string ShortName {  get; set; }
    }
}
