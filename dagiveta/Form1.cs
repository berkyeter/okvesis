using System.IO;

namespace dagiveta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temabox1_CheckedChanged(object sender, EventArgs e)
        {
            if (temabox1.Checked)
            {
                this.BackColor = System.Drawing.Color.DimGray; // Formun arka planýný siyah yapar
                temabox1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = System.Drawing.Color.White; // Formun arka planýný beyaz yapar
                temabox1.ForeColor = Color.Black;
            }
        }

        private void ogrencieklebutton_Click(object sender, EventArgs e)
        {
            ogrenciekleForm f2 = new ogrenciekleForm();
            f2.Show();
        }

        private void databasecreate_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dagiveta");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filename = "ogrenciveritabani.csv";
            string finalFilePath = Path.Combine(path, filename);

            if (File.Exists(finalFilePath))
            {
                MessageBox.Show("Veritabaný zaten mevcut. Yeni bir veritabaný oluþturmak istiyorsanýz mevcut dosyayý silin.", "Hata");
                return;
            }

            try
            {
                string[] headers = { "tc", "ad", "soyad", "dt", "telno", "adres", "okulno", "sinif", "annead", "babaad" };
                string data = string.Join(",", headers);

                File.WriteAllText(finalFilePath, data);

                MessageBox.Show("Veritabaný baþarýyla oluþturuldu. Belgeler klasörünüzdeki 'dagiveta' dizini altýnda 'ogrenciveritabani.csv' dosyasýný bulabilirsiniz.", "Baþarýlý");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabaný oluþturulurken bir hata oluþtu: {ex.Message}", "Hata");
            }
        }

        private void ogrencilerilistelebutton_Click(object sender, EventArgs e)
        {
            listele f3 = new listele();
            f3.Show();
        }
    }
}
