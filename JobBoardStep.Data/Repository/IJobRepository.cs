using JobBoardStep.Data.Models;
using JobBoardStep.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Repository
{
    public interface IJobRepository
    {

        Task<IEnumerable<JobIndexViewModel>> GetAllAsync();
        Task<Job> GetByIdAsync(int id);
        Task AddAsync(Job job);
        Task Update(Job job);
        Task DeleteAsync(int id);
        Task<IEnumerable<JobType>> GetAllJobType();
        Task<JobType> GetByIdJobType(int id);
        Task<IEnumerable<Experience>> GetAllExperiences();
        Task<Experience> GetByIdExperience(int id);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetByIdUser(int id);
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetByIdUserCategory(int id);
        

    }
}
