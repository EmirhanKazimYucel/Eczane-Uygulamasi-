using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace EczaneDBApp
{
    public partial class Form2 : Form
    {
        private string _baglantiString = "Host=localhost;Port=5432;Username=postgres;Password=757barhaR;Database=EczaneDB";
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string adi = textBoxAdi.Text;
            string soyadi = textBoxSoyadi.Text;
            string kisiTipi = radioButtonHasta.Checked ? "hasta" : "eczaci"; // hasta veya eczaci olacak
            string eczaneNo = radioButtonEczaci.Checked ? textBoxEczaneNo.Text : null; // sadece eczacı seçildiyse eczaneNo'yu al

            if (string.IsNullOrEmpty(adi) || string.IsNullOrEmpty(soyadi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();

                    // Kişi tablosuna veri ekleme
                    string kisiQuery = "INSERT INTO Kisi (adi, soyadi, kisiTipi) VALUES (@adi, @soyadi, @kisiTipi) RETURNING kimlikNo";
                    using (NpgsqlCommand kisiCmd = new NpgsqlCommand(kisiQuery, connection))
                    {
                        kisiCmd.Parameters.AddWithValue("@adi", adi);
                        kisiCmd.Parameters.AddWithValue("@soyadi", soyadi);
                        kisiCmd.Parameters.AddWithValue("@kisiTipi", kisiTipi);

                        int kimlikNo = (int)kisiCmd.ExecuteScalar(); // Kimlik numarasını al

                        // Eczacı seçildiyse, eczaneNo eklemek
                        if (kisiTipi == "eczaci" && !string.IsNullOrEmpty(eczaneNo))
                        {
                            string eczaciQuery = "UPDATE Kisi SET eczaneNo = @eczaneNo WHERE kimlikNo = @kimlikNo";
                            using (NpgsqlCommand eczaciCmd = new NpgsqlCommand(eczaciQuery, connection))
                            {
                                eczaciCmd.Parameters.AddWithValue("@eczaneNo", eczaneNo);
                                eczaciCmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                                eczaciCmd.ExecuteNonQuery(); // Eczane numarasını ekleyin
                            }
                        }

                        MessageBox.Show("Kişi başarıyla eklendi.");
                        // Formu temizle
                        textBoxAdi.Clear();
                        textBoxSoyadi.Clear();
                        textBoxEczaneNo.Clear();
                        radioButtonHasta.Checked = true;
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
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();

                    // Kisi tablosundaki tüm verileri sorgulama
                    string query = "SELECT kimlikNo, adi, soyadi, kisiTipi FROM Kisi";
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); // Verileri DataTable'a yükleyin

                        // DataGridView'e veri bağlayın
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void buttonHastaGoster_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();

                    // Kisi ve Hasta tablolarını birleştirerek yalnızca hasta olanları getirme
                    string query = @"
                SELECT k.kimlikNo, k.adi, k.soyadi, k.kisiTipi
                FROM Kisi k
                INNER JOIN Hasta h ON k.kimlikNo = h.kimlikNo";

                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); // Verileri DataTable'a yükleyin

                        // DataGridView'e veri bağlayın
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void buttonEczaciGoster_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();

                    // Kisi ve Eczaci tablolarını birleştirerek eczacıları ve eczane numaralarını getirme
                    string query = @"
                SELECT k.kimlikNo, k.adi, k.soyadi, k.kisiTipi, e.eczaneNo
                FROM Kisi k
                INNER JOIN Eczaci e ON k.kimlikNo = e.kimlikNo";

                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); // Verileri DataTable'a yükleyin

                        // DataGridView'e veri bağlayın
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Seçilen satır var mı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki eczaneNo değerini TextBoxEczaneNo'ya aktar
                var selectedRow = dataGridView1.SelectedRows[0];
                string eczaneNo = selectedRow.Cells["eczaneNo"].Value.ToString(); // eczaneNo sütununa göre
                textBoxEczaneNo.Text = eczaneNo;
            }
        }

        private void buttonEczaneNoAta_Click(object sender, EventArgs e)
        {
            // Seçili satır var mı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki kimlikNo'yu al
                var selectedRow = dataGridView1.SelectedRows[0];
                int kimlikNo = Convert.ToInt32(selectedRow.Cells["kimlikNo"].Value);

                // TextBox'tan eczaneNo değerini al
                string eczaneNoText = textBoxEczaneNo.Text;

                // Eczane numarasının geçerli olup olmadığını kontrol et
                if (string.IsNullOrEmpty(eczaneNoText) || !int.TryParse(eczaneNoText, out int eczaneNo))
                {
                    MessageBox.Show("Lütfen geçerli bir eczane numarası girin.");
                    return;
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
                {
                    try
                    {
                        connection.Open();

                        // Eczaci tablosunda eczane numarasını güncelle
                        string query = "UPDATE Eczaci SET eczaneNo = @eczaneNo WHERE kimlikNo = @kimlikNo";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@eczaneNo", eczaneNo);
                            command.Parameters.AddWithValue("@kimlikNo", kimlikNo);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Eczane numarası başarıyla güncellendi.");
                            }
                            else
                            {
                                MessageBox.Show("Eczane numarası güncellenemedi.");
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
                MessageBox.Show("Lütfen bir eczacı seçin.");
            }
        }
        private void RefreshDataGridView()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Kisi"; // Burada Kisi tablosundaki verileri alıyoruz
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int kimlikNo = Convert.ToInt32(selectedRow.Cells["kimlikNo"].Value);
                string kisiTipi = selectedRow.Cells["kisiTipi"].Value.ToString();

                // Silme işlemi onayı
                DialogResult dialogResult = MessageBox.Show("Seçilen kişiyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
                    {
                        try
                        {
                            connection.Open();

                            // Hasta tablosundan silme
                            if (kisiTipi == "hasta")
                            {
                                string hastaQuery = "DELETE FROM Hasta WHERE kimlikNo = @kimlikNo";
                                using (NpgsqlCommand hastaCmd = new NpgsqlCommand(hastaQuery, connection))
                                {
                                    hastaCmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                                    hastaCmd.ExecuteNonQuery();
                                }
                            }

                            // Eczacı tablosundan silme
                            if (kisiTipi == "eczaci")
                            {
                                string eczaciQuery = "DELETE FROM Eczaci WHERE kimlikNo = @kimlikNo";
                                using (NpgsqlCommand eczaciCmd = new NpgsqlCommand(eczaciQuery, connection))
                                {
                                    eczaciCmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                                    eczaciCmd.ExecuteNonQuery();
                                }
                            }

                            // Kisi tablosundan silme
                            string kisiQuery = "DELETE FROM Kisi WHERE kimlikNo = @kimlikNo";
                            using (NpgsqlCommand kisiCmd = new NpgsqlCommand(kisiQuery, connection))
                            {
                                kisiCmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                                kisiCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Kişi başarıyla silindi.");
                            RefreshDataGridView(); // DataGridView'i yenileyin
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
                MessageBox.Show("Lütfen silmek istediğiniz kişiyi seçin.");
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçilen satırın olup olmadığını kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Seçilen kişiye ait kimlik numarasını ve tipini al
                int kimlikNo = Convert.ToInt32(selectedRow.Cells["kimlikNo"].Value);
                string kisiTipi = selectedRow.Cells["kisiTipi"].Value.ToString();

                // TextBox'lardaki değerleri al
                string adi = textBoxAdi.Text;
                string soyadi = textBoxSoyadi.Text;
                string eczaneNo = textBoxEczaneNo.Text;

                if (string.IsNullOrEmpty(adi) || string.IsNullOrEmpty(soyadi))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                // Veritabanına bağlantı oluştur
                using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
                {
                    try
                    {
                        connection.Open();

                        // Kişi tablosunu güncelleme
                        string kisiQuery = "UPDATE Kisi SET adi = @adi, soyadi = @soyadi WHERE kimlikNo = @kimlikNo";
                        using (NpgsqlCommand kisiCmd = new NpgsqlCommand(kisiQuery, connection))
                        {
                            kisiCmd.Parameters.AddWithValue("@adi", adi);
                            kisiCmd.Parameters.AddWithValue("@soyadi", soyadi);
                            kisiCmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                            kisiCmd.ExecuteNonQuery();
                        }

                        // Eczacıysa, Eczaci tablosunu güncelleme
                        if (kisiTipi == "eczaci")
                        {
                            string eczaciQuery = "UPDATE Eczaci SET eczaneNo = @eczaneNo WHERE kimlikNo = @kimlikNo";
                            using (NpgsqlCommand eczaciCmd = new NpgsqlCommand(eczaciQuery, connection))
                            {
                                eczaciCmd.Parameters.AddWithValue("@eczaneNo", string.IsNullOrEmpty(eczaneNo) ? (object)DBNull.Value : eczaneNo);
                                eczaciCmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                                eczaciCmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Kişi başarıyla güncellendi.");
                        RefreshDataGridView(); // DataGridView'i yenileyin
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kişiyi seçin.");
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string aramaKelimesi = textBoxAra.Text.Trim();

            // Arama kelimesi boşsa kullanıcıya bilgi ver
            if (string.IsNullOrEmpty(aramaKelimesi))
            {
                MessageBox.Show("Lütfen arama yapmak için bir değer girin.");
                return;
            }

            // Veritabanına bağlantı oluştur
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();

                    // Arama sorgusunu oluştur: Kisi tablosunda adi ve soyadi ile eşleşen kayıtları arıyoruz
                    string searchQuery = @"
                SELECT k.kimlikNo, k.adi, k.soyadi, k.kisiTipi, e.eczaneNo 
                FROM Kisi k
                LEFT JOIN Eczaci e ON k.kimlikNo = e.kimlikNo
                WHERE k.adi ILIKE @aramaKelimesi OR k.soyadi ILIKE @aramaKelimesi";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(searchQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@aramaKelimesi", "%" + aramaKelimesi + "%");

                        using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;  // DataGridView'i yeni sonuçlarla güncelle
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
