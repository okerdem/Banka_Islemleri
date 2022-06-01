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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        Baglanti bal = new Baglanti();
        Random r = new Random();
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLKISILER(ADSOYAD,TC,TEL,HESAPNO,SIFRE) values(@ad,@tc,@tel,@hno,@s)", bal.con());
            komut1.Parameters.AddWithValue("@ad", textBoxKADS.Text);
            komut1.Parameters.AddWithValue("@tc", textBoxKTCNO.Text);
            komut1.Parameters.AddWithValue("@tel", maskedTextBoxKTELNO.Text);
            komut1.Parameters.AddWithValue("@hno", maskedTextBoxKHNO.Text);
            komut1.Parameters.AddWithValue("@s", textBoxKSifre.Text);

            SqlCommand komut2 = new SqlCommand("insert into tblhesap(HESAPNO,BAKIYE) values(@h,@b)", bal.con());
            komut2.Parameters.AddWithValue("@h", maskedTextBoxKHNO.Text);
            komut2.Parameters.AddWithValue("@b", "0.000");

            komut2.ExecuteNonQuery();
            komut1.ExecuteNonQuery();

            bal.con().Close();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            int iHNo = r.Next(100000, 1000000);
            maskedTextBoxKHNO.Text = iHNo.ToString();
        }
    }
}
