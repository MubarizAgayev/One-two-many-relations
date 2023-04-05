using EntityFramework_Slider.Data;
using EntityFramework_Slider.Models;
using EntityFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFramework_Slider.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            IEnumerable<Blog> blogs = await _context.Blogs.Where(m=>!m.SoftDelete).ToListAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Product> products = await _context.Products.Include(m=>m.Images).Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<About> abouts = await _context.Abouts.Where(m=>!m.SoftDelete).ToListAsync();

            IEnumerable<AboutOffer> aboutOffers = await _context.AboutOffers.ToListAsync();

            AboutInfo aboutInfo = await _context.AboutInfos.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<Expert> experts = await _context.Experts.Where(m => !m.SoftDelete).ToListAsync();

            ExpertInfo expertInfo = await _context.ExpertInfos.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            Subscribe subscribes = await _context.Subscribes.Where(m=>!m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<Say> says = await _context.Says.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Instagram> instagrams = await _context.Instagrams.Where(m => !m.SoftDelete).ToListAsync();

            BlogInfo blogInfos = await _context.BlogInfos.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo,
                Blogs = blogs,
                Categories = categories,
                Products = products,
                Abouts= abouts,
                AboutOffers= aboutOffers,
                AboutInfo = aboutInfo,
                Experts= experts,
                ExpertInfos = expertInfo,
                Subscribes = subscribes,
                Says = says,
                Instagrams = instagrams,
                BlogInfos = blogInfos
            };

            return View(model);
        }
    }
}