using JobBoardStep.Data.Models;
using JobBoardStep.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Repository
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
        Task<IEnumerable<User>> GetByAll();
        Task<User> Create(User user);
        Task<User> Update(User newuser);
        User Delete(int id);
        IEnumerable<UserIndexViewModel> GetAll();


    }
}
