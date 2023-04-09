using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBreakfastLibrary.Models;

namespace TheBreakfastLibrary.Services
{
    public class SellerService
    {
        private readonly TheBreakfastLibraryContext _context;

        public SellerService(TheBreakfastLibraryContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller sel)
        {
            _context.Add(sel);
            _context.SaveChanges();
        }
    }
}
