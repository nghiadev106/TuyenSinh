using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Model;
using TuyenSinh.Models;

namespace TuyenSinh.Controllers
{
    public class BlogsController : Controller
    {
        private readonly tuyensinhContext _context;

        public BlogsController(tuyensinhContext context)
        {      
            _context = context;
        }
        public async Task<IActionResult> ListBlogs(int page = 1)
        {
            int totalRow = 0;
            var pageSize = 10;
            var blogs = await _context.News.Where(x => x.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            totalRow = blogs.Count();
            var sanphams = blogs.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<News>()
            {
                Items = sanphams,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage
            };
            return View(paginationSet);
        }

        public async Task<IActionResult> DetailBlog(int id)
        {
            var blog = await _context.News.Where(x => x.Status == 1&& x.Id==id).SingleOrDefaultAsync();
            return View(blog);
        }
    }
}
