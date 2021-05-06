using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project;
using Project.Models;

namespace Project.Pages.Maps
{
    public class DetailsModel : PageModel
    {
        private readonly Project.Models.OwContext _context;

        public DetailsModel(Project.Models.OwContext context)
        {
            _context = context;
        }

        public Map Map { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Map = await _context.Maps.FirstOrDefaultAsync(m => m.MapId == id);

            if (Map == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
