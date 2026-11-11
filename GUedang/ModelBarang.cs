using System;
using System.Collections.Generic;
using System.Text;

namespace GUedang
{
    public class ModelBarang
    {
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Kategori { get; set; }
        public decimal Stok { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }
    }
}
