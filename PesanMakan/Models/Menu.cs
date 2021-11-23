using System;
using System.Collections.Generic;

namespace PesanMakan.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Pesanan = new HashSet<Pesanan>();
        }

        public int IdMenu { get; set; }
        public string NamaMenu { get; set; }
        public int? HargaMenu { get; set; }

        public ICollection<Pesanan> Pesanan { get; set; }
    }
}
