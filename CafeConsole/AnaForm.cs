﻿using CafeConsole.Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeConsole
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            VerileriYukle();
            MasalariYükle();
        }

        private void VerileriYukle()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonSerializer.Deserialize<KafeVeri>(json)!;


            }
            catch (Exception)
            {
                OrnekUrunleriYukle();
            }
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 20m });
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 15m });
        }

        private void MasalariYükle()
        {
            for (int i = 0; i < db.MasaAdet; i++)
            {
                var lvi = new ListViewItem($"Masa {i + 1}");
                lvi.Tag = i + 1;  // Tag - etiket, burda değer saklayabiliriz.
                lvi.ImageKey = db.AktifSiparisler.Any(x => x.MasaNo == i + 1) ? "dolu" : "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            var lviTiklanan = lvwMasalar.SelectedItems[0];
            int masaNo = (int)lviTiklanan.Tag;
            //bu masada şuan oturan var mı ?
            var siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);  // aktif siparişler içinde bu masa no var mı?

            if (siparis == null)  // o masaya daha önce oturulmadıysa
            {
                lviTiklanan.ImageKey = "dolu"; // masanın rengini boya
                siparis = new Siparis() { MasaNo = masaNo };  //siparis oluştur
                db.AktifSiparisler.Add(siparis);  //aktif siparislere ekle 
            }

            var frmSiparis = new SiparisForm(db, siparis);
            frmSiparis.MasaTasindi += FrmSiparis_MasaTasindi;
            frmSiparis.ShowDialog();

            if (siparis.Durum != Data.Enums.SiparisDurum.Aktif)
            {
                lviTiklanan.ImageKey = "bos";
            }
        }

        private void FrmSiparis_MasaTasindi(object? sender, MasaTasindiEventArgs e)
        {
            foreach(ListViewItem item in lvwMasalar.Items)
            {
                int masaNo = (int)item.Tag;
                if (masaNo == e.EskiMasaNo)
                {
                    item.Selected = false;
                    item.ImageKey = "bos";
                }
                if (masaNo == e.YeniMasaNo)
                {
                    item.ImageKey = "dolu";
                    item.Selected = true;
                }
            }

        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {

            new Geçmiş_Siparişler(db).ShowDialog();

        }

        private void tsmiÜrünler_Click(object sender, EventArgs e)
        {
            new Ürünler(db).ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            string json = JsonSerializer.Serialize(db);
            File.WriteAllText("veri.json", json);
        }

       
    }
}
