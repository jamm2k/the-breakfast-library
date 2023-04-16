using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBreakfastLibrary.Models;

namespace TheBreakfastLibrary.Services
{
    public class DepartmentService
    {
        private readonly TheBreakfastLibraryContext _context;

        public DepartmentService(TheBreakfastLibraryContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
