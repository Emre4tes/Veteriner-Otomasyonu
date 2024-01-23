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

namespace FrmGiris
{
    public partial class FrmAnaekran : Form
    {
        SqlBaglantisi baglan = null;
        public FrmAnaekran()
        {
            baglan = new SqlBaglantisi();
            InitializeComponent();
            updateTable();
        }


        private void updateTable()
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = baglan.baglanti;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM ATbl_Randevu_Paneli";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }

        private void FrmAnaekran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTedaviForm_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnMuayeneForm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null ||
                dataGridView1.CurrentCell.Value == null ||
                dataGridView1.CurrentCell.RowIndex == -1) return;
            var id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            new FrmMuayene(Convert.ToInt32(id)).Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null ||
                dataGridView1.CurrentCell.Value == null ||
                e.RowIndex == -1) return;
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            SqlCommand komut = new SqlCommand("Select * From ATbl_Randevu_Paneli Where Id=@p1", baglan.baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                TxtSahipAd.Text = dr.GetString(1);
                TxtSahipSoyad.Text = dr.GetString(2);
                MskTcNo.Text = dr.GetString(3);
                MskTelNo.Text = dr.GetString(4);
                TxtPetAd.Text = dr.GetString(5);
                CmbCins.Text = dr.GetString(6);
                TxtRenk.Text = dr.GetString(7);
                MskDogumTarih.Text = dr.GetString(8);
                MskMikrocip.Text = dr.GetString(9);
                string cinsiyet = dr.GetString(10);
                MskRandevuTarihi.Text = dr.GetString(11);
                RtxtAdres.Text = dr.GetString(12);
                if(cinsiyet == "Erkek")
                {
                    RbtnErkek.Checked = true;
                } else if(cinsiyet == "Dişi")
                {
                    RbtnDisi.Checked = true;
                }
                else
                {
                    RbtnKisir.Checked = true;
                }
            }
            dr.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
     
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null ||
               dataGridView1.CurrentCell.Value == null ||
               dataGridView1.CurrentCell.RowIndex == -1) return;
            var id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;

            var cinsiyet = this.groupBox2.Controls.OfType<RadioButton>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text).First();
            SqlCommand update = new SqlCommand("UPDATE ATbl_Randevu_Paneli SET Ad=@p1, Soyad=@p2, TcNo=@p3, TelNo=@p4, PetAd=@p5, Cins=@p6, Renk=@p7, DogumTarihi=@p8, MikrochipNo=@p9, Cinsiyet=@p10, RandevuTarihi=@p11, Adres=@p12", baglan.baglanti);
            update.Parameters.AddWithValue("@p1", TxtSahipAd.Text);
            update.Parameters.AddWithValue("@p2", TxtSahipSoyad.Text);
            update.Parameters.AddWithValue("@p3", MskTcNo.Text);
            update.Parameters.AddWithValue("@p4", MskTelNo.Text);
            update.Parameters.AddWithValue("@p5", TxtPetAd.Text);
            update.Parameters.AddWithValue("@p6", CmbCins.Text);
            update.Parameters.AddWithValue("@p7", TxtRenk.Text);
            update.Parameters.AddWithValue("@p8", MskDogumTarih.Text);
            update.Parameters.AddWithValue("@p9", MskMikrocip.Text);
            update.Parameters.AddWithValue("@p10", cinsiyet);
            update.Parameters.AddWithValue("@p11", MskRandevuTarihi.Text);
            update.Parameters.AddWithValue("@p12", RtxtAdres.Text);
            update.ExecuteNonQuery();

            updateTable();
            MessageBox.Show("Randevu Başarılı Bir Şeklide Güncellendi!", "Başarılı!");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var cinsiyet = this.groupBox2.Controls.OfType<RadioButton>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text).First();
            SqlCommand komut = new SqlCommand("INSERT INTO ATbl_Randevu_Paneli (Ad, Soyad, TcNo, TelNo, PetAd, Cins, Renk, DogumTarihi, MikrochipNo, Cinsiyet, RandevuTarihi, Adres) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12)", baglan.baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSahipAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSahipSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTcNo.Text);
            komut.Parameters.AddWithValue("@p4", MskTelNo.Text);
            komut.Parameters.AddWithValue("@p5", TxtPetAd.Text);
            komut.Parameters.AddWithValue("@p6", CmbCins.Text);
            komut.Parameters.AddWithValue("@p7", TxtRenk.Text);
            komut.Parameters.AddWithValue("@p8", MskDogumTarih.Text);
            komut.Parameters.AddWithValue("@p9", MskMikrocip.Text);
            komut.Parameters.AddWithValue("@p10", cinsiyet);
            komut.Parameters.AddWithValue("@p11", MskRandevuTarihi.Text);
            komut.Parameters.AddWithValue("@p12", RtxtAdres.Text);
            komut.ExecuteNonQuery();

            updateTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null ||
                            dataGridView1.CurrentCell.Value == null ||
                            dataGridView1.CurrentCell.RowIndex == -1) return;
            var id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;

            SqlCommand delete = new SqlCommand("DELETE FROM Tbl_ATbl_RandevuPaneli WHERE HastaId = @p1");
            delete.Parameters.AddWithValue("@p1", id);            
            delete.ExecuteNonQuery();

            updateTable();
        }
    }
}
