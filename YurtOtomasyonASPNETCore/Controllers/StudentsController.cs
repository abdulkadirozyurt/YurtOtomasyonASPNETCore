using Business.Abstracs;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YurtOtomasyonASPNETCore.Controllers
{
    public class StudentsController : Controller
    {
        IStudentService studentService = new StudentManager(new EfStudentDal());

        public IActionResult Index()
        {
            var students = studentService.GetAll();

            return View(students);
        }
    }
}
