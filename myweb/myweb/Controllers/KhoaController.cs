using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myweb.Controllers
{
    public class KhoaController : Controller
    {
        public IActionResult EditKhoa()
        {

            return View();
        }
    }
}