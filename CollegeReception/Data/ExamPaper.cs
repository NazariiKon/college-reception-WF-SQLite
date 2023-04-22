using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeReception.Data
{
    internal class ExamPaper
    {
        public long Id { get; set; }
        public long SpecialityId { get; set; }
        public long StudentId { get; set; }
    }
}
