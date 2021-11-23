using System;
using System.Collections.Generic;

namespace PesanMakan.Models
{
    public partial class Pesanan
    {
        public int IdPesanan { get; set; }
        public int? IdMenu { get; set; }
        public int? Jumlah { get; set; }
        public int? TotalHarga { get; set; }

        public Menu IdMenuNavigation { get; set; }
    }
}
