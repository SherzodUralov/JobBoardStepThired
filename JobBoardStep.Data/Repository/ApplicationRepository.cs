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
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly AppDbContext context;

        public ApplicationRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Application> Create(Application application)
        {
            context.Applications.Add(application);
            await context.SaveChangesAsync();
            return application;
        }

        public Application Delete(int id)
        {
            var app = context.Applications.Find(id);
            if (app != null)
            {
                context.Applications.Remove(app);
                context.SaveChanges();
            }
#pragma warning disable CS8603 // Possible null reference return.
            return app;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<Application>> GetByAll()
        {
            return await context.Applications.ToListAsync();
        }

        public async Task<Application> GetById(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await context.Applications.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<Application> Update(Application newapplication)
        {
            context.Applications.Update(newapplication);
            await context.SaveChangesAsync();
            return newapplication;
        }
    }
}
