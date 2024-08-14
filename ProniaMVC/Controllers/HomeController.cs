using Microsoft.AspNetCore.Mvc;
using ProniaMVC.DAL;
using ProniaMVC.Models;
using ProniaMVC.ViewModels;

namespace ProniaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slide> slide = new List<Slide>
            {
                new Slide{
                Title="First Title",
                SubTitle="First SubTitle",
                Description="Desc First",
                Order=1,
                Image="1-1.png",
                IsDeleted=false,
                CreatedAt=DateTime.Now
                },
                new Slide{
                Title="Second Title",
                SubTitle="Second SubTitle",
                Description="Desc Second",
                Order=3,
                Image="1-1.png",
                IsDeleted=false,
                CreatedAt=DateTime.Now
                },
                new Slide{
                Title="Third Title",
                SubTitle="Third SubTitle",
                Description="Desc Third",
                Order=2,
                Image="1-1.png",
                IsDeleted=false,
                CreatedAt=DateTime.Now
                },
            };

            _context.Slides.AddRange(slide);
            _context.SaveChanges();

            HomeVM homeVM = new HomeVM
            {
                Slides = _context.Slides.OrderBy(s => s.Order).ToList().Take(2)
            };
            return View(homeVM);
        }
    }
}
