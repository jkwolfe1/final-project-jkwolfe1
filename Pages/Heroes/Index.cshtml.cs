using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project;
using Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project.Pages.Heroes
{
    public class IndexModel : PageModel
    {
        private readonly Project.Models.OwContext _context;

        public IndexModel(Project.Models.OwContext context)
        {
            _context = context;
        }

        public IList<Hero> Hero {get; set;}

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        
        public SelectList SortList {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Heroes.Select(p => p);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem {Text = "Name Ascending", Value = "name_asc" },
                new SelectListItem {Text = "Name Descending", Value = "name_desc"}
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                case "name_asc": 
                    query = query.OrderBy(p => p.Name);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(p => p.Name);
                    break;
            }
            
            Hero = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            //Hero = await _context.Heroes.ToListAsync();
        }
    }
}
