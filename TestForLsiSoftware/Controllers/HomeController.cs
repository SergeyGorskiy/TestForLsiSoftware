using System;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using TestForLsiSoftware.EF;
using TestForLsiSoftware.Models;
using TestForLsiSoftware.Models.ViewModels;

namespace TestForLsiSoftware.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index([FromQuery] string selectedLocal, [FromQuery] DateTime startOfRange, [FromQuery] DateTime endOfRange)
        {
            if (selectedLocal is null)
            {
                if (startOfRange == endOfRange)
                {
                    return View(new RaportViewModel
                    {
                        Raports = _context.Raports,
                        Locals = _context.Raports.Select(l => l.Local)
                    });
                }
                else
                {
                    return View(new RaportViewModel
                    {
                        Raports = _context.Raports.Where(r => r.DateTimeOfCreate >= startOfRange && r.DateTimeOfCreate <= endOfRange),
                        Locals = _context.Raports.Select(l => l.Local)
                    });
                }
                
            }
            else
            {
                return View(new RaportViewModel
                {
                    Raports = _context.Raports.Where(r => r.Local == selectedLocal),
                    Locals = _context.Raports.Select(l => l.Local)
                });
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
