using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string? LanguageName { get; set; }
        public bool LanguageStatus { get; set; }
        public virtual ICollection<JobTypeTranslate>? JobTypeTranslates { get; set; }
        public virtual ICollection<RegionTranslate>? RegionTranslates { get; set; }
        public virtual ICollection<InformationTranslate>? InformationTranslate { get; set; }
        public virtual ICollection<ExperienceTranslate>? ExperienceTranslate { get; set; }
        public virtual ICollection<JobCategoryTranslate>? JobCategoryTranslate { get; set; }


    }
}
