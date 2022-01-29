using KisiselBilgiler.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselBilgiler
{
    public partial class Form1 : Form
    {
        DataModel dm = new DataModel();
        List<Kisi> Kisiler = new List<Kisi>();
        bool Bos_Alan=false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Sehir ve İlce 
            cb_Sehirler.ValueMember = "ID";
            cb_Sehirler.DisplayMember = "Sehir_Isim";
            List<Sehir> Sehirler = dm.SehirGetir();
            Sehirler.Insert(0, new Sehir() { ID = 0, Sehir_Isim = "Seçiniz:" });
            cb_Sehirler.DataSource = Sehirler;
            #endregion

            #region Universite
            cb_Universiteler.ValueMember = "ID";
            cb_Universiteler.DisplayMember = "Universite_Isim";
            List<Universite> Universiteler = dm.UniversiteGetir();
            Universiteler.Insert(0, new Universite() { ID = 0, Universite_Isim = "Seçiniz:" });
            cb_Universiteler.DataSource = Universiteler;

            #endregion


        }

        private void cb_Sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SehirID = Convert.ToInt32(cb_Sehirler.SelectedValue);
            if (SehirID != 0)
            {
                cb_Ilceler.ValueMember = "ID";
                cb_Ilceler.DisplayMember = "Ilce_Isim";
                List<Ilce> Ilceler = dm.IlceGetir(SehirID);
                cb_Ilceler.DataSource = Ilceler;
            }
            else
            {
                cb_Ilceler.Text = "Şehir Seçiniz";
            }
        }

        private void cb_Universiteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Uni_ID = Convert.ToInt32(cb_Universiteler.SelectedValue);
            if (Uni_ID != 0)
            {

                cb_Fakulteler.ValueMember = "ID";
                cb_Fakulteler.DisplayMember = "Fakulte_Isim";
                List<Fakulte> Fakulteler = dm.FakulteGetir(Uni_ID);
                Fakulteler.Insert(0, new Fakulte() { ID = 0.ToString(), Fakulte_Isim = "Seçiniz:" });
                cb_Fakulteler.DataSource = Fakulteler;
            }


        }

        private void cb_Fakulteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Uni_ID = Convert.ToInt32(cb_Universiteler.SelectedValue);
            int Fak_ID = Convert.ToInt32(cb_Fakulteler.SelectedValue);
            if (Uni_ID != 0 && Fak_ID != 0)
            {
                cb_Bolumler.ValueMember = "ID";
                cb_Bolumler.DisplayMember = "Isim";
                List<Bolum> Bolumler = dm.BolumGetir(Uni_ID, Fak_ID);
                Bolumler.Insert(0, new Bolum() { ID = 0, Isim = "Seçiniz:" });
                cb_Bolumler.DataSource = Bolumler;

            }
            else
            {
                cb_Fakulteler.Text = "Fakülte Seçiniz";
                cb_Bolumler.Text = "Bölüm Seçiniz";
            }
        }

        #region Keypres Methodları
        private void tb_Isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                if (e.KeyChar.Equals(' ') == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void tb_SoyIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                if (e.KeyChar.Equals(' ') == false)
                {
                    e.Handled = true;
                }
            }
        }
        #endregion

        private void tb_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void tb_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void tb_TC_Validating(object sender, CancelEventArgs e)
        {
            if (tb_TC.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
                tb_TC.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                bool durum = dm.TCKontrol(tb_TC.Text);
                if (durum == true)
                { tb_TC.ForeColor = System.Drawing.Color.Green; }
                else
                {
                    tb_TC.ForeColor = System.Drawing.Color.Red;

                }
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    
                    if (item.Text == "" || item.Text == "Seçiniz:" || item.Text == "Şehir Seçiniz")
                    {
                        ErrorProvider errorProvider1 = new ErrorProvider();
                        errorProvider1.SetError(item, "Bu alan boş bırakılamaz");
                        Bos_Alan = true;
                    }
                   
                    
                }
            }
            if (Bos_Alan==false)
            {
                Kisi k = new Kisi();
                k.Isim = tb_Isim.Text;
                k.SoyIsim = tb_SoyIsim.Text;
                k.Telefon = tb_Tel.Text;
                k.TC_No = tb_TC.Text;
                k.Sehir = cb_Sehirler.Text;
                k.Ilce = cb_Ilceler.Text;
                k.Adres = tb_Adres.Text;
                k.Universite = cb_Universiteler.Text;
                k.Fakulte = cb_Fakulteler.Text;
                k.Bolum = cb_Bolumler.Text;
                dm.KisiEkle(k);
                Kisiler.Add(k);
            }
            else
            {
                MessageBox.Show("Alanları doldurun!");
                Bos_Alan = false;
            }
           

        }
    }
}
