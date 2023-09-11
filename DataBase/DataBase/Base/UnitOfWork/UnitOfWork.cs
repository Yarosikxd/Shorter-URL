using DataBase.Base.Repository;
using DataBase.Base.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Base.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IUrlRepository UrlRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UrlRepository = new UrlRepository(_context); 
            UserRepository = new UserRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
