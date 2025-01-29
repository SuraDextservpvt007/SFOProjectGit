using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SFO.DAL;

namespace SFO.Controllers
{

    public class PartyController : Controller
    {
        private readonly ApplicationDbContext context;

    public PartyController(ApplicationDbContext context)
    {
        this.context = context;
    }

        // GET: Party
        
        public  IActionResult Partyview()
        {
            
            var parties =  context.Party.ToList();
            return View(parties); // Pass parties to the view
        }

    }
}