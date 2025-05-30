using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CullenInternshipInitiative.Controllers
{
    public class Internships : Controller
    {
        // GET: Internships
        public ActionResult Index()
        {
            return View();
        }
        
    }
}
