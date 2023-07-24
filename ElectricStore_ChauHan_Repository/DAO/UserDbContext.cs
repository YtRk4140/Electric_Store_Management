using ElectricStore_ChauHan_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStore_ChauHan_Repository.DAO
{
    public class UserDbContext : ElectricStoreContext
    {
        private static UserDbContext instance = null;
        private static readonly object instanceLock = new object();

        private UserDbContext() { }
        public static UserDbContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDbContext();
                    }
                    return instance;
                }
            }
        }
        public User GetUserById(string id)
        {
            return this.Users.FirstOrDefault(m => m.UserId.Equals(id));
        }
        public IEnumerable<User> GetAllUsers()
        {
            return this.Users.ToList();
        }
        public User LoginMember(string username) 
        {
            return this.Users.FirstOrDefault(m => m.UserName == username);
        }
    }
}
