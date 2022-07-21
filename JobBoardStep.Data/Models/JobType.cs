using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class JobType
    {
        public int JobTypeId { get; set; }
        public DateTime CareateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool JobTypeStatus { get; set; }
        public virtual ICollection<JobTypeTranslate>? JobTypeTranslates { get; set; }
    }
}
