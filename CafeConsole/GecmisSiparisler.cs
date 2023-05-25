using CafeConsole.Data.Classes;
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
    public partial class Geçmiş_Siparişler : Form
    {
        private readonly KafeVeri _db;
        public Geçmiş_Siparişler(KafeVeri db)
        {
            _db = db;
            InitializeComponent();
            dgvSiparisler.DataSource = _db.GecmisSiparisler;
        }


        private void dgvSiparisler_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count == 0)
            {
                dgvSiparisDetaylari.DataSource = null;
            }
            else
            {
                var seciliSatir = dgvSiparisler.SelectedRows[0];
                var siparis = (Siparis)seciliSatir.DataBoundItem;
                dgvSiparisDetaylari.DataSource = siparis.SiparisDetaylar;

            }

        }
    }
}
