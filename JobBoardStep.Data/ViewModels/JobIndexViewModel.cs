using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.ViewModels
{
    public class JobIndexViewModel
    {
     
        public string? Salary { get; set; }
        public DateTime CareateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? Description { get; set; }      

        public string?   JobTypeName { get; set; }      
      
        public string? ExperienceName { get; set; }
      
        public string? UserName { get; set; }
      
        public string?   JobCateName { get; set; }
    }
}
