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

namespace iliskiliveritabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbHareket;Integrated Security=True;");


        void procedure()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Proje6", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void listele()
        {
            // ürünleri çekme
            SqlCommand komut = new SqlCommand("Select * From TBLURUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmburun.ValueMember = "ID";
            cmburun.DisplayMember = "AD";
            cmburun.DataSource = dt;

            //personelleri çekme
            SqlCommand komut1 = new SqlCommand("Select * From TBLPERSONELLER", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbpersonel.ValueMember = "ID";
            cmbpersonel.DisplayMember = "AD";
            cmbpersonel.DataSource = dt1;

            //müşterileri çekme
            SqlCommand komut2 = new SqlCommand("Select * From TBLMUSTERILER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbmusteri.ValueMember = "ID";
            cmbmusteri.DisplayMember = "ADSOYAD";
            cmbmusteri.DataSource = dt2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            procedure();
            listele();


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLHAREKETLER  (URUN,MUSTERI,PERSONEL,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmburun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbmusteri.SelectedValue);
            komut.Parameters.AddWithValue("@p3", cmbpersonel.SelectedValue);
            komut.Parameters.AddWithValue("@p4", txtfıyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtfıyat.Text = "";
            procedure();
            MessageBox.Show("Satışınız Gerçekleşti");


        }

        private void btnmusterigiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERILER  (ADSOYAD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtmusteriadsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            txtmusteriadsoyad.Text = "";
            MessageBox.Show("Müşteri Eklendi");
        }

        private void txturungiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER  (AD,STOK,ALISFIYAT,SATISFIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txturunad.Text);
            komut.Parameters.AddWithValue("@p2", txturunstok.Text);
            komut.Parameters.AddWithValue("@p3", txturunalis.Text);
            komut.Parameters.AddWithValue("@p4", txturunsatis.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            txturunad.Text = "";
            txturunstok.Text = "";
            txturunalis.Text = "";
            txturunsatis.Text = "";
            MessageBox.Show("Ürün Eklendi");
        }
    }
}
