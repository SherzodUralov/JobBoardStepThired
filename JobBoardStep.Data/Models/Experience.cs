using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public DateTime CareateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool ExperienceStatus { get; set; }
        public virtual ICollection<ExperienceTranslate>? ExperienceTranslate { get; set; }
        public virtual ICollection<Job>? Jobs { get; set; }
    }
}
