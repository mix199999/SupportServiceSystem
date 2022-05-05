using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSupport
{
    
    public class UserCaseModel
    {
        public int CaseId { get; set; }
        public int TransationId { get; set; }
        public int UserId { get; set; }
        public string CaseStatus { get; set; }

        public string UserText{ get; set; }
        public string AdminText { get; set; }
        public string CaseName { get; set; }




    }
}
