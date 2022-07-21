using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class InformationTranslate
    {
        public int InforTransId { get; set; }
        public string? InformationTranslateName { get; set; }
        public Language? Language { get; set; }
        public int LanguageId { get; set; }
        public Information? Information { get; set; }
        public int InformationId { get; set; }
    }
}
