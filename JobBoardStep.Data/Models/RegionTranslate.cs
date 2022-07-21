using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class RegionTranslate
    {
        public int RegionTranslateId { get; set; }
        public string? RegionTranslateName { get; set; }
        public Language? Language { get; set; }
        public int LanguageId { get; set; }
        public Region? Region { get; set; }
        public int RegionId { get; set; }

    }
}
