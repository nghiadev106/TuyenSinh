using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TuyenSinh.Model;

namespace TuyenSinh.Controllers
{
    public class DangKyController : Controller
    {
        private readonly tuyensinhContext _context;

        public DangKyController(tuyensinhContext context)
        {
            _context = context;
        }

        public void loadCategory()
        {
            ViewBag.provinceList = new SelectList(_context.Provinces.ToList(), "Id", "Name");
            ViewBag.nationList = new SelectList(_context.Nations.ToList(), "Id", "Name");
            ViewBag.schoolList = new SelectList(_context.Schools.ToList(), "Id", "Name");

            ViewBag.abilityList = new SelectList(_context.Abilities.ToList(), "Id", "Name");
            ViewBag.conductList = new SelectList(_context.Conducts.ToList(), "Id", "Name");
            ViewBag.majorList = new SelectList(_context.Majors.ToList(), "Id", "Name"); 
            ViewBag.combinationList = new SelectList(_context.Combinations.ToList(), "Id", "Name");
        }

        public IActionResult DangKyHocBa()
        {
            loadCategory();
            return View();
        }
    }
}
