using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Model;
using TuyenSinh.Services;

namespace TuyenSinh.Controllers
{
    public class HomeController : Controller
    {
        private readonly tuyensinhContext _context;
        private readonly IMajorService _majorService;

        public HomeController(tuyensinhContext context, IMajorService majorService)
        {
            _context = context;
            _majorService = majorService;
        }

        public async Task<IActionResult> Index()
        {
            var majors = await _majorService.GetAll();
            ViewBag.majors = majors;
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        public async Task<IActionResult> GetDistrict(int id)
        {
            var district = await _context.Districts.Where(x=>x.ProvinceId==id).ToListAsync();
            return Ok(district);
        }

        public async Task<IActionResult> GetWard(int id)
        {
            var ward = await _context.Wards.Where(x => x.DistrictId == id).ToListAsync();
            return Ok(ward);
        }

        public async Task<IActionResult> GetSchool(int id)
        {
            var school = await _context.Schools.Where(x => x.ProvinceId == id).ToListAsync();
            return Ok(school);
        }
    }
}
