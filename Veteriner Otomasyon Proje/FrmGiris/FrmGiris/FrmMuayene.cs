using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FrmGiris
{
    public partial class FrmMuayene : Form
    {
        SqlBaglantisi baglan = null;
        int id = -1;
        public FrmMuayene(int id)
        {
            this.id = id;
            baglan = new SqlBaglantisi();
            InitializeComponent();
            readDatabase();
        }

        private void readDatabase()
        {
            SqlCommand komut = command("Select * From ATbl_Randevu_Paneli Where Id=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string ad = dr.GetString(1);
                string soyad = dr.GetString(2);
                string petad = dr.GetString(5);
                string tarih = dr.GetString(11);
                label18.Text = ad + " " + soyad;
                label13.Text = petad;
                label19.Text = tarih;
                // Güncellenecek labelları güncelle
            }
            dr.Close();
            // tüy deri okuma
            komut = command("SELECT * FROM Tbl_TuyDeri Where HastaId=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var tuyDeris = new List<int>();
            while (dr.Read())
            {
                tuyDeris.Add(dr.GetInt32(1));
            }
            dr.Close();
            var tuyDeriClass = new List<string>();
            foreach (int i in tuyDeris)
            {
                komut = command("SELECT * FROM Tbl_TuyDeriClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    tuyDeriClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var tuyDeriCheckboxes = this.GbTuyDeri.Controls.OfType<CheckBox>().ToList();
            foreach (string i in tuyDeriClass)
            {
                foreach (CheckBox checkBox in tuyDeriCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }
            //UrogenitalSistem okuma

            komut = command("SELECT * FROM Tbl_UrogenitalSistem Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var urogenitalSistems = new List<int>();
            while (dr.Read())
            {
                urogenitalSistems.Add(dr.GetInt32(1));
            }
            dr.Close();
            var urogenitalSistemClass = new List<string>();
            foreach (int i in urogenitalSistems)
            {
                komut = command("SELECT * FROM Tbl_UrogenitalSistemClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    urogenitalSistemClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var urogenitalSistemCheckboxes = this.GbUrogenitalSistem.Controls.OfType<CheckBox>().ToList();
            foreach (string i in urogenitalSistemClass)
            {
                foreach (CheckBox checkBox in urogenitalSistemCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Kulaklar okuma

            komut = command("SELECT * FROM Tbl_Kulaklar Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var kulaklars = new List<int>();
            while (dr.Read())
            {
                kulaklars.Add(dr.GetInt32(1));
            }
            dr.Close();
            var kulaklarClass = new List<string>();
            foreach (int i in kulaklars)
            {
                komut = command("SELECT * FROM Tbl_KulaklarClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    kulaklarClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var kulaklarCheckboxes = this.GbKulaklar.Controls.OfType<CheckBox>().ToList();
            foreach (string i in kulaklarClass)
            {
                foreach (CheckBox checkBox in kulaklarCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Kas İskelet okuma

            komut = command("SELECT * FROM Tbl_KasIskeleti Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var kasIskelets = new List<int>();
            while (dr.Read())
            {
                kasIskelets.Add(dr.GetInt32(1));
            }
            dr.Close();
            var kasIskeletClass = new List<string>();
            foreach (int i in kasIskelets)
            {
                komut = command("SELECT * FROM Tbl_KasIskeletiClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    kasIskeletClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var kasIskeletCheckboxes = this.GbKasIskelet.Controls.OfType<CheckBox>().ToList();
            foreach (string i in kasIskeletClass)
            {
                foreach (CheckBox checkBox in kasIskeletCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Kalp okuma

            komut = command("SELECT * FROM Tbl_Kalp Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var kalp = new List<int>();
            while (dr.Read())
            {
                kalp.Add(dr.GetInt32(1));
            }
            dr.Close();
            var kalpClass = new List<string>();
            foreach (int i in kalp)
            {
                komut = command("SELECT * FROM Tbl_KalpClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    kalpClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var kalpCheckboxes = this.GbKalp.Controls.OfType<CheckBox>().ToList();
            foreach (string i in kalpClass)
            {
                foreach (CheckBox checkBox in kalpCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Gözler okuma

            komut = command("SELECT * FROM Tbl_Gozler Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var gozler = new List<int>();
            while (dr.Read())
            {
                gozler.Add(dr.GetInt32(1));
            }
            dr.Close();
            var gozlerClass = new List<string>();
            foreach (int i in gozler)
            {
                komut = command("SELECT * FROM Tbl_GozlerClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    gozlerClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var gozlerCheckboxes = this.GbGozler.Controls.OfType<CheckBox>().ToList();
            foreach (string i in gozlerClass)
            {
                foreach (CheckBox checkBox in gozlerCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Gastroinstentinal okuma

            komut = command("SELECT * FROM Tbl_Gastroinstentinal Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var gastroinstentinals = new List<int>();
            while (dr.Read())
            {
                gastroinstentinals.Add(dr.GetInt32(1));
            }
            dr.Close();
            var gastroinstentinalClass = new List<string>();
            foreach (int i in gastroinstentinals)
            {
                komut = command("SELECT * FROM Tbl_GastroinstentinalClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    gastroinstentinalClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var gastroinstentinalCheckboxes = this.GbGastroinstentinal.Controls.OfType<CheckBox>().ToList();
            foreach (string i in gastroinstentinalClass)
            {
                foreach (CheckBox checkBox in gastroinstentinalCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Burun Boğaz okuma

            komut = command("SELECT * FROM Tbl_BurunveBogaz Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var burunBogazs = new List<int>();
            while (dr.Read())
            {
                burunBogazs.Add(dr.GetInt32(1));
            }
            dr.Close();
            var burunBogazClass = new List<string>();
            foreach (int i in burunBogazs)
            {
                komut = command("SELECT * FROM Tbl_BurunveBogazClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    burunBogazClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var burunBogazCheckboxes = this.GbBurunBogaz.Controls.OfType<CheckBox>().ToList();
            foreach (string i in burunBogazClass)
            {
                foreach (CheckBox checkBox in burunBogazCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Beslenme okuma

            komut = command("SELECT * FROM Tbl_Beslenme Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var beslenmes = new List<int>();
            while (dr.Read())
            {
                beslenmes.Add(dr.GetInt32(1));
            }
            dr.Close();
            var beslenmeClass = new List<string>();
            foreach (int i in beslenmes)
            {
                komut = command("SELECT * FROM Tbl_BeslenmeClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    beslenmeClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var beslenmeCheckboxes = this.GbBeslenme.Controls.OfType<CheckBox>().ToList();
            foreach (string i in beslenmeClass)
            {
                foreach (CheckBox checkBox in beslenmeCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Asilar

            komut = command("SELECT * FROM Tbl_Asilar Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var asilars = new List<int>();
            while (dr.Read())
            {
                asilars.Add(dr.GetInt32(1));
            }
            dr.Close();
            var asilarClass = new List<string>();
            foreach (int i in asilars)
            {
                komut = command("SELECT * FROM Tbl_AsilarClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    asilarClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var asilarCheckboxes = this.GbAsilar.Controls.OfType<CheckBox>().ToList();
            foreach (string i in asilarClass)
            {
                foreach (CheckBox checkBox in asilarCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Akciger okuma

            komut = command("SELECT * FROM Tbl_Akciger Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var akcigers = new List<int>();
            while (dr.Read())
            {
                akcigers.Add(dr.GetInt32(1));
            }
            dr.Close();
            var akcigerClass = new List<string>();
            foreach (int i in akcigers)
            {
                komut = command("SELECT * FROM Tbl_AkcigerClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    akcigerClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var akcigerCheckboxes = this.GbAkciger.Controls.OfType<CheckBox>().ToList();
            foreach (string i in akcigerClass)
            {
                foreach (CheckBox checkBox in akcigerCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Ağız Diş Dişeti okuma

            komut = command("SELECT * FROM Tbl_AgizDisDiseti Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var agizDisDisetis = new List<int>();
            while (dr.Read())
            {
                agizDisDisetis.Add(dr.GetInt32(1));
            }
            dr.Close();
            var agizDisDisetiClass = new List<string>();
            foreach (int i in agizDisDisetis)
            {
                komut = command("SELECT * FROM Tbl_AgizDisDisetiClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    agizDisDisetiClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var agizDisDisetiCheckboxes = this.GbAgizDisDiseti.Controls.OfType<CheckBox>().ToList();
            foreach (string i in agizDisDisetiClass)
            {
                foreach (CheckBox checkBox in agizDisDisetiCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Ağırlık okuma

            komut = command("SELECT * FROM Tbl_Agirlik Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var agirliks = new List<int>();
            while (dr.Read())
            {
                agirliks.Add(dr.GetInt32(1));
            }
            dr.Close();
            var agirlikClass = new List<string>();
            foreach (int i in agirliks)
            {
                komut = command("SELECT * FROM Tbl_AgirlikClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    agirlikClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var agirlikCheckboxes = this.GbAgirlik.Controls.OfType<CheckBox>().ToList();
            foreach (string i in agirlikClass)
            {
                foreach (CheckBox checkBox in agirlikCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            //Abdomen okuma

            komut = command("SELECT * FROM Tbl_Abdomen Where Hastaid=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            var abdomens = new List<int>();
            while (dr.Read())
            {
                abdomens.Add(dr.GetInt32(1));
            }
            dr.Close();
            var abdomenClass = new List<string>();
            foreach (int i in agirliks)
            {
                komut = command("SELECT * FROM Tbl_AbdomenClass Where Id=@p1");
                komut.Parameters.AddWithValue("@p1", i);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    abdomenClass.Add(dr.GetString(1));
                }
                dr.Close();
            }
            var abdomenCheckboxes = this.GbAbdomen.Controls.OfType<CheckBox>().ToList();
            foreach (string i in abdomenClass)
            {
                foreach (CheckBox checkBox in abdomenCheckboxes)
                {
                    if (checkBox.Text == i)
                    {
                        checkBox.Checked = true;
                        break;
                    }
                }
            }

            // Muayene teshis okuma
            komut = command("SELECT * FROM Tbl_MTeshis Where HastaId=@p1");
            komut.Parameters.AddWithValue("@p1", id);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                richTextBox1.Text = dr.GetString(1);
            }
            dr.Close();

        }

        private SqlCommand command(string command)
        {
            return new SqlCommand(command, baglan.baglanti);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var frm = this;
            Task.Factory.StartNew(async () =>
            {
                await Task.Run(() =>
                {
                    // Use Invoke to update UI controls on the main thread
                    frm.Invoke((MethodInvoker)delegate
                    {
                        frm.Enabled = false;
                    });

                    // Your other background thread logic here
                });
                // groupboxtan işaretli olanların isimlerini listeye alıyoruz
                var selectedTuyDeris = this.GbTuyDeri.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes = new List<int>();
                // seçilen checkboxları döngüye sokuyoruz
                foreach (String text in selectedTuyDeris)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_TuyDeriClass Where TuyDeri=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes.Add(dr.GetInt32(0));
                    }
                    dr.Close();

                }

                // HER BİRİ İÇİN TEKRAR YAP BURDAN
                SqlCommand delete = command("DELETE FROM Tbl_TuyDeri WHERE HastaId = @p1");
                delete.Parameters.AddWithValue("@p1", id);
                delete.ExecuteNonQuery();
                // BURAYA

                // çektiğimiz id karşılıklarını tuyderi tableımıza yazıyoruz
                foreach (int text in classes)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_TuyDeri(HastaId, TuyDeriId) VALUES (@p1, @p2)", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //UrogenitalSistem

                var selectedUrogenitalSistems = this.GbUrogenitalSistem.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes1 = new List<int>();
                foreach (String text in selectedUrogenitalSistems)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_UrogenitalSistemClass Where UrogenitalSistem=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes1.Add(dr.GetInt32(0));
                    }
                    dr.Close();

                }
                SqlCommand delete1 = command("DELETE FROM Tbl_UrogenitalSistem WHERE Hastaid = @p1");
                delete1.Parameters.AddWithValue("@p1", id);
                delete1.ExecuteNonQuery();
                foreach (int text in classes1)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_UrogenitalSistem(Hastaid, UrogenitalSistemid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Kulaklar

                var selectedKulaklars = this.GbKulaklar.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes2 = new List<int>();
                foreach (String text in selectedKulaklars)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_KulaklarClass Where Kulaklar=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes2.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete2 = command("DELETE FROM Tbl_Kulaklar WHERE Hastaid = @p1");
                delete2.Parameters.AddWithValue("@p1", id);
                delete2.ExecuteNonQuery();
                foreach (int text in classes2)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kulaklar(Hastaid, Kulaklarid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Kas İskelet

                var selectedKasIskelets = this.GbKasIskelet.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes3 = new List<int>();
                foreach (String text in selectedKasIskelets)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_KasIskeletiClass Where KasIskelet=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes3.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete3 = command("DELETE FROM Tbl_KasIskeleti WHERE Hastaid = @p1");
                delete3.Parameters.AddWithValue("@p1", id);
                delete3.ExecuteNonQuery();
                foreach (int text in classes3)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_KasIskeleti(Hastaid, KasIskeletiid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Kalp

                var selectedKalps = this.GbKalp.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes4 = new List<int>();
                foreach (String text in selectedKalps)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_KalpClass Where Kalp=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes4.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete4 = command("DELETE FROM Tbl_Kalp WHERE Hastaid = @p1");
                delete4.Parameters.AddWithValue("@p1", id);
                delete4.ExecuteNonQuery();
                foreach (int text in classes4)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kalp(Hastaid, Kalpid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Gözler

                var selectedGozlers = this.GbGozler.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes5 = new List<int>();
                foreach (String text in selectedGozlers)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_GozlerClass Where Gozler=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes5.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete5 = command("DELETE FROM Tbl_Gozler WHERE Hastaid = @p1");
                delete5.Parameters.AddWithValue("@p1", id);
                delete5.ExecuteNonQuery();
                foreach (int text in classes5)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Gozler(Hastaid, Gozlerid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Gastroinstentinal

                var selectedGastroinstentinals = this.GbGastroinstentinal.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes6 = new List<int>();
                foreach (String text in selectedGastroinstentinals)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_GastroinstentinalClass Where Gastroinstentinal=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes6.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete6 = command("DELETE FROM Tbl_Gastroinstentinal WHERE Hastaid = @p1");
                delete6.Parameters.AddWithValue("@p1", id);
                delete6.ExecuteNonQuery();
                foreach (int text in classes6)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Gastroinstentinal(Hastaid, Gastroinstentinalid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Burun ve Boğaz

                var selectedBurunBogazs = this.GbBurunBogaz.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes7 = new List<int>();
                foreach (String text in selectedBurunBogazs)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_BurunveBogazClass Where BurunveBogaz=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes7.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete7 = command("DELETE FROM Tbl_BurunveBogaz WHERE Hastaid = @p1");
                delete7.Parameters.AddWithValue("@p1", id);
                delete7.ExecuteNonQuery();
                foreach (int text in classes7)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_BurunveBogaz(Hastaid, BurunveBogazid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Beslenme
                var selectedBeslenmes = this.GbBeslenme.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes8 = new List<int>();
                foreach (String text in selectedBeslenmes)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_BeslenmeClass Where Beslenme=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes8.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete8 = command("DELETE FROM Tbl_Beslenme WHERE Hastaid = @p1");
                delete8.Parameters.AddWithValue("@p1", id);
                delete8.ExecuteNonQuery();
                foreach (int text in classes8)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Beslenme(Hastaid, Beslenmeid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Aşılar

                var selectedAsilars = this.GbAsilar.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes9 = new List<int>();
                foreach (String text in selectedAsilars)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_AsilarClass Where Asilar=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes9.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete9 = command("DELETE FROM Tbl_Asilar WHERE Hastaid = @p1");
                delete9.Parameters.AddWithValue("@p1", id);
                delete9.ExecuteNonQuery();
                foreach (int text in classes9)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Asilar(Hastaid, Asilarid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Akciğer

                var selectedAkcigers = this.GbAkciger.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes10 = new List<int>();
                foreach (String text in selectedAkcigers)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_AkcigerClass Where Akciger=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes10.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete10 = command("DELETE FROM Tbl_Akciger WHERE Hastaid = @p1");
                delete10.Parameters.AddWithValue("@p1", id);
                delete10.ExecuteNonQuery();
                foreach (int text in classes10)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Akciger(Hastaid, Akcigerid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();
                }

                //Ağız Diş Dişeti

                var selectedAgizDisDisetis = this.GbAgizDisDiseti.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes11 = new List<int>();
                foreach (String text in selectedAgizDisDisetis)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_AgizDisDisetiClass Where AgizDisDiseti=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes11.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete11 = command("DELETE FROM Tbl_AgizDisDiseti WHERE Hastaid = @p1");
                delete11.Parameters.AddWithValue("@p1", id);
                delete11.ExecuteNonQuery();
                foreach (int text in classes11)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_AgizDisDiseti(Hastaid, AgizDisDisetiid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();

                }

                //Ağırlık

                var selectedAgirliks = this.GbAgirlik.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes12 = new List<int>();
                foreach (String text in selectedAgirliks)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_AgirlikClass Where Agirlik=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes12.Add(dr.GetInt32(0));
                    }
                    dr.Close();

                }

                SqlCommand delete12 = command("DELETE FROM Tbl_Agirlik WHERE Hastaid = @p1");
                delete12.Parameters.AddWithValue("@p1", id);
                delete12.ExecuteNonQuery();
                foreach (int text in classes12)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Agirlik(Hastaid, Agirlikid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();

                }

                //Abdomen

                var selectedAbdomens = this.GbAbdomen.Controls.OfType<CheckBox>().Where(cb => cb.Checked == true).ToList().ConvertAll(cb => cb.Text);
                var classes13 = new List<int>();
                foreach (String text in selectedAbdomens)
                {
                    // her biri için class tableından id karşılığını çekiyoruz
                    SqlCommand komut = new SqlCommand("Select * From Tbl_AbdomenClass Where Abdomen=@p1", baglan.baglanti);
                    komut.Parameters.AddWithValue("@p1", text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        classes13.Add(dr.GetInt32(0));
                    }
                    dr.Close();


                }
                SqlCommand delete13 = command("DELETE FROM Tbl_Abdomen WHERE Hastaid = @p1");
                delete13.Parameters.AddWithValue("@p1", id);
                delete13.ExecuteNonQuery();
                foreach (int text in classes13)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Abdomen(Hastaid, Abdomenid) VALUES (@p1, @p2)", baglan.baglanti);
                    // TODO şu an hasta kısmı entegre edilmediği için ama hastanın idsini bildiğimiz için 1 kullandık.
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.Parameters.AddWithValue("@p2", text);
                    komut.ExecuteNonQuery();

                }

                //Muayene Teşhisi

                SqlCommand delete14 = command("DELETE FROM Tbl_MTeshis WHERE HastaId = @p1");
                delete14.Parameters.AddWithValue("@p1", id);
                delete14.ExecuteNonQuery();

                string richTextBox = null;
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox = (string)richTextBox1.Invoke(new Func<string>(() => richTextBox1.Text));
                }
                else
                {
                    richTextBox = richTextBox1.Text;
                }

                SqlCommand komut2 = new SqlCommand("INSERT INTO Tbl_MTeshis(HastaId, MuayeneTeshis) VALUES (@p1, @p2)", baglan.baglanti);
                komut2.Parameters.AddWithValue("@p1", id);
                komut2.Parameters.AddWithValue("@p2", richTextBox);
                komut2.ExecuteNonQuery();

                // Use Invoke to update UI controls on the main thread after the background work is done
                frm.Invoke((MethodInvoker)delegate
                {
                    frm.Enabled = true;
                });
            });
            MessageBox.Show("Pet Muayenesi Başarılı Bir Şekilde Gerçekleştirildi.", "Başarılı!");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}