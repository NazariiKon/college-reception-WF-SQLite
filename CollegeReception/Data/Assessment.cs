using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeReception.Data
{
    public class Assessment
    {
        public Assessment() { }

        public long Id { get; set; } 
        public long SubjectId { get; set; } 
        public long StudentId { get; set; } 
        public long Assesment { get; set; } 

    }
}
