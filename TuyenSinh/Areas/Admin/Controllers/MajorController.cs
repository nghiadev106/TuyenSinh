using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Areas.Admin.Controllers
{
    public class MajorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
