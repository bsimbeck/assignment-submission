using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Submission_Tool.Model
{
    class AssignmentSubmission
    {
        public int AssignmentSubmissionID { get; set; }
        public Assignment AssignmentInformation { get; set; }
        public string AssignmentFileName { get; set; }
        public string AssignmentFileContents { get; set; }
    }
}
