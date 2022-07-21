using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool RegionStatus { get; set; }
        public virtual ICollection<RegionTranslate>? RegionTranslates { get; set; }

        public virtual ICollection<User>? Users { get; set; }
    }
}
