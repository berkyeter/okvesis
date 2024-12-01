using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dagiveta
{
    public partial class ogrenciekleForm : Form
    {
        public ogrenciekleForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.dateTimePicker1, "Öğrencinin Doğum Tarihi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dagiveta");
            string filename = "ogrenciveritabani.csv";
            string finalFilePath = Path.Combine(dbpath, filename);

            if (!Directory.Exists(dbpath))
            {
                MessageBox.Show("Veri tabanı dizini bulunamadı! " + dbpath, "Hata");
                return;
            }

            if (!File.Exists(finalFilePath))
            {
                MessageBox.Show("Veri tabanı bulunamadı! " + finalFilePath, "Hata");
                return;
            }

            string virgul = ",";
            string ogrData = tckimliktb1.Text + virgul + adtb1.Text + virgul + soyadtb1.Text + virgul + dateTimePicker1.Text + virgul + telnotb1.Text + virgul + adrestb1.Text + virgul + okulnotb1.Text + virgul + dersliktb1.Text + virgul + anneadtb.Text + virgul + babaadtb.Text;
            string existingContent = File.ReadAllText(finalFilePath);
            string newContent = existingContent + "\n" + ogrData;
            File.WriteAllText(finalFilePath, newContent);
            MessageBox.Show("Başarıyla kaydedildi!", "Bilgi");

        }

    }
}
