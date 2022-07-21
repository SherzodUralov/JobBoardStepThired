using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class JobTypeTranslate
    {
        public int JobTypeTranslateId { get; set; }
        public string? JobTypeTranslateName { get; set; }
        public Language? Language { get; set; }
        public int LanguageId { get; set; }
        public JobType? JobType { get; set; }
        public int JobTypeId { get; set; }


       

    }
}
