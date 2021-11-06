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
        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Harga { get; set; }
    }
}