using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Areas.Admin.Models;
using TuyenSinh.Model;

namespace TuyenSinh.Areas.Admin.Controllers
{
    public class StatisticController : BaseController
    {
        private readonly tuyensinhContext _context;

        public StatisticController(tuyensinhContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var counts = new StatisticViewModel
            {
                Student = _context.Students.ToList().Count(),
                StudentPass = _context.Students.Where(x => x.Status == 1).ToList().Count(),
                StudentFail=_context.Students.Where(x => x.Status == 2).ToList().Count(),
                StudentWait= _context.Students.Where(x => x.Status == 0).ToList().Count()
            };
            ViewBag.ListStudent = _context.Students.Where(x => x.Status == 1).ToList();
            ViewBag.counts = counts;
            return View();
        }
    }
}
