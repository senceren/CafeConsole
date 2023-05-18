using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole.Data.Classes
{
    public class SiparisDetay
    {
        public string? UrunAdi{ get; set; }
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }
        public string? TutarTL { get; }

        public decimal Tutar()
        {
            return 0;
        }
    }
}
