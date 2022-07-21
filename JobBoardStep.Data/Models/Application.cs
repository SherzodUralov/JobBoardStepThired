using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool ApplicationStatus { get; set; }

    }
}
