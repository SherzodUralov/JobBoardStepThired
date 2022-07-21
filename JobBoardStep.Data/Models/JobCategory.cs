﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class JobCategory
    {
        public int JobCatId { get; set; }
        public string? JobCatName { get; set; }
        public virtual ICollection<JobCategoryTranslate>? JobCategoryTranslate { get; set; }
        public virtual ICollection<Job>? Jobs { get; set; }
    }
}
