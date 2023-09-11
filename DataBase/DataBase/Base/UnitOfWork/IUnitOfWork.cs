

using DataBase.Base.Repository.interfaces;

namespace DataBase.Base.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository UserRepository { get; }
        IUrlRepository UrlRepository { get; }
        void SaveChange();
    }
}
