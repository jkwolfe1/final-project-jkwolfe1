using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project;
using Project.Models;

namespace Project.Pages.Heroes
{
    public class DetailsModel : PageModel
    {
        private readonly Project.Models.OwContext _context;

        public DetailsModel(Project.Models.OwContext context)
        {
            _context = context;
        }

        public Hero Hero { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hero = await _context.Heroes.FirstOrDefaultAsync(m => m.HeroId == id);

            if (Hero == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
