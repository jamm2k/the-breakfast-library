using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBreakfastLibrary.Models;
using Microsoft.EntityFrameworkCore;

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
        public Seller FindById(int id)
        {
            return _context.Seller.Include(sel => sel.Department).FirstOrDefault(sel => sel.Id == id); //eager loading
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
