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
    public partial class SiteSakiniEkle : Form
    {
        public SiteSakiniEkle()
        {
            InitializeComponent();
        }

        Golpinar_Sitesi_Entities entity = new Golpinar_Sitesi_Entities();

        private void button1_Click(object sender, EventArgs e)
        {
            var yeni_sakin = new Site_Sakinleri();
            yeni_sakin.ad_soyad = textBox1.Text;
            yeni_sakin.telefon = textBox2.Text;
            entity.Site_Sakinleri.Add(yeni_sakin);
            if(entity.SaveChanges() > 0)
            {
                MessageBox.Show("Yeni site sakini eklendi.");
                this.Close();
            }
        }
    }
}
