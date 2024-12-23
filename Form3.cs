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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneDBApp
{
    public partial class Form3 : Form
    {
        private string _baglantiString = "Host=localhost;Port=5432;Username=postgres;Password=######;Database=EczaneDB";
        public Form3()
        {
            InitializeComponent();
            EczaneleriYukle();
        }
        private void EczaneleriYukle()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Eczane ORDER BY eczaneNo"; // EczaneNo'ya göre sıralama
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dataGridViewEczaneler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void buttonEczaneEkle_Click(object sender, EventArgs e)
        {
            string eczaneAdi = textBoxEczaneAdi.Text;
            int ilKodu;
            int ilceKodu;

            // İl ve İlçe kodlarının geçerli olduğundan emin olalım
            if (!int.TryParse(textBoxilKodu.Text, out ilKodu))
            {
                MessageBox.Show("Geçersiz İl Kodu.");
                return;
            }

            if (!int.TryParse(textBoxilceKodu.Text, out ilceKodu))
            {
                MessageBox.Show("Geçersiz İlçe Kodu.");
                return;
            }

            // Eczane adı boş olmamalı
            if (string.IsNullOrEmpty(eczaneAdi))
            {
                MessageBox.Show("Eczane adı boş olamaz.");
                return;
            }

            // Veritabanı bağlantısını aç ve ekle
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();

                    // Eczane tablosuna veri ekleme
                    string query = "INSERT INTO Eczane (eczaneAdi, ilceKodu, ilKodu) VALUES (@eczaneAdi, @ilceKodu, @ilKodu)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@eczaneAdi", eczaneAdi);
                        cmd.Parameters.AddWithValue("@ilceKodu", ilceKodu);
                        cmd.Parameters.AddWithValue("@ilKodu", ilKodu);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Eczane başarıyla eklendi.");

                    EczaneleriYukle();
                    // Formu temizle
                    textBoxEczaneAdi.Clear();
                    textBoxilKodu.Clear();
                    textBoxilceKodu.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void buttonEczaneSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewEczaneler.SelectedRows.Count > 0)
            {
                // Seçili satırdaki eczane numarasını al
                int eczaneNo = Convert.ToInt32(dataGridViewEczaneler.SelectedRows[0].Cells["eczaneNo"].Value);

                // Silme işlemi onayı almak için kullanıcıdan onay alalım
                var result = MessageBox.Show("Bu eczaneyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Veritabanı bağlantısını aç ve eczaneyi sil
                    using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
                    {
                        try
                        {
                            connection.Open();

                            // Eczane silme sorgusu
                            string query = "DELETE FROM Eczane WHERE eczaneNo = @eczaneNo";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@eczaneNo", eczaneNo);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Eczane başarıyla silindi.");
                                    // DataGridView'i güncelle
                                    EczaneleriYukle();
                                }
                                else
                                {
                                    MessageBox.Show("Eczane silinemedi.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir eczane seçin.");
            }
        }

        private void buttonEczaneGuncelle_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili satırı al
            if (dataGridViewEczaneler.SelectedRows.Count > 0)
            {
                // Seçili satırdaki eczane numarasını al
                int eczaneNo = Convert.ToInt32(dataGridViewEczaneler.SelectedRows[0].Cells["eczaneNo"].Value);
                string eczaneAdi = textBoxEczaneAdi.Text;
                int ilKodu;
                int ilceKodu;

                // İl ve İlçe kodlarının geçerli olduğundan emin olalım
                if (!int.TryParse(textBoxilKodu.Text, out ilKodu))
                {
                    MessageBox.Show("Geçersiz İl Kodu.");
                    return;
                }

                if (!int.TryParse(textBoxilceKodu.Text, out ilceKodu))
                {
                    MessageBox.Show("Geçersiz İlçe Kodu.");
                    return;
                }

                // Eczane adı boş olmamalı
                if (string.IsNullOrEmpty(eczaneAdi))
                {
                    MessageBox.Show("Eczane adı boş olamaz.");
                    return;
                }

                // Veritabanı bağlantısını aç ve güncelle
                using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
                {
                    try
                    {
                        connection.Open();

                        // Eczane güncelleme sorgusu
                        string query = "UPDATE Eczane SET eczaneAdi = @eczaneAdi, ilceKodu = @ilceKodu, ilKodu = @ilKodu WHERE eczaneNo = @eczaneNo";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@eczaneAdi", eczaneAdi);
                            cmd.Parameters.AddWithValue("@ilceKodu", ilceKodu);
                            cmd.Parameters.AddWithValue("@ilKodu", ilKodu);
                            cmd.Parameters.AddWithValue("@eczaneNo", eczaneNo);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Eczane bilgileri başarıyla güncellendi.");
                                // DataGridView'i güncelle
                                EczaneleriYukle();
                            }
                            else
                            {
                                MessageBox.Show("Eczane bilgileri güncellenemedi.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir eczane seçin.");
            }
        }

        private void buttonEczaneAra_Click(object sender, EventArgs e)
        {
            string aramaKelimesi = textBoxAra.Text.Trim(); // Kullanıcı tarafından girilen arama kelimesi

            if (string.IsNullOrEmpty(aramaKelimesi))
            {
                MessageBox.Show("Lütfen bir arama kelimesi girin.");
                return;
            }

            // Veritabanı bağlantısı ve arama sorgusu
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();
                    // Eczane adı içinde arama yapan sorgu
                    string query = "SELECT * FROM Eczane WHERE eczaneAdi ILIKE @aramaKelimesi ORDER BY eczaneNo"; // ILIKE büyük/küçük harf duyarsız
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection))
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@aramaKelimesi", "%" + aramaKelimesi + "%");
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dataGridViewEczaneler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EczaneleriYukle();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxilceKodu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
