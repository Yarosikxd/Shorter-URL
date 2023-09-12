using DataBase.Base;
using DataBase.Base.Repository;
using DataBase.Base.UnitOfWork;
using Logic.Services.Interfaces;

namespace Logic.Services
{
    public class UrlService : UrlRepository, IUrlService
    {
        private readonly AppDbContext _context;
        public UrlService(AppDbContext context) : base(context) { }
    }
}
