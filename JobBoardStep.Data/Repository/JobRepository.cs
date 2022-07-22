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
    public class JobRepository:IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Job job)
        {
            await _context.Jobs.AddAsync(job);
           await _context.SaveChangesAsync();   
        }

        public async Task DeleteAsync(int id)
        {
            var result = await GetByIdAsync(id);
             _context.Jobs.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job> GetByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Jobs.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task Update(Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();  
        }
    }
}
