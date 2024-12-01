using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace dagiveta
{
    public partial class listele : Form
    {
        public listele()
        {
            InitializeComponent();
        }

        // Define Person record to hold the data
        public record Person(string tc, string ad, string soyad, string dt, string telno, string adres, string okulno, string sinif, string annead, string babaad);

        // List to hold Person data
        List<Person> list_data = new List<Person>();

        private void listelebutton_Click(object sender, EventArgs e)
        {
            // Define the file path
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dagiveta");
            string filename = "ogrenciveritabani.csv";
            string finalFilePath = Path.Combine(path, filename);

            // Check if the file exists
            if (File.Exists(finalFilePath))
            {
                // Read all lines from the CSV file
                string[] data = File.ReadAllLines(finalFilePath);

                // Loop through each line, skip the header if exists
                for (int i = 1; i < data.Length; i++) // Assuming the first line is header
                {
                    string[] values = data[i].Split(',');

                    // Create a Person object and add to the list
                    var person = new Person(
                        values[0], // tc
                        values[1], // ad
                        values[2], // soyad
                        values[3], // dt
                        values[4], // telno
                        values[5], // adres
                        values[6], // okulno
                        values[7], // sinif
                        values[8], // annead
                        values[9]  // babaad
                    );

                    list_data.Add(person);
                }

                // Optionally, display the data in a DataGridView or another UI element
                // For example, display the data in a DataGridView:
                dataGridView1.DataSource = list_data;
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }
    }
}
