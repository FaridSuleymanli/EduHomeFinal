﻿using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using EduHomeFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Controllers
{
    public class CourseController : Controller
    {
        private readonly EduDb _eduDb;
        public CourseController(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Courses courses = await _eduDb.Courses.FirstOrDefaultAsync(c => c.Id == id);
            if (courses == null)
                return NotFound();
            return View(courses);
        }
    }
}
