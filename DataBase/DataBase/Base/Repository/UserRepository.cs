using DataBase.Base.Repository.interfaces;
using DataBase.Models;


namespace DataBase.Base.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddUser(string userName, string password)
        {
            if (_context != null)
            {
                var user = new UserTable() { Name = userName, Password = password };
                _context.UsersTable.Add(user);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Context is null");
            }
        }

        public void DeleteUser(int id)
        {
            var user = _context.UsersTable.Find(id);
            if (user != null)
            {
                _context.UsersTable.Remove(user);
                _context.SaveChanges();
            }
        }

        public UserTable GetByUserName(string userName)
        {
            return _context.UsersTable.FirstOrDefault(n => n.Name == userName);
        }
    }
}
