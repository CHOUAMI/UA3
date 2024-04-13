using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_UA3
{
    public class Course
    {
        public int CourseNumber { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"Course Number: {CourseNumber}, Code: {Code}, Title: {Title}";
        }
    }
}
