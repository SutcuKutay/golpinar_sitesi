using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Yonetim_Form
{
    public partial class EvEkleForm : Form
    {
        public EvEkleForm()
        {
            InitializeComponent();
        }

        Golpinar_Sitesi_Entities entity = new Golpinar_Sitesi_Entities();

        private void button2_Click(object sender, EventArgs e)
        {
            SiteSakiniEkle form = new SiteSakiniEkle();
            form.ShowDialog();
            cmbEvSahibi.Items.Clear();
            foreach (var sakin in entity.Site_Sakinleri.ToList())
            {
                cmbEvSahibi.Items.Add(sakin.ad_soyad);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEvSahibi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ev Sahibi seçiniz.");
            }
            else if(txtEvNum.Text == "")
            {
                MessageBox.Show("Lütfen Ev Numarası giriniz.");
            }
            else
            {
                var yeni_ev = new Evler();
                yeni_ev.numara = byte.Parse(txtEvNum.Text);
                var sakin = entity.Site_Sakinleri.Where(x => x.ad_soyad == cmbEvSahibi.Text).FirstOrDefault();
                yeni_ev.sahibi = sakin.id;
                entity.Evlers.Add(yeni_ev);
                if(entity.SaveChanges() > 0)
                {
                    MessageBox.Show("Yeni Ev Eklendi.");
                }
            }
        }

        private void EvEkleForm_Load(object sender, EventArgs e)
        {
            foreach(var sakin in entity.Site_Sakinleri.ToList())
            {
                cmbEvSahibi.Items.Add(sakin.ad_soyad);
            }
        }
    }
}
