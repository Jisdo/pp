using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TokoMotor.Models
{
    public class Motor
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Merek { get; set; }
        public decimal Harga { get; set; }
        
        public int TransaksiId { get; set; }
        public virtual Transaksi Transaksi { get; set; }
    }
}