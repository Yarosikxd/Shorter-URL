using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Base.Repository.interfaces
{
    public interface IUserRepository
    {
        public void AddUser(string userName, string password);
        public void DeleteUser(int id);
        UserTable GetByUserName(string userName);
    }
}
