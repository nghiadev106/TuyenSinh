using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Model;
using TuyenSinh.Models;

namespace TuyenSinh.Controllers
{
    public class QuestionController : Controller
    {
        private readonly tuyensinhContext _context;

        public QuestionController(tuyensinhContext context)
        {
            _context = context;
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

        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _context.Questions.Where(x => x.Status == 1 && x.Id == id).SingleOrDefaultAsync();
            return View(blog);
        }
    }
}
