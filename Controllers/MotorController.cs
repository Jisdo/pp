using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TokoMotor.Data;
using TokoMotor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;

namespace TokoMotor.Controllers
{
    public class MotorController : Controller
    {
        private TokoMotorDbContext _context;
        public MotorController(TokoMotorDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Motors.ToList());
        }

        public async Task<IActionResult> Beli(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }  
            var beli =  await _context.Motors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (beli == null)
            {
                return NotFound();
            }
            return View(beli);
        }
    }
}