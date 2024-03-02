using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Yonetim_Form
{
    public partial class Ana_Ekran : Form
    {
        public Ana_Ekran()
        {
            InitializeComponent();
        }

        Golpinar_Sitesi_Entities entity = new Golpinar_Sitesi_Entities();

        //Evler
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            var evler = entity.Evlers.Select(ev => new {ev.numara, ev.sahibi, ev.kiracı}).ToArray();
            dataGridView1.DataSource = evler;
            dataGridView1.Show();
        }

        //Site Sakinleri
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            var site_sakinleri = entity.Site_Sakinleri.Select(site_sakini => new { site_sakini.ad_soyad, site_sakini.telefon }).ToArray();
            dataGridView1.DataSource = site_sakinleri;
            dataGridView1.Show();
        }

        //Aidatlar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            var aidatlar = entity.Aidatlars.Join(entity.Evlers, aidat => aidat.ev, ev => ev.id, (aidat, ev) => new { Ev_Numarası = ev.numara, aidat.odenmemis_aidat, aidat.odeme_tarihi}).ToArray();
            dataGridView1.DataSource = aidatlar;
            dataGridView1.Show();
        }
    }
}
