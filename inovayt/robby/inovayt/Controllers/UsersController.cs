using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using inovayt.Data;
using inovayt.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;
using Microsoft.AspNetCore.Hosting;

namespace inovayt.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UsersController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult User()
        {
            WebClient webclient = new WebClient();
            var jsonUserData = webclient.DownloadString($"{this._webHostEnvironment.WebRootPath}\\json\\user.json");
            var deserializeUserData = JsonConvert.DeserializeObject<Users>(jsonUserData);
            var usersList= deserializeUserData;
            return View(usersList);
        }

        [HttpPost]
        public IActionResult User(List<VMUser> users)
        {
            return RedirectToAction("User");
        }
        public IActionResult Back()
        {
            return RedirectToAction("User");
        }
        public IActionResult Next()
        {
            return RedirectToAction("User");
        }
    }
}
