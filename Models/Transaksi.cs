using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoMotor.Models
{
    public class Transaksi
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Jumlah { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<Motor> Motors { get; set; }
    }
}