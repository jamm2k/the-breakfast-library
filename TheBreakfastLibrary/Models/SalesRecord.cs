﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using TheBreakfastLibrary.Models.Enums;


namespace TheBreakfastLibrary.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "U$ {0:F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
