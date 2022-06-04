using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models.DBContext
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }
}