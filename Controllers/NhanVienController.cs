using LeHuuToan_2001206939_LTW.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeHuuToan_2001206939_LTW.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult Index()
        {
            return View(new NhanVien());
        }
    }
}
