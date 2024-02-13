using AllUp_FrontToBack.DataAccessLayer;
using AllUp_FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllUp_FrontToBack.Areas.manage.Controllers
{
    [Area("manage")]
    public class FeatureController : Controller
    {
        private readonly AppDbContext _context;
        public FeatureController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Feature> features = _context.Features.ToList();
            return View(features);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Feature feature)
        {
            _context.Features.Add(feature);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var existFeature = _context.Features.FirstOrDefault(x => x.Id == id);
            return View(existFeature);
        }

        [HttpPost]
        public IActionResult Update(Feature feature)
        {
            var existFeature = _context.Features.FirstOrDefault(x => x.Id == feature.Id);

            existFeature.Title = feature.Title;
            existFeature.Description = feature.Description;
            existFeature.ImageUrl = feature.ImageUrl;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var feature = _context.Features.FirstOrDefault(x => x.Id == id);
            return View(feature);
        }

        [HttpPost]
        public IActionResult Delete(Feature feature)
        {
            _context.Features.Remove(feature);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
