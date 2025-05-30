using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CullenInternshipInitiative.Controllers
{
    public class CompaniesController : Controller
    {
        // GET: CompaniesController
        public ActionResult Index()
        {
            return View();
        }
    }
}
