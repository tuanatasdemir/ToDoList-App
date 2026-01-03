using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using Microsoft.Data.SqlClient;
using System.Data.SQLite;

namespace ToDoListForm
{
    public partial class ToDoList : Form
    {
        // SQLite sadece dosya adýný ister. Dosya yoksa kendisi oluþturur.
        string baglantiAdresi = "Data Source=yapilacaklar.db;Version=3;";
        //string baglantiAdresi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tuana\source\repos\ToDoListForm\ToDoListForm\GorevVeriTabani.mdf;Integrated Security=True";
        public class GorevNesnesi
        {
            public int Id { get; set; }
            public string Metin { get; set; }
            public override string ToString()
            {
                return Metin;
            }
        }

        private void VeritabaniKur()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiAdresi))
            {
                baglanti.Open();
                string sql = "CREATE TABLE IF NOT EXISTS Gorevler (Id INTEGER PRIMARY KEY AUTOINCREMENT, GorevAd TEXT, YapildiMi INTEGER)";
                SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
                komut.ExecuteNonQuery();
            }
        }

        private void SesCal()
        {
            string dosyaYolu = "click.wav";

            try
            {
                SoundPlayer ses = new SoundPlayer(dosyaYolu);
                ses.Play();
            }
            catch (Exception)
            {
                // Dosya bulunamazsa program çökmesin diye burasý boþ.
            }
        }
        public ToDoList()
        {
            InitializeComponent();
        }

        private void VerileriGetir()
        {
            listTasks.Items.Clear(); // Önce listeyi temizle

            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand("SELECT * FROM Gorevler", baglanti);
                    SQLiteDataReader okuyucu = komut.ExecuteReader();

                    while (okuyucu.Read())
                    {
                        // Veritabanýndan gelen her satýrý özel nesnemize çeviriyoruz
                        GorevNesnesi gorev = new GorevNesnesi();
                        gorev.Id = Convert.ToInt32(okuyucu["Id"]); 
                        gorev.Metin = (string)okuyucu["GorevAd"];

                        listTasks.Items.Add(gorev); // Listeye nesneyi ekle
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading data: " + ex.Message);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGorev.Text))
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiAdresi))
                {
                    try
                    {
                        baglanti.Open();
                        SQLiteCommand komut = new SQLiteCommand("INSERT INTO Gorevler (GorevAd, YapildiMi) VALUES (@ad, 0)", baglanti);
                        komut.Parameters.AddWithValue("@ad", txtGorev.Text);

                        komut.ExecuteNonQuery();

                        SesCal(); 
                        txtGorev.Clear();
                        txtGorev.Focus();

                        VerileriGetir();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your task!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listTasks.CheckedItems.Count > 0 || listTasks.SelectedIndex != -1)
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    foreach (GorevNesnesi silinecekGorev in listTasks.CheckedItems)
                    {
                        SQLiteCommand komut = new SQLiteCommand("DELETE FROM Gorevler WHERE Id = @id", baglanti);
                        komut.Parameters.AddWithValue("@id", silinecekGorev.Id);
                        komut.ExecuteNonQuery();
                    }

                    if (listTasks.CheckedItems.Count == 0 && listTasks.SelectedIndex != -1)
                    {
                        GorevNesnesi seciliGorev = (GorevNesnesi)listTasks.SelectedItem;
                        SQLiteCommand komut = new SQLiteCommand("DELETE FROM Gorevler WHERE Id = @id", baglanti);
                        komut.Parameters.AddWithValue("@id", seciliGorev.Id);
                        komut.ExecuteNonQuery();
                    }
                }

                SesCal();
                VerileriGetir();

            }
            else
            {
                MessageBox.Show("Select a task to delete.");
            }
        }

        private void txtGorev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkle.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void listTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeritabaniKur();
            VerileriGetir();
        }
    }
}
