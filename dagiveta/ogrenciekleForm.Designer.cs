namespace dagiveta
{
    partial class ogrenciekleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tckimliktb1 = new TextBox();
            adtb1 = new TextBox();
            soyadtb1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            telnotb1 = new TextBox();
            adrestb1 = new TextBox();
            okulnotb1 = new TextBox();
            dersliktb1 = new TextBox();
            anneadtb = new TextBox();
            babaadtb = new TextBox();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // tckimliktb1
            // 
            tckimliktb1.Location = new Point(12, 12);
            tckimliktb1.Name = "tckimliktb1";
            tckimliktb1.PlaceholderText = "Tc Kimlik No...";
            tckimliktb1.Size = new Size(165, 23);
            tckimliktb1.TabIndex = 0;
            // 
            // adtb1
            // 
            adtb1.Location = new Point(12, 41);
            adtb1.Name = "adtb1";
            adtb1.PlaceholderText = "Öğrencinin Adı...";
            adtb1.Size = new Size(165, 23);
            adtb1.TabIndex = 1;
            // 
            // soyadtb1
            // 
            soyadtb1.Location = new Point(12, 70);
            soyadtb1.Name = "soyadtb1";
            soyadtb1.PlaceholderText = "Öğrencinin Soyadı...";
            soyadtb1.Size = new Size(165, 23);
            soyadtb1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleDescription = "Doğum Tarihi";
            dateTimePicker1.Location = new Point(12, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // telnotb1
            // 
            telnotb1.Location = new Point(12, 141);
            telnotb1.Name = "telnotb1";
            telnotb1.PlaceholderText = "Telefon Numarası...";
            telnotb1.Size = new Size(165, 23);
            telnotb1.TabIndex = 4;
            // 
            // adrestb1
            // 
            adrestb1.Location = new Point(12, 170);
            adrestb1.Multiline = true;
            adrestb1.Name = "adrestb1";
            adrestb1.PlaceholderText = "Ev adresi...";
            adrestb1.Size = new Size(165, 87);
            adrestb1.TabIndex = 5;
            // 
            // okulnotb1
            // 
            okulnotb1.Location = new Point(12, 275);
            okulnotb1.Name = "okulnotb1";
            okulnotb1.PlaceholderText = "Okul Numarası";
            okulnotb1.Size = new Size(165, 23);
            okulnotb1.TabIndex = 6;
            // 
            // dersliktb1
            // 
            dersliktb1.Location = new Point(12, 304);
            dersliktb1.Name = "dersliktb1";
            dersliktb1.PlaceholderText = "Derslik";
            dersliktb1.Size = new Size(165, 23);
            dersliktb1.TabIndex = 7;
            // 
            // anneadtb
            // 
            anneadtb.Location = new Point(12, 345);
            anneadtb.Name = "anneadtb";
            anneadtb.PlaceholderText = "Anne adı...";
            anneadtb.Size = new Size(165, 23);
            anneadtb.TabIndex = 8;
            // 
            // babaadtb
            // 
            babaadtb.Location = new Point(12, 374);
            babaadtb.Name = "babaadtb";
            babaadtb.PlaceholderText = "Baba adı...";
            babaadtb.Size = new Size(165, 23);
            babaadtb.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(12, 403);
            button1.Name = "button1";
            button1.Size = new Size(165, 35);
            button1.TabIndex = 10;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ogrenciekleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 450);
            Controls.Add(button1);
            Controls.Add(babaadtb);
            Controls.Add(anneadtb);
            Controls.Add(dersliktb1);
            Controls.Add(okulnotb1);
            Controls.Add(adrestb1);
            Controls.Add(telnotb1);
            Controls.Add(dateTimePicker1);
            Controls.Add(soyadtb1);
            Controls.Add(adtb1);
            Controls.Add(tckimliktb1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ogrenciekleForm";
            Text = "Öğrenci Ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tckimliktb1;
        private TextBox adtb1;
        private TextBox soyadtb1;
        private DateTimePicker dateTimePicker1;
        private TextBox telnotb1;
        private TextBox adrestb1;
        private TextBox okulnotb1;
        private TextBox dersliktb1;
        private TextBox anneadtb;
        private TextBox babaadtb;
        private Button button1;
        private ToolTip toolTip1;
    }
}