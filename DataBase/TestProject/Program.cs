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
            OriginalUrl = " t7",
            UserId = 3
        };
       
        //Console.WriteLine("Done");
        var u = new UnitOfWork(db);
        //u.UserRepository.AddUser("Alina","90-60-90");
        //Console.WriteLine("Done");
        //u.UrlRepository.AddUrl("t7",3,shortUrl);
        //u.UrlRepository.RemoveUrl(20);
        //u.UserRepository.DeleteUser(4);
        var s = new UserService();

    }
}