using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBreakfastLibrary.Models;

namespace TheBreakfastLibrary.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Romance"});
            list.Add(new Department { Id = 2, Name = "Classics"});

            return View(list);
        }
    }
}