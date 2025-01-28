using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SFO.Models;

namespace SFO.Controllers
{
    
    public class PartyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PartyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Party
        public async Task<IActionResult> Partyview()
        {
           
            var parties = await _context.Parties.ToListAsync();
            return View(parties); // Pass parties to the view
        }

    }
}