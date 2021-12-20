using System.Collections.Generic;
using FirstWebApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers{
    public class TestController:Controller{
        public IActionResult Index(){
            ViewData["title"] = "titleOfView";
            IList<string> colaborators = new List<string>();
            colaborators.Add("Pr. Youssefi");
            colaborators.Add("GLSID AmineH");
            return View(colaborators);
        }

        public IActionResult List(){
            IList<Student> students = new List<Student>();
            students.Add(new Student{Id = 1, Name = "AmineH", Score = 99});
            students.Add(new Student{Id = 2, Name = "John Smith", Score = 66});
            students.Add(new Student{Id = 3, Name = "Jane Smith", Score = 33});

            return View(students);
        }
    }
}