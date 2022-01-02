using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebApp.Models;

namespace SalesWebApp.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1 , Name ="Eletronic"}) ;
            list.Add(new Department { Id = 2, Name = "Fortunire" });

            return View(list);
        }
    }
}
