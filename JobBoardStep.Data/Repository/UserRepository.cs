using JobBoardStep.Data.Context;
using JobBoardStep.Data.Models;
using JobBoardStep.Data.ViewModels;
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

        public IEnumerable<UserIndexViewModel> GetAll()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var model = context.Users.Select(x => new UserIndexViewModel
            {
                UserId = x.UserId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PassportNumber = x.PassportNumber,
                BirthDate = x.BirthDate,
                CreateDate = x.CreateDate,
                UserTypeName = x.UserType.UserTypeName,
                RegionName = x.RegionTranslate.Name,
                InformationName = x.InformationTranslate.Name
            });
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            return model;
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
