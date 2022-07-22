using JobBoardStep.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Repository
{
    public interface IApplicationRepository
    {
        Task<Models.Application> GetById(int id);
        Task<IEnumerable<Models.Application>> GetByAll();
        Task<Models.Application> Create(Application application);
        Task<Models.Application> Update(Application newapplication);
        Application Delete(int id);
        
    }
}
