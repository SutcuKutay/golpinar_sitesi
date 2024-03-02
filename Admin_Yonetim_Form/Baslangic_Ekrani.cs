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
    public partial class Baslangic_Ekrani : Form
    {
        public Baslangic_Ekrani()
        {
            InitializeComponent();
        }

        Golpinar_Sitesi_Entities entity = new Golpinar_Sitesi_Entities();

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar[] kullanicilar = entity.Kullanicilars.ToArray();

            foreach (Kullanicilar kullanici in kullanicilar)
            {
                if(txtKullaniciAdi.Text == "")
                {
                    MessageBox.Show("Lütfen bir kullanıcı adı girin.");
                }
                else
                {
                    if (txtKullaniciAdi.Text.Trim() == kullanici.kullanici_adi)
                    {
                        if (txtSifre.Text.Trim() == kullanici.sifre)
                        {
                            MessageBox.Show("Giriş başarılı!");
                            Ana_Ekran ana_ekran = new Ana_Ekran();
                            this.Hide();
                            ana_ekran.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Şifre yanlış!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı yanlış!");
                    }
                }
            }
        }
    }
}
