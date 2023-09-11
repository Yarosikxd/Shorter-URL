using DataBase.Base.Repository.interfaces;
using DataBase.Models;
using System.Linq.Dynamic.Core;

namespace DataBase.Base.Repository
{
    public class UrlRepository : IUrlRepository
    {
        private readonly AppDbContext _context;
        public UrlRepository(AppDbContext context)
        {
            _context = context;
        }
        private string GenerateShortUrl(string originalUrl)
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();


            string shortUrl = new string(Enumerable.Repeat(characters, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return $"https://myshorturl.com/{shortUrl}";
        }
        public void AddUrl(string fullUrl, int userId, UrlTable shortUrl)
        {
            var url = new UrlTable() { OriginalUrl = fullUrl, UserId = userId};
           
           
            shortUrl.ShortUrl = GenerateShortUrl(shortUrl.OriginalUrl);
            _context.UrlsTable.Add(shortUrl);
            _context.SaveChanges();
        }
        //public void GenerateShort(UrlTable shortUrl)
        //{
        //    shortUrl.ShortUrl = GenerateShortUrl(shortUrl.OriginalUrl);
        //    _context.UrlsTable.Add(shortUrl);
        //    _context.SaveChanges();
        //}
        
        public UrlTable GetByUrlId(int id)
        {
            return _context.UrlsTable.FirstOrDefault(u => u.Id == id);
        }

        public List<UrlTable> GettAllUrls()
        {
            return _context.UrlsTable.ToList();
        }

        public void RemoveUrl(int urlId)
        {
            var url = _context.UrlsTable.Find(urlId);
            if (url != null)
            {
                _context.UrlsTable.Remove(url);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Url is null");
            }
        }
    }
}
