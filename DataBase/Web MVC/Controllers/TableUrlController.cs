using DataBase.Enums;
using DataBase.Models;
using DataBase.Models.ViewModels;
using Logic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web_MVC.Controllers
{
    public class TableUrlController : Controller
    {
        private readonly IUrlService _service;
        public TableUrlController(IUrlService service) 
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var entities = _service.GettAllUrls();
            var viewModel = entities.Select(x => new UrlTableViewModel()
            {
                Id = x.Id,
                CreationDate = x.DateMake,
                OriginalUrl = x.OriginalUrl,
                ShortUrl = x.ShortUrl,
                UserId = x.UserId
            }).ToList();
            foreach (var model in viewModel)
            {
                
            }
             return View(viewModel);
        }
        [HttpGet]
        public List<UrlTable> GetUrls()
        {
            return _service.GettAllUrls();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]

        public IActionResult AddUrl(string fullUrl, int userId, UrlTable shortUrl)
        {
           
           shortUrl.DateMake = DateTime.Now;
            _service.AddUrl(fullUrl,userId,shortUrl);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Delete(int urlId)
        {
           _service.RemoveUrl(urlId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int urlId)
        {
            _service.RemoveUrl(urlId);
            return RedirectToAction("Index");
        }
    }
}
