using JobBoardStep.Data.Context;
using JobBoardStep.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Repository
{
    public class JobCategoryRepository:IJobCategoryRepository
    {
        private readonly AppDbContext _context;

        public JobCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(JobCategory jobCategory)
        {
             await _context.JobCategories.AddAsync(jobCategory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await GetByIdAsync(id);
            _context.JobCategories.Remove(result);
            await _context.SaveChangesAsync();  
        }

        public async Task<IEnumerable<JobCategory>> GetAllAsync()
        {
            return await _context.JobCategories.ToListAsync();
        }

        public async Task<JobCategory> GetByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.JobCategories.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task Update(JobCategory jobCategory)
        {
            _context.JobCategories.Update(jobCategory);
            await _context.SaveChangesAsync();
        }
    }
}
