using SaleWebMVC.Models;
using SaleWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMVC.Data
{
    public class SeedingService
    {
        private SaleWebMVCContext _context;

        public SeedingService(SaleWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Saller.Any() || _context.SalesRecords.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Saller s1 = new Saller(1, "Bob Brown", "bob@gmail.com", 1000, new DateTime(1998, 4, 21), d1);
            Saller s2 = new Saller(2, "Maria Green", "maria@gmail.com", 3500.0, new DateTime(1979, 12, 31), d2);
            Saller s3 = new Saller(3, "Alex Grey", "alex@gmail.com", 2200.0, new DateTime(1988, 1, 15), d1);
            Saller s4 = new Saller(4, "Martha Red", "martha@gmail.com", 3000.0, new DateTime(1993, 11, 30), d4);
            Saller s5 = new Saller(5, "Donald Blue", "donald@gmail.com", 4000.0, new DateTime(2000, 1, 9), d3);
            Saller s6 = new Saller(6, "Alex Pink", "bob@gmail.com", 3000.0, new DateTime(1997, 3, 4), d2);
            Saller s7 = new Saller(7, "Marcelo Fiats", "marcelo.fiats@gmail.com", 3000.0, new DateTime(1987, 2, 19), d1);
            Saller s8 = new Saller(6, "Fernando Baioco", "fernando@gmail.com", 2000.0, new DateTime(2000, 8, 12), d2);
            Saller s9 = new Saller(6, "Daniel Vendan", "daniel@gmail.com", 5000.0, new DateTime(1995, 3,18), d1);
            Saller s10 = new Saller(6, "Verônica Fiats", "veronica@gmail.com", 4000.0, new DateTime(1991, 12, 13), d3);
            Saller s11 = new Saller(6, "Madalena", "madalena@gmail.com", 2500.0, new DateTime(1960, 7, 20), d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r31 = new SalesRecord(31, new DateTime(2018, 11, 12), 22000.0, SaleStatus.Billed, s7);
            SalesRecord r32 = new SalesRecord(32, new DateTime(2018, 11, 13), 9000.0, SaleStatus.Billed, s7);
            SalesRecord r33 = new SalesRecord(33, new DateTime(2018, 11, 24), 4000.0, SaleStatus.Billed, s8);
            SalesRecord r34 = new SalesRecord(34, new DateTime(2018, 11, 19), 11000.0, SaleStatus.Canceled, s9);
            SalesRecord r35 = new SalesRecord(35, new DateTime(2018, 11, 12), 8000.0, SaleStatus.Billed, s11);
            SalesRecord r36 = new SalesRecord(36, new DateTime(2018, 11, 31), 7000.0, SaleStatus.Billed, s11);
            SalesRecord r37 = new SalesRecord(37, new DateTime(2018, 11, 6), 5000.0, SaleStatus.Billed, s11);
            SalesRecord r38 = new SalesRecord(38, new DateTime(2018, 11, 13), 9000.0, SaleStatus.Pending, s10);
            SalesRecord r39 = new SalesRecord(39, new DateTime(2018, 11, 7), 4000.0, SaleStatus.Billed, s10);
            SalesRecord r40 = new SalesRecord(40, new DateTime(2018, 11, 23), 12000.0, SaleStatus.Billed, s10);
            SalesRecord r41 = new SalesRecord(41, new DateTime(2018, 11, 12), 5000.0, SaleStatus.Billed, s9);


            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Saller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);

            _context.SalesRecords.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41
            );

            _context.SaveChanges();

        }
    }
}
