using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Areas.Admin.Models;
using TuyenSinh.Model;

namespace TuyenSinh.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly tuyensinhContext _context;

        public DashboardController(tuyensinhContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var counts = new DashboardViewModel
            {
                Student = _context.Students.ToList().Count(),
                StudentPass = _context.Students.Where(x=>x.Status==1).ToList().Count(),
                News = _context.News.ToList().Count(),
                NewsCategory = _context.Categories.ToList().Count(),
                Major = _context.Majors.ToList().Count(),
                Question = _context.Questions.ToList().Count()
            };
            ViewBag.ListStudent = _context.Students.Where(x =>x.Status == 0).ToList();
            ViewBag.counts = counts;
            return View();
        }
    }
}
