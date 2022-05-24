using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TuyenSinh.Areas.Admin.Models.Question;
using TuyenSinh.Services;

namespace TuyenSinh.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionController : BaseController
    {
        private readonly IQuestionService _newsService;
        private IHostingEnvironment _env;

        public QuestionController(IQuestionService newsService, IHostingEnvironment env)
        {
            _newsService = newsService;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var lstQuestion = await _newsService.GetAll();
            ViewBag.lstQuestion = lstQuestion;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create(QuestionCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";             
                return View(request);
            }

            var result = await _newsService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới Câu hỏi thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm Câu hỏi thất bại");
            TempData["error"] = "Thêm mới Câu hỏi thất bại";
            return View(request);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var news = await _newsService.Edit(id);
            if (news == null)
            {
                TempData["warning"] = "Bài viết không tồn tại";
                return RedirectToAction("Index");
            }
            return View(news);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit(QuestionUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = await _newsService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật Câu hỏi thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật Câu hỏi thất bại");
                TempData["error"] = "Cập nhật Câu hỏi thất bại";
                return View(request);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _newsService.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Bài viết không tồn tại";
                return RedirectToAction("Index");
            }
            var result = await _newsService.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa Câu hỏi thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xóa Câu hỏi thất bại";
            return RedirectToAction("Index");
        }
    }
}
