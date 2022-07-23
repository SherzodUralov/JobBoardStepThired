﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class JobCategoryTranslate
    {
        public int Id { get; set; }
        public string JobCatName { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int JobCatId { get; set; }
        public JobCategory JobCategory { get; set; }
    }
}
