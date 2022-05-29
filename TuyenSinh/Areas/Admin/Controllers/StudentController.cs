using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuyenSinh.Model;
using TuyenSinh.Models;
using TuyenSinh.Services;

namespace TuyenSinh.Areas.Admin.Controllers
{
    public class StudentController : BaseController
    {
        private readonly tuyensinhContext _context;
        private readonly IStudentService _service;

        public StudentController(tuyensinhContext context, IStudentService service)
        {
            _context = context;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var students =await _service.GetAll();
            return View(students);
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

        public async Task<IActionResult> Detail(int id)
        {
            loadCategory();
            var student = await _service.Detail(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Detail(DangKyHocBaModel model)
        {
            loadCategory();
            var s = _context.Students.Find(model.Id);
            s.Status = model.Status;
            var res=_context.SaveChanges();
            if (res > 0)
            {
                TempData["success"] = "Duyệt thành công";
            }
            else
            {
                TempData["error"] = "Duyệt thất bại";
            }
            return View(model);
        }
    }
}
