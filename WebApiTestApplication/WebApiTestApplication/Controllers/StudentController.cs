using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiTestApplication.Data;
using WebApiTestApplication.Models;

namespace WebApiTestApplication.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private Context _context;

        public StudentController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _context.Students.ToList();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}