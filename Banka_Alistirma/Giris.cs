using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banka_Alistirma
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        Baglanti b = new Baglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl ko = new KayitOl();
            ko.Show();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from TBLKISILER where HESAPNO=@hno and SIFRE=@s", b.con());
            komut1.Parameters.AddWithValue("@hno", maskedTextBoxHNo.Text);
            komut1.Parameters.AddWithValue("@s", textBoxSifre.Text);
            SqlDataReader dr = komut1.ExecuteReader();

            if (dr.Read())
            {
                Islemler i = new Islemler();
                i.HNo = maskedTextBoxHNo.Text;
                i.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            b.con().Close();
        }
    }
}
