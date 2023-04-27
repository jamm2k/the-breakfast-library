using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBreakfastLibrary.Models;
using Microsoft.EntityFrameworkCore;
using TheBreakfastLibrary.Services.Exceptions;

namespace TheBreakfastLibrary.Services
{
    public class SellerService
    {
        private readonly TheBreakfastLibraryContext _context;

        public SellerService(TheBreakfastLibraryContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller sel)
        {
            _context.Add(sel);
            await _context.SaveChangesAsync();
        }
        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(sel => sel.Department).FirstOrDefaultAsync(sel => sel.Id == id); //eager loading
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateException e)
            {
                throw new IntegrityExceptions(e.Message);
            }

        }

        public async Task UpdateAsync(Seller obj)
        {
            if (!await _context.Seller.AnyAsync(x => x.Id == obj.Id))
            {
                throw new NotFoundException("ID not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException exception)
            {
                throw new DbConcurrencyException(exception.Message);
            }
        }
    }
}
