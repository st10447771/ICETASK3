using Microsoft.AspNetCore.Mvc;
using CullenInternshipInitiative.Models; // Ensure this namespace is correct based on your project structure
using System.Linq; // Import necessary namespaces for LINQ operations
using System.Threading.Tasks; // Import necessary namespaces for asynchronous operations
using Microsoft.EntityFrameworkCore; // Import for Entity Framework Core operations

namespace CullenInternshipInitiative.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();
            return View(students);
        }


        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("studentId,firstName, lastName, Email, YearLevel")] Students student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
