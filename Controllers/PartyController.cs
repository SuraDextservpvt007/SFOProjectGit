using Microsoft.AspNetCore.Mvc;
using SFO.Models;

namespace SFO.Controllers
{
    public class PartyController : Controller
    {
        private readonly MyDbContext _context;

        public PartyController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult PartyView()
        {
            
            var parties = _context.Parties.ToList();

           
            return View(parties);
        }
    }
}