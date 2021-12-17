using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYSProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=proje; user ID=postgres;  password=12345");
        private void listbtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from arac order by arac_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void cksbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where arac_markasi like'"+ txtAmrk.Text+"%' order by arac_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into arac(arac_markasi,arac_modeli,sefer_sayisi,personel_id) values(@p1,@p2,0,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", txtAmrk.Text);
            komut1.Parameters.AddWithValue("@p2", txtAmdl.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtAshbid.Text));
            komut1.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Araç Eklendi");
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from arac where arac_id=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtAid.Text));
            komut1.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Araç Silindi");
        }
        // UPDATE arac SET arac_markasi = @p1, arac_modeli = @p2, personel_id=@p3
        //WHERE arac_id= '@p4;
        private void gncbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("UPDATE arac SET arac_markasi = @p1, arac_modeli = @p2, personel_id=@p3 WHERE arac_id= @p4;", baglanti);
            komut1.Parameters.AddWithValue("@p1", txtAmrk.Text);
            komut1.Parameters.AddWithValue("@p2", txtAmdl.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtAshbid.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(txtAid.Text));
            komut1.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Araç Güncellendi");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM personel.personel INNER JOIN personel.arac_sahibi ON personel.personel_id = arac_sahibi.personel_id order by personel.personel_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAshbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("select AracSahibiEkle(@p1,@p2,@p3,@p4,@p5,0)", baglanti);
            komut1.Parameters.AddWithValue("@p1", txtad.Text);
            komut1.Parameters.AddWithValue("@p2", txtsyad.Text);
            komut1.Parameters.AddWithValue("@p3", txttel.Text);
            komut1.Parameters.AddWithValue("@p4", txtprsnltp.Text);
            komut1.Parameters.AddWithValue("@p5", int.Parse(txtsbid.Text));
            komut1.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Kişi Eklendi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("delete from personel.personel where personel_id=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtid.Text));
            komut1.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Personel Silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("UPDATE personel.personel SET personel_adi = @p1, personel_soyadi = @p2, tel_no=@p3, sube_id=@p5 WHERE personel_id= @p4;", baglanti);
            komut1.Parameters.AddWithValue("@p1", txtad.Text);
            komut1.Parameters.AddWithValue("@p2", txtsyad.Text);
            komut1.Parameters.AddWithValue("@p3", txttel.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(txtid.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(txtsbid.Text));
            komut1.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Personel Güncellendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM personel.personel INNER JOIN personel.arac_sahibi ON personel.personel_id = arac_sahibi.personel_id where personel_adi like'" + txtad.Text + "%' order by personel.personel_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            //string sorgu = "select * from arac where personel_adi like'%" + txtad.Text + "%' order by personel_id";
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
