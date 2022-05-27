using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Areas.Admin.Models.Major;
using TuyenSinh.Model;
using TuyenSinh.Services;

namespace TuyenSinh.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MajorController : BaseController
    {
        private readonly IMajorService _service;
        private readonly tuyensinhContext _context;

        public MajorController(IMajorService service, tuyensinhContext context)
        {
            _service = service;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var majors = await _service.GetAll();
            ViewBag.majors = majors;
            return View();
        }

        public IActionResult Create()
        {
            loadcategory();
            return View();
        }

        public void loadcategory()
        {
            ViewBag.combinationList = new SelectList(_context.Combinations.ToList(), "Id", "Name");
        }

        [HttpPost]
        public async Task<IActionResult> Create(MajorRequest request)
        {
            loadcategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = await _service.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới Chuyên ngành thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm Chuyên ngành thất bại");
            TempData["error"] = "Thêm mới Chuyên ngành thất bại";
            return View(request);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await _service.Edit(id);
            if (category == null)
            {
                TempData["warning"] = "Chuyên ngành không tồn tại";
                return RedirectToAction("Index");
            }
            loadcategory();
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MajorRequest request)
        {
            loadcategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = await _service.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật Chuyên ngành thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật Chuyên ngành thất bại");
                TempData["error"] = "Cập nhật Chuyên ngành thất bại";
                return View(request);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _service.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Chuyên ngành không tồn tại";
                return RedirectToAction("Index");
            }

            var result = await _service.Delete(id);
            if (result != 1)
            {
                ModelState.AddModelError("", "Xóa Chuyên ngành thất bại");
                return RedirectToAction("Index");
            }
            TempData["success"] = "Xóa Chuyên ngành thành công";
            return RedirectToAction("Index");
        }
    }
}
