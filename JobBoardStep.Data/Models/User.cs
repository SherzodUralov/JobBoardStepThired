using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Email { get; set; }
        public string? PassportNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<Job>? Jobs { get; set; }
        public Information? Information { get; set; }
        public int InformationId { get; set; }
        public Region? Region { get; set; }
        public int RegionId { get; set; }
        public UserType? UserType { get; set; }
        public int UserTypeId { get; set; }
        public virtual ICollection<Application>? Applications { get; set; }

    }
}
