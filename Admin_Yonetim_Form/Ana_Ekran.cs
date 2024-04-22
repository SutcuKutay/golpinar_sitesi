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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            btnSakinEkle.Hide();
            dataGridView1.Hide();
            var evler = from ev in entity.Evlers
                        join site_sakini in entity.Site_Sakinleri on ev.sahibi equals site_sakini.id
                        join kiraci in entity.Kiracilars on ev.kiracı equals kiraci.id into kiracilar
                        from kiraci in kiracilar.DefaultIfEmpty()
                        select new
                        {
                            EvNumarası = ev.numara,
                            EvSahibi = site_sakini.ad_soyad,
                            Kiracı = kiraci.ad_soyad
                        };
            dataGridView1.DataSource = evler.ToList();
            dataGridView1.Show();

            btnEvEkle.Show();
        }

        //Site Sakinleri
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnEvEkle.Hide();
            dataGridView1.Hide();
            var site_sakinleri = entity.Site_Sakinleri.Select(site_sakini => new { site_sakini.ad_soyad, site_sakini.telefon }).ToArray();
            dataGridView1.DataSource = site_sakinleri;
            dataGridView1.Show();

            btnSakinEkle.Show();
        }

        //Aidatlar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btnSakinEkle.Hide();
            btnEvEkle.Hide();
            dataGridView1.Hide();
            var aidatlar = entity.Aidatlars.Join(entity.Evlers, aidat => aidat.ev, ev => ev.id, (aidat, ev) => new { Ev_Numarası = ev.numara, aidat.odenmemis_aidat, aidat.odeme_tarihi}).ToArray();
            dataGridView1.DataSource = aidatlar;
            dataGridView1.Show();
        }

        private void Ana_Ekran_Load(object sender, EventArgs e)
        {

        }

        private void btnEvEkle_Click(object sender, EventArgs e)
        {
            EvEkleForm form = new EvEkleForm();
            form.ShowDialog();
            var evler = from ev in entity.Evlers
                        join site_sakini in entity.Site_Sakinleri on ev.sahibi equals site_sakini.id
                        join kiraci in entity.Kiracilars on ev.kiracı equals kiraci.id into kiracilar
                        from kiraci in kiracilar.DefaultIfEmpty()
                        select new
                        {
                            EvNumarası = ev.numara,
                            EvSahibi = site_sakini.ad_soyad,
                            Kiracı = kiraci.ad_soyad
                        };
            dataGridView1.DataSource = evler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiteSakiniEkle sakinEkleForm = new SiteSakiniEkle();
            sakinEkleForm.ShowDialog();
            var site_sakinleri = entity.Site_Sakinleri.Select(site_sakini => new { site_sakini.ad_soyad, site_sakini.telefon }).ToArray();
            dataGridView1.DataSource = site_sakinleri;
        }
    }
}
