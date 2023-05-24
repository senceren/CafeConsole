using CafeConsole.Data.Classes;
using CafeConsole.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeConsole
{
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        private readonly BindingList<SiparisDetay> _siparisDetaylar;

        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            _db = db;
            _siparis = siparis;
            _siparisDetaylar = new BindingList<SiparisDetay>(_siparis.SiparisDetaylar); // binding liste bir şey eklenirse güncelliği korur.
            _siparisDetaylar.ListChanged += _siparisDetaylar_ListChanged;
            InitializeComponent();
            dgvDetaylar.AutoGenerateColumns = false;
            dgvDetaylar.DataSource = _siparisDetaylar; // siparislere bir şey eklenirse bağlı oldugu her yeri günceller. Hem data grid viewi günceller. Hem de listeyi günceller.
            Guncelle();

        }

        private void _siparisDetaylar_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            this.Text = $"Masa {_siparis.MasaNo} (Açılış: {_siparis.AcilisZamani})";
            this.lblMasaNo.Text = _siparis.MasaNo.ToString("00");
            this.lblÖdemeTutar.Text = _siparis.ToplamTutarTL.ToString();
            cmbUrunAd.DataSource = _db.Urunler;

        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Urun urun = (Urun)cmbUrunAd.SelectedItem;
            if (urun == null) return;

            //secilen ürün adıyla eşlesen bir detay var mı?
            var siparisDetay = _siparisDetaylar.FirstOrDefault(x => x.UrunAd == urun.UrunAd);

            if (siparisDetay == null)
            {
                siparisDetay = new SiparisDetay()
                {
                    UrunAd = urun.UrunAd,
                    BirimFiyat = urun.BirimFiyat,
                    Adet = (int)nudAdet.Value
                };
                _siparisDetaylar.Add(siparisDetay);
            }
            else
                siparisDetay.Adet += (int)nudAdet.Value;

            _siparisDetaylar.ResetBindings(); // bağları tekrar kur(böylelikle değişiklik oldugu haberi yayılacak



        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnÖdemeAl_Click(object sender, EventArgs e)
        {
            MasayiKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());
        }


        private void btnİptal_Click(object sender, EventArgs e)
        {
            MasayiKapat(SiparisDurum.Iptal, 0);
        }
        private void MasayiKapat(SiparisDurum yeniDurum, decimal odenenTutar)
        {
            _siparis.Durum = yeniDurum;
            _siparis.OdenenTutar = odenenTutar;
            _siparis.KapanisZamani = DateTime.Now;
            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
            Close();
        }
    }
}
