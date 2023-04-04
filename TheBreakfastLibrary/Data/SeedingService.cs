using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBreakfastLibrary.Models;
using TheBreakfastLibrary.Models.Enums;

namespace TheBreakfastLibrary.Data
{
    public class SeedingService
    {
        private TheBreakfastLibraryContext _context;

        public SeedingService(TheBreakfastLibraryContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Romance");
            Department d2 = new Department(2, "Science");
            Department d3 = new Department(3, "History");
            Department d4 = new Department(4, "Business");
            Department d5 = new Department(5, "Technology");

            Seller s1 = new Seller(1, "Maria", "maria@thebreakfastlibrary.com", 1320, new DateTime(1995, 7, 15), d1);
            Seller s2 = new Seller(2, "Pedro", "pedro@thebreakfastlibrary.com", 1600, new DateTime(1997, 3, 25), d2);
            Seller s3 = new Seller(3, "João", "joao@thebreakfastlibrary.com", 1520, new DateTime(2001, 4, 12), d3);
            Seller s4 = new Seller(4, "Giovana", "giovana@thebreakfastlibrary.com", 2500, new DateTime(1999, 7, 18), d4);
            Seller s5 = new Seller(5, "Gabriela", "gabriela@thebreakfastlibrary.com", 3415, new DateTime(1990, 10, 21), d5);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2023, 2, 10), 250, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2023, 2, 10), 250, SaleStatus.Canceled, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2023, 2, 10), 250, SaleStatus.Pending, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2023, 2, 10), 250, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2023, 2, 10), 250, SaleStatus.Billed, s1);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2023, 2, 11), 250, SaleStatus.Billed, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2023, 2, 11), 250, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2023, 2, 11), 250, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2023, 2, 11), 250, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2023, 2, 12), 250, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2023, 2, 12), 250, SaleStatus.Billed, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2023, 2, 12), 250, SaleStatus.Billed, s5);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2023, 2, 13), 250, SaleStatus.Pending, s5);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2023, 2, 13), 250, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2023, 2, 15), 250, SaleStatus.Billed, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2023, 2, 15), 250, SaleStatus.Canceled, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2023, 2, 16), 250, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2023, 2, 16), 250, SaleStatus.Billed, s2);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2023, 2, 17), 250, SaleStatus.Billed, s3);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2023, 2, 18), 250, SaleStatus.Billed, s1);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2023, 2, 18), 250, SaleStatus.Canceled, s5);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2023, 2, 18), 250, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2023, 2, 18), 250, SaleStatus.Billed, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2023, 2, 19), 250, SaleStatus.Pending, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2023, 2, 20), 250, SaleStatus.Pending, s4);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25);
            _context.SaveChanges();
        }
    }
}
