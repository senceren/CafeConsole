using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole.Data.Classes
{
    public class KafeVeri
    {
        public int MasaAdet { get; set; } = 20;
        public List<Urun> Urunler { get; set; } = new();
        public List<Siparis> AktifSiparisler { get; set; } = new();

        public List<Siparis> GecmisSiparisler { get; set; } = new();
    }
}
