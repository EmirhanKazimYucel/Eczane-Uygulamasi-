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

namespace EczaneDBApp
{
    public partial class Form4 : Form
    {
        private string _baglantiString = "Host=localhost;Port=5432;Username=postgres;Password=######;Database=EczaneDB";
        public Form4()
        {
            InitializeComponent();
            ReceteleriYukle();
        }
        private void ReceteleriYukle()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_baglantiString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Recete"; // Tüm reçeteleri çek
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt; // Veriyi DataGridView'e bağla
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

        }
    }
}
