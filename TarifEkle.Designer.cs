namespace Yazlab1
{
    partial class TarifEkle
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
            kategori = new ComboBox();
            label1 = new Label();
            Hazirlanma_Suresi = new Label();
            label3 = new Label();
            Tarif_adi = new TextBox();
            Hazirlanma = new TextBox();
            label2 = new Label();
            Tarif_ekle = new Button();
            label4 = new Label();
            Talimatlar = new RichTextBox();
            dataGridViewTarifekle = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            Malzeme_adi = new TextBox();
            ToplamMiktar = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            BirimFiyat = new TextBox();
            Malzeme_birim = new ComboBox();
            listBoxMalzemeler = new ListBox();
            Malzeme_ekle = new Button();
            label10 = new Label();
            MalzemeMiktar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifekle).BeginInit();
            SuspendLayout();
            // 
            // kategori
            // 
            kategori.BackColor = Color.Linen;
            kategori.FormattingEnabled = true;
            kategori.Items.AddRange(new object[] { "Ana Yemek", "Çorba", "Salata", "Tatlı", "İçecek", "Ara Sıcak" });
            kategori.Location = new Point(441, 63);
            kategori.Margin = new Padding(3, 4, 3, 4);
            kategori.Name = "kategori";
            kategori.Size = new Size(138, 28);
            kategori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Bodoni MT", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 63);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // Hazirlanma_Suresi
            // 
            Hazirlanma_Suresi.AutoSize = true;
            Hazirlanma_Suresi.BackColor = Color.MistyRose;
            Hazirlanma_Suresi.Font = new Font("Bodoni MT", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Hazirlanma_Suresi.Location = new Point(1, 128);
            Hazirlanma_Suresi.Name = "Hazirlanma_Suresi";
            Hazirlanma_Suresi.Size = new Size(225, 29);
            Hazirlanma_Suresi.TabIndex = 2;
            Hazirlanma_Suresi.Text = "Hazirlanma Suresi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Bodoni MT", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 63);
            label3.Name = "label3";
            label3.Size = new Size(118, 29);
            label3.TabIndex = 3;
            label3.Text = "Tarif Adı";
            // 
            // Tarif_adi
            // 
            Tarif_adi.BackColor = Color.Linen;
            Tarif_adi.Location = new Point(152, 67);
            Tarif_adi.Margin = new Padding(3, 4, 3, 4);
            Tarif_adi.Name = "Tarif_adi";
            Tarif_adi.Size = new Size(143, 27);
            Tarif_adi.TabIndex = 4;
            // 
            // Hazirlanma
            // 
            Hazirlanma.BackColor = Color.Linen;
            Hazirlanma.Location = new Point(14, 161);
            Hazirlanma.Margin = new Padding(3, 4, 3, 4);
            Hazirlanma.Name = "Hazirlanma";
            Hazirlanma.Size = new Size(189, 27);
            Hazirlanma.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Bodoni MT", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 143);
            label2.Name = "label2";
            label2.Size = new Size(135, 29);
            label2.TabIndex = 6;
            label2.Text = "Talimatlar";
            // 
            // Tarif_ekle
            // 
            Tarif_ekle.BackColor = Color.Linen;
            Tarif_ekle.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tarif_ekle.ForeColor = Color.Firebrick;
            Tarif_ekle.Location = new Point(639, 401);
            Tarif_ekle.Margin = new Padding(3, 4, 3, 4);
            Tarif_ekle.Name = "Tarif_ekle";
            Tarif_ekle.Size = new Size(150, 156);
            Tarif_ekle.TabIndex = 8;
            Tarif_ekle.Text = "EKLE";
            Tarif_ekle.UseVisualStyleBackColor = false;
            Tarif_ekle.Click += Tarif_ekle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MistyRose;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(231, 37);
            label4.TabIndex = 9;
            label4.Text = "TARİF EKLEME";
            // 
            // Talimatlar
            // 
            Talimatlar.BackColor = Color.Linen;
            Talimatlar.Location = new Point(441, 116);
            Talimatlar.Margin = new Padding(3, 4, 3, 4);
            Talimatlar.Name = "Talimatlar";
            Talimatlar.Size = new Size(159, 95);
            Talimatlar.TabIndex = 10;
            Talimatlar.Text = "";
            // 
            // dataGridViewTarifekle
            // 
            dataGridViewTarifekle.BackgroundColor = Color.MistyRose;
            dataGridViewTarifekle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifekle.GridColor = Color.Firebrick;
            dataGridViewTarifekle.Location = new Point(639, 33);
            dataGridViewTarifekle.Name = "dataGridViewTarifekle";
            dataGridViewTarifekle.RowHeadersWidth = 51;
            dataGridViewTarifekle.Size = new Size(602, 347);
            dataGridViewTarifekle.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MistyRose;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(23, 226);
            label5.Name = "label5";
            label5.Size = new Size(138, 28);
            label5.TabIndex = 12;
            label5.Text = "MALZEMELER";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MistyRose;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(23, 286);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 13;
            label6.Text = "Malzeme Adı";
            // 
            // Malzeme_adi
            // 
            Malzeme_adi.BackColor = Color.Linen;
            Malzeme_adi.ForeColor = SystemColors.ActiveCaptionText;
            Malzeme_adi.Location = new Point(23, 309);
            Malzeme_adi.Name = "Malzeme_adi";
            Malzeme_adi.Size = new Size(125, 27);
            Malzeme_adi.TabIndex = 14;
            // 
            // ToplamMiktar
            // 
            ToplamMiktar.BackColor = Color.Linen;
            ToplamMiktar.Location = new Point(244, 309);
            ToplamMiktar.Name = "ToplamMiktar";
            ToplamMiktar.Size = new Size(125, 27);
            ToplamMiktar.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MistyRose;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(244, 286);
            label7.Name = "label7";
            label7.Size = new Size(177, 20);
            label7.TabIndex = 16;
            label7.Text = "Elinizdeki Toplam Miktar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MistyRose;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(23, 360);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 17;
            label8.Text = "Malzeme Birimi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.MistyRose;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(455, 286);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 18;
            label9.Text = "Birim Fiyatı";
            // 
            // BirimFiyat
            // 
            BirimFiyat.BackColor = Color.Linen;
            BirimFiyat.Location = new Point(454, 309);
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.Size = new Size(125, 27);
            BirimFiyat.TabIndex = 19;
            // 
            // Malzeme_birim
            // 
            Malzeme_birim.BackColor = Color.Linen;
            Malzeme_birim.FormattingEnabled = true;
            Malzeme_birim.Items.AddRange(new object[] { "Kilogram", "Gram", "Litre", "Mililitre", "Adet" });
            Malzeme_birim.Location = new Point(23, 400);
            Malzeme_birim.Name = "Malzeme_birim";
            Malzeme_birim.Size = new Size(151, 28);
            Malzeme_birim.TabIndex = 20;
            // 
            // listBoxMalzemeler
            // 
            listBoxMalzemeler.BackColor = Color.Linen;
            listBoxMalzemeler.FormattingEnabled = true;
            listBoxMalzemeler.Location = new Point(23, 457);
            listBoxMalzemeler.Name = "listBoxMalzemeler";
            listBoxMalzemeler.Size = new Size(222, 124);
            listBoxMalzemeler.TabIndex = 21;
            // 
            // Malzeme_ekle
            // 
            Malzeme_ekle.BackColor = Color.Linen;
            Malzeme_ekle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Malzeme_ekle.ForeColor = Color.Firebrick;
            Malzeme_ekle.Location = new Point(251, 476);
            Malzeme_ekle.Name = "Malzeme_ekle";
            Malzeme_ekle.Size = new Size(227, 79);
            Malzeme_ekle.TabIndex = 22;
            Malzeme_ekle.Text = "Malzeme Ekle ";
            Malzeme_ekle.UseVisualStyleBackColor = false;
            Malzeme_ekle.Click += Malzeme_ekle_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.MistyRose;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(244, 360);
            label10.Name = "label10";
            label10.Size = new Size(234, 20);
            label10.TabIndex = 23;
            label10.Text = "Eklenecek birim malzeme miktarı";
            // 
            // MalzemeMiktar
            // 
            MalzemeMiktar.BackColor = Color.Linen;
            MalzemeMiktar.Location = new Point(244, 400);
            MalzemeMiktar.Name = "MalzemeMiktar";
            MalzemeMiktar.Size = new Size(125, 27);
            MalzemeMiktar.TabIndex = 24;
            // 
            // TarifEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1253, 600);
            Controls.Add(MalzemeMiktar);
            Controls.Add(label10);
            Controls.Add(Malzeme_ekle);
            Controls.Add(listBoxMalzemeler);
            Controls.Add(Malzeme_birim);
            Controls.Add(BirimFiyat);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ToplamMiktar);
            Controls.Add(Malzeme_adi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridViewTarifekle);
            Controls.Add(Talimatlar);
            Controls.Add(label4);
            Controls.Add(Tarif_ekle);
            Controls.Add(label2);
            Controls.Add(Hazirlanma);
            Controls.Add(Tarif_adi);
            Controls.Add(label3);
            Controls.Add(Hazirlanma_Suresi);
            Controls.Add(label1);
            Controls.Add(kategori);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TarifEkle";
            Text = "TarifEkle";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifekle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox kategori;
        private Label label1;
        private Label Hazirlanma_Suresi;
        private Label label3;
        private TextBox Tarif_adi;
        private TextBox Hazirlanma;
        private Label label2;
        private Button Tarif_ekle;
        private Label label4;
        private RichTextBox Talimatlar;
        private DataGridView dataGridViewTarifekle;
        private Label label5;
        private Label label6;
        private TextBox Malzeme_adi;
        private TextBox ToplamMiktar;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox BirimFiyat;
        private ComboBox Malzeme_birim;
        private ListBox listBoxMalzemeler;
        private Button Malzeme_ekle;
        private Label label10;
        private TextBox MalzemeMiktar;
    }
}