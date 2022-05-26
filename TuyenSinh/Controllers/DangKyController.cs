using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Model;
using TuyenSinh.Models;
using TuyenSinh.Services;

namespace TuyenSinh.Controllers
{
    public class DangKyController : Controller
    {
        private readonly tuyensinhContext _context;
        private readonly IStudentService _service;

        public DangKyController(tuyensinhContext context, IStudentService service)
        {
            _context = context;
            _service = service;
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
            ViewBag.subjectList = new SelectList(_context.SubjectTos.ToList(), "Id", "Name");
        }

        public IActionResult DangKyHocBa()
        {
            loadCategory();
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> DangKyHocBa(DangKyHocBaModel request)
        {
            loadCategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = await _service.DangKyHocBa(request);

            if (result != -1)
            {
                TempData["success"] = "Đăng ký thành công";
                return Redirect("/");
            }

            ModelState.AddModelError("", "Đăng ký thất bại");
            TempData["error"] = "Đăng ký thất bại";
            return View(request);
        }

        public IActionResult DangKyTHPT()
        {
            loadCategory();
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> DangKyTHPT(DangKyHocBaModel request)
        {
            loadCategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = await _service.DangKyTHPT(request);

            if (result != -1)
            {
                TempData["success"] = "Đăng ký thành công";
                return Redirect("/");
            }

            ModelState.AddModelError("", "Đăng ký thất bại");
            TempData["error"] = "Đăng ký thất bại";
            return View(request);
        }
    }
}
