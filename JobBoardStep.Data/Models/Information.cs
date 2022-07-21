using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class Information
    {
        public int UserTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool InformationStatus { get; set; }
        public virtual ICollection<InformationTranslate>? InformationTranslate { get; set; }

    }
}
