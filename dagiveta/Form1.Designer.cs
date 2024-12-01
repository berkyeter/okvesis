namespace dagiveta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            temabox1 = new CheckBox();
            panel1 = new Panel();
            databasecreate = new Button();
            ogrencilerilistelebutton = new Button();
            ogrencieklebutton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // temabox1
            // 
            temabox1.AutoSize = true;
            temabox1.Font = new Font("Segoe UI", 15F);
            temabox1.Location = new Point(4, 354);
            temabox1.Name = "temabox1";
            temabox1.Size = new Size(151, 32);
            temabox1.TabIndex = 0;
            temabox1.Text = "Karanlık Tema";
            temabox1.UseVisualStyleBackColor = true;
            temabox1.CheckedChanged += temabox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(databasecreate);
            panel1.Controls.Add(temabox1);
            panel1.Controls.Add(ogrencilerilistelebutton);
            panel1.Controls.Add(ogrencieklebutton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 389);
            panel1.TabIndex = 1;
            // 
            // databasecreate
            // 
            databasecreate.Location = new Point(3, 203);
            databasecreate.Name = "databasecreate";
            databasecreate.Size = new Size(148, 72);
            databasecreate.TabIndex = 2;
            databasecreate.Text = "Veri Tabanı Oluştur";
            databasecreate.UseVisualStyleBackColor = true;
            databasecreate.Click += databasecreate_Click;
            // 
            // ogrencilerilistelebutton
            // 
            ogrencilerilistelebutton.Location = new Point(3, 99);
            ogrencilerilistelebutton.Name = "ogrencilerilistelebutton";
            ogrencilerilistelebutton.Size = new Size(148, 72);
            ogrencilerilistelebutton.TabIndex = 1;
            ogrencilerilistelebutton.Text = "Öğrencileri Listele";
            ogrencilerilistelebutton.UseVisualStyleBackColor = true;
            ogrencilerilistelebutton.Click += ogrencilerilistelebutton_Click;
            // 
            // ogrencieklebutton
            // 
            ogrencieklebutton.Location = new Point(3, 3);
            ogrencieklebutton.Name = "ogrencieklebutton";
            ogrencieklebutton.Size = new Size(148, 72);
            ogrencieklebutton.TabIndex = 0;
            ogrencieklebutton.Text = "Öğrenci Ekle";
            ogrencieklebutton.UseVisualStyleBackColor = true;
            ogrencieklebutton.Click += ogrencieklebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 414);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Okvesis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox temabox1;
        private Panel panel1;
        private Button ogrencilerilistelebutton;
        private Button ogrencieklebutton;
        private Button databasecreate;
    }
}
