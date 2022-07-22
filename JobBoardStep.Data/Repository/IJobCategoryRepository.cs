using JobBoardStep.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Repository
{
    public interface IJobCategoryRepository
    {
        Task<IEnumerable<JobCategory>> GetAllAsync();
        Task<JobCategory> GetByIdAsync(int id);
        Task AddAsync(JobCategory jobCategory);
        Task Update(JobCategory jobCategory);
        Task DeleteAsync(int id);
    }
}
