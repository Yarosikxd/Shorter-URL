using DataBase.Base;
using DataBase.Base.Repository;
using DataBase.Base.UnitOfWork;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    static void Main(string[] args)
    {
        var db = new AppDbContext();
        var rep = new UrlRepository(db);




        var shortUrl = new UrlTable
        {
            OriginalUrl = " t2",
            UserId = 3
        };
       
        //Console.WriteLine("Done");
        var u = new UnitOfWork(db);
        //u.UserRepository.AddUser("Alina","90-60-90");
        //Console.WriteLine("Done");
        u.UrlRepository.AddUrl("t2",3,shortUrl);

    }
}