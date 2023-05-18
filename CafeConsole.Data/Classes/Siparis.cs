using CafeConsole.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole.Data.Classes
{
    public class Siparis
    {
        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set; }
        public decimal OdenenTutar { get; set; }
        public DateTime AcilisZamani { get; set; } = DateTime.Now;
        public DateTime? KapanisZamani { get; set; }

        public List<SiparisDetay> SiparisDetaylar { get; set; } = new();

        public string? ToplamTutarTL { get; set; }

        public decimal ToplamTutar()
        {
            return 0;
        }
    }
}
