using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuyenSinh.Controllers
{
    public class DangKyController : Controller
    {
        public IActionResult DangKyHocBa()
        {
            return View();
        }
    }
}
