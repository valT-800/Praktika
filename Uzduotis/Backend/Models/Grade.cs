using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis.Backend.Models
{
    class Grade
    {
        public int ID { get; set; }
        public string WorkTitle { get; set; }
        public int GradeValue { get; set; }
        

        public Grade(string workTitle, int grade, int id)
        {
            ID = id;
            WorkTitle = workTitle;
            GradeValue = grade;
        }
    }
}
