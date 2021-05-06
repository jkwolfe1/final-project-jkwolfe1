using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project.Pages.Maps
{
    public class IndexModel : PageModel
    {
        private readonly Project.Models.OwContext _context;

        public IndexModel(Project.Models.OwContext context)
        {
            _context = context;
        }

        public IList<Map> Map {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        
        public async Task OnGetAsync()
        {
            var query = _context.Maps.Select(p => p);
            
            switch (CurrentSort)
            {
                case "name_asc": 
                    query = query.OrderBy(p => p.Name);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(p => p.Name);
                    break;
            }

            Map = await _context.Maps.ToListAsync();
        }
    }
}
