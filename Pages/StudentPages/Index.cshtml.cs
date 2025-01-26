using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab3TestApp.Data;
using Lab3TestApp.Models;

namespace Lab3TestApp.Pages_StudentPages
{
    public class IndexModel : PageModel
    {
        private readonly Lab3TestApp.Data.ApplicationDbContext _context;

        public IndexModel(Lab3TestApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
