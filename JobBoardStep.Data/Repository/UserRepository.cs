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
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<User> Create(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }

        public User Delete(int id)
        {
            var user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
#pragma warning disable CS8603 // Possible null reference return.
            return user;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<User>> GetByAll()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await context.Users.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<User> Update(User newuser)
        {
            context.Users.Update(newuser);
            await context.SaveChangesAsync();
            return newuser;
        }

       
    }
}
