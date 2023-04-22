using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeReception.Data
{
    public class Student
    {
        public Student()
        {
            
        }

        public long Id { get; set; }
        public string FullName { get; set; }
        public long PassNumber { get; set; }
        public string LastEducational { get; set; }
        public string GraduationDate { get; set; }
        public string Award { get; set; } = "Немає";
        public long SpecialityId { get; set; }
        public string Info { get; set; }
    }

}
