using DataBase.Base;
using DataBase.Base.Repository;
using Logic.Services.Interfaces;

namespace Logic.Services
{
   public class UserService : UserRepository, IUserService
   {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context) : base(context) { }
   }
}
