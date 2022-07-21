using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Models
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string? UserTypeName { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}
