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
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }

        public string HNo = "";
        Baglanti b = new Baglanti();

        private void Islemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Islemler_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select adsoyad,tel,tc from TBLKISILER where hesapno=" + HNo, b.con());
            SqlDataReader dr = komut1.ExecuteReader();

            while (dr.Read())
            {
                labelAS.Text = dr[0].ToString();
                labelTN.Text = dr[1].ToString();
                labelTCN.Text = dr[2].ToString();
            }
            labelHN.Text = HNo;

            b.con().Close();
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into tblhareket(GONDEREN,ALICI,TUTAR) values (@g,@a,@t)", b.con());
            komut1.Parameters.AddWithValue("@g", HNo);
            komut1.Parameters.AddWithValue("@a", maskedTextBoxHHNO.Text);
            komut1.Parameters.AddWithValue("@t", textBoxTutar.Text);

            double iTutar = 0;
            SqlCommand komut3 = new SqlCommand("select BAKIYE from tblhesap where hesapno=" + maskedTextBoxHHNO.Text,b.con());
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                iTutar = Convert.ToDouble(dr[0].ToString());
            }
            iTutar += Convert.ToDouble(textBoxTutar.Text);

            SqlCommand komut2 = new SqlCommand("update tblhesap set BAKIYE=@b where hesapno=@h", b.con());
            komut2.Parameters.AddWithValue("@h", maskedTextBoxHHNO.Text);
            komut2.Parameters.AddWithValue("@b", iTutar);

            komut1.ExecuteNonQuery();
            komut2.ExecuteNonQuery();

            b.con().Close();
        }
    }
}
