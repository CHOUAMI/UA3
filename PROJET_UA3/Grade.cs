using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_UA3
{
    public class Grade
    {
        public int StudentNumber { get; set; }
        public int CourseNumber { get; set; }
        public double Score { get; set; }

        public override string ToString()
        {
            return $"Student Number: {StudentNumber}, Course Number: {CourseNumber}, Score: {Score}";
        }
    }
}
