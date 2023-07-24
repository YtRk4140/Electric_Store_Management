using ElectricStore_ChauHan_Repository.DAO;
using ElectricStore_ChauHan_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStore_ChauHan_Repository.Repository
{
    public class UserStore : IUserRepository
    {
        public User GetUser(string id)
        => UserDbContext.Instance.GetUserById(id);

        public IEnumerable<User> GetUsers()
        => UserDbContext.Instance.GetAllUsers();

        public User LoginName(string username)
        {
            return UserDbContext.Instance.LoginMember(username);
        }
    }
}
