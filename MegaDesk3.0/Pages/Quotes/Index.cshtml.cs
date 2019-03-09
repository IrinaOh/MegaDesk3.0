using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk3._0.Models;

namespace MegaDesk3._0.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk3._0.Models.MegaDesk3_0Context _context;

        public IndexModel(MegaDesk3._0.Models.MegaDesk3_0Context context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
        }
    }
}
