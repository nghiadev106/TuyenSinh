using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Model;
using TuyenSinh.Models;
using TuyenSinh.Services;

namespace TuyenSinh.Controllers
{
    public class QuestionController : Controller
    {
        private readonly tuyensinhContext _context;
        private readonly IQuestionService _service;

        public QuestionController(tuyensinhContext context,IQuestionService service)
        {
            _context = context;
            _service = service;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            int totalRow = 0;
            var pageSize = 10;
            var blogs = await _context.Questions.Where(x => x.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            totalRow = blogs.Count();
            var ques = blogs.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<Question>()
            {
                Items = ques,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage
            };
            return View(paginationSet);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(QuestionViewModel request)
        {
            var model = new Question()
            {
                Name = request.Name,
                CreateDate = DateTime.Now,
                Url = request.Url,
                Status = 2
            };
            _context.Questions.Add(model);
            var res=_context.SaveChanges();        
            return View(res);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _context.Questions.Where(x => x.Status == 1 && x.Id == id).SingleOrDefaultAsync();
            return View(blog);
        }
    }
}
