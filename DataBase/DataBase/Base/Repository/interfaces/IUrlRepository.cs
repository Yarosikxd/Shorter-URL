using DataBase.Models;

namespace DataBase.Base.Repository.interfaces
{
    public interface IUrlRepository
    {
        List<UrlTable> GettAllUrls();
        public void AddUrl(string fullUrl, int UserId, UrlTable shortUrl);
       // public void GenerateShort(UrlTable shortUrl);
        public void RemoveUrl(int id);
        public UrlTable GetByUrlId(int id);
    }
}
