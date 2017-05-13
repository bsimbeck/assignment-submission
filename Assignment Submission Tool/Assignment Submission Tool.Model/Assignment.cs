using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Submission_Tool.Model
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public string AssignmentLanguage { get; set; }
        public string AssignmentDescription { get; set; }
        public List<CodeEval> Tests { get; set; }
    }
}
