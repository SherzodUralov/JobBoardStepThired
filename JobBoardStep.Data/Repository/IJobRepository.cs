using JobBoardStep.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Repository
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetAllAsync();
        Task<Job> GetByIdAsync(int id);
        Task AddAsync(Job job);
        Task Update(Job job);
        Task DeleteAsync(int id);
        

    }
}
