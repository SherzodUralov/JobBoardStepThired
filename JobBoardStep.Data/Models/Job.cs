﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string? Salary { get; set; }
        public DateTime CareateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Application>? Application { get; set; }
        public Experience? Experience { get; set; }
        public int ExperienceId { get; set; }
        public User? User { get; set; }
        public int UserId { get; set; }
    }
}
