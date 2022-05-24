using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TuyenSinh.Model;

namespace TuyenSinh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly tuyensinhContext _context;

        public HomeController(ILogger<HomeController> logger, tuyensinhContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Categories(int id, string sort, int page = 1,int pageSize=12)
        {
           
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
