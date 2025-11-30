namespace Yazlab1
{
    partial class AramaFiltreleme
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
            MalzemeTxt = new TextBox();
            MalzmEkleBtn = new Button();
            Malzeme_Listesi = new ListBox();
            label1 = new Label();
            MzmAraBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            TarifAdıAraTxt = new TextBox();
            label4 = new Label();
            TarifArabtn = new Button();
            TarifleriGÖsterList = new ListBox();
            HazırlanmaSuresiComboBox = new ComboBox();
            Filtreleme = new ListBox();
            KategoriComboBox = new ComboBox();
            MalzemeCOmboBOxx = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dataGridEslestirilenTarifler = new DataGridView();
            MalzemeBirimiCmb = new ComboBox();
            MalzemeMiktar = new TextBox();
            label11 = new Label();
            btnMaliyetHesapla = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            EksikmaliyetDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridEslestirilenTarifler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EksikmaliyetDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MalzemeTxt
            // 
            MalzemeTxt.BackColor = Color.Linen;
            MalzemeTxt.Location = new Point(24, 90);
            MalzemeTxt.Margin = new Padding(3, 4, 3, 4);
            MalzemeTxt.Name = "MalzemeTxt";
            MalzemeTxt.Size = new Size(114, 27);
            MalzemeTxt.TabIndex = 0;
            // 
            // MalzmEkleBtn
            // 
            MalzmEkleBtn.BackColor = Color.Linen;
            MalzmEkleBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            MalzmEkleBtn.ForeColor = Color.Firebrick;
            MalzmEkleBtn.Location = new Point(240, 230);
            MalzmEkleBtn.Margin = new Padding(3, 4, 3, 4);
            MalzmEkleBtn.Name = "MalzmEkleBtn";
            MalzmEkleBtn.Size = new Size(86, 31);
            MalzmEkleBtn.TabIndex = 1;
            MalzmEkleBtn.Text = "Ekle";
            MalzmEkleBtn.UseVisualStyleBackColor = false;
            MalzmEkleBtn.Click += MalzmEkleBtn_Click;
            // 
            // Malzeme_Listesi
            // 
            Malzeme_Listesi.BackColor = Color.Linen;
            Malzeme_Listesi.FormattingEnabled = true;
            Malzeme_Listesi.Location = new Point(212, 69);
            Malzeme_Listesi.Margin = new Padding(3, 4, 3, 4);
            Malzeme_Listesi.Name = "Malzeme_Listesi";
            Malzeme_Listesi.Size = new Size(174, 144);
            Malzeme_Listesi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 42);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 3;
            label1.Text = "Malzemelerinizi Giriniz ";
            // 
            // MzmAraBtn
            // 
            MzmAraBtn.BackColor = Color.Linen;
            MzmAraBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            MzmAraBtn.ForeColor = Color.Firebrick;
            MzmAraBtn.Location = new Point(12, 526);
            MzmAraBtn.Margin = new Padding(3, 4, 3, 4);
            MzmAraBtn.Name = "MzmAraBtn";
            MzmAraBtn.Size = new Size(278, 91);
            MzmAraBtn.TabIndex = 4;
            MzmAraBtn.Text = "Malzemeye Göre Ara";
            MzmAraBtn.UseVisualStyleBackColor = false;
            MzmAraBtn.Click += MzmAraBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(258, 26);
            label2.TabIndex = 5;
            label2.Text = "Malzemeye Göre Arama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(481, 9);
            label3.Name = "label3";
            label3.Size = new Size(240, 29);
            label3.TabIndex = 7;
            label3.Text = "Tarife Göre Arama";
            // 
            // TarifAdıAraTxt
            // 
            TarifAdıAraTxt.BackColor = Color.Linen;
            TarifAdıAraTxt.Location = new Point(582, 66);
            TarifAdıAraTxt.Margin = new Padding(3, 4, 3, 4);
            TarifAdıAraTxt.Name = "TarifAdıAraTxt";
            TarifAdıAraTxt.Size = new Size(139, 27);
            TarifAdıAraTxt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(493, 69);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Tarif Adı";
            // 
            // TarifArabtn
            // 
            TarifArabtn.BackColor = Color.Linen;
            TarifArabtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            TarifArabtn.ForeColor = Color.Firebrick;
            TarifArabtn.Location = new Point(582, 109);
            TarifArabtn.Margin = new Padding(3, 4, 3, 4);
            TarifArabtn.Name = "TarifArabtn";
            TarifArabtn.Size = new Size(139, 51);
            TarifArabtn.TabIndex = 10;
            TarifArabtn.Text = "Tarif Ara";
            TarifArabtn.UseVisualStyleBackColor = false;
            TarifArabtn.Click += TarifArabtn_Click;
            // 
            // TarifleriGÖsterList
            // 
            TarifleriGÖsterList.BackColor = Color.Linen;
            TarifleriGÖsterList.FormattingEnabled = true;
            TarifleriGÖsterList.Location = new Point(493, 168);
            TarifleriGÖsterList.Margin = new Padding(3, 4, 3, 4);
            TarifleriGÖsterList.Name = "TarifleriGÖsterList";
            TarifleriGÖsterList.Size = new Size(228, 104);
            TarifleriGÖsterList.TabIndex = 11;
            // 
            // HazırlanmaSuresiComboBox
            // 
            HazırlanmaSuresiComboBox.BackColor = Color.Linen;
            HazırlanmaSuresiComboBox.FormattingEnabled = true;
            HazırlanmaSuresiComboBox.Items.AddRange(new object[] { "En Hızlıdan En Yavaşa", "En Yavaşdan En Hızlıya" });
            HazırlanmaSuresiComboBox.Location = new Point(847, 66);
            HazırlanmaSuresiComboBox.Margin = new Padding(3, 4, 3, 4);
            HazırlanmaSuresiComboBox.Name = "HazırlanmaSuresiComboBox";
            HazırlanmaSuresiComboBox.Size = new Size(188, 28);
            HazırlanmaSuresiComboBox.TabIndex = 12;
            HazırlanmaSuresiComboBox.SelectedIndexChanged += HazırlanmaSuresiComboBox_SelectedIndexChanged;
            // 
            // Filtreleme
            // 
            Filtreleme.BackColor = Color.Linen;
            Filtreleme.FormattingEnabled = true;
            Filtreleme.Location = new Point(792, 255);
            Filtreleme.Margin = new Padding(3, 4, 3, 4);
            Filtreleme.Name = "Filtreleme";
            Filtreleme.Size = new Size(437, 264);
            Filtreleme.TabIndex = 13;
            // 
            // KategoriComboBox
            // 
            KategoriComboBox.BackColor = Color.Linen;
            KategoriComboBox.FormattingEnabled = true;
            KategoriComboBox.Items.AddRange(new object[] { "İçecek", "Ana Yemek", "Ara Sıcak", "Tatlı", "Salata", "Çorba" });
            KategoriComboBox.Location = new Point(847, 125);
            KategoriComboBox.Margin = new Padding(3, 4, 3, 4);
            KategoriComboBox.Name = "KategoriComboBox";
            KategoriComboBox.Size = new Size(188, 28);
            KategoriComboBox.TabIndex = 15;
            KategoriComboBox.SelectedIndexChanged += KategoriComboBox_SelectedIndexChanged;
            // 
            // MalzemeCOmboBOxx
            // 
            MalzemeCOmboBOxx.BackColor = Color.Linen;
            MalzemeCOmboBOxx.FormattingEnabled = true;
            MalzemeCOmboBOxx.Items.AddRange(new object[] { "Azalan Malzeme Sayısı", "Artan Malzeme Sayısı" });
            MalzemeCOmboBOxx.Location = new Point(847, 193);
            MalzemeCOmboBOxx.Margin = new Padding(3, 4, 3, 4);
            MalzemeCOmboBOxx.Name = "MalzemeCOmboBOxx";
            MalzemeCOmboBOxx.Size = new Size(188, 28);
            MalzemeCOmboBOxx.TabIndex = 16;
            MalzemeCOmboBOxx.SelectedIndexChanged += MalzemeCOmboBOxx_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(1044, 69);
            label5.Name = "label5";
            label5.Size = new Size(231, 20);
            label5.TabIndex = 17;
            label5.Text = "Hazırlanma Süresine Göre Sırala";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(1044, 128);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 18;
            label6.Text = "Kategoriye Göre Sırala";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(1044, 196);
            label7.Name = "label7";
            label7.Size = new Size(212, 20);
            label7.TabIndex = 19;
            label7.Text = "Malzeme Sayısına Göre Sırala";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(212, 42);
            label8.Name = "label8";
            label8.Size = new Size(159, 20);
            label8.TabIndex = 20;
            label8.Text = "Elinizdeki Malzemeler";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(12, 276);
            label9.Name = "label9";
            label9.Size = new Size(314, 20);
            label9.TabIndex = 21;
            label9.Text = "Elinizdeki Malzemelere Göre Eşleşen Tarifler";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(850, 9);
            label10.Name = "label10";
            label10.Size = new Size(154, 29);
            label10.TabIndex = 22;
            label10.Text = "FİLTRELEME";
            // 
            // dataGridEslestirilenTarifler
            // 
            dataGridEslestirilenTarifler.BackgroundColor = Color.MistyRose;
            dataGridEslestirilenTarifler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEslestirilenTarifler.Location = new Point(12, 312);
            dataGridEslestirilenTarifler.Name = "dataGridEslestirilenTarifler";
            dataGridEslestirilenTarifler.RowHeadersWidth = 51;
            dataGridEslestirilenTarifler.Size = new Size(324, 207);
            dataGridEslestirilenTarifler.TabIndex = 23;
            // 
            // MalzemeBirimiCmb
            // 
            MalzemeBirimiCmb.BackColor = Color.Linen;
            MalzemeBirimiCmb.FormattingEnabled = true;
            MalzemeBirimiCmb.Items.AddRange(new object[] { "Kilogram", "Gram", "Litre", "Mililitre", "Adet", "" });
            MalzemeBirimiCmb.Location = new Point(24, 148);
            MalzemeBirimiCmb.Name = "MalzemeBirimiCmb";
            MalzemeBirimiCmb.Size = new Size(110, 28);
            MalzemeBirimiCmb.TabIndex = 24;
            // 
            // MalzemeMiktar
            // 
            MalzemeMiktar.BackColor = Color.Linen;
            MalzemeMiktar.Location = new Point(24, 216);
            MalzemeMiktar.Name = "MalzemeMiktar";
            MalzemeMiktar.Size = new Size(110, 27);
            MalzemeMiktar.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(371, 276);
            label11.Name = "label11";
            label11.Size = new Size(110, 23);
            label11.TabIndex = 27;
            label11.Text = "Eksik Maliyet";
            // 
            // btnMaliyetHesapla
            // 
            btnMaliyetHesapla.BackColor = Color.Linen;
            btnMaliyetHesapla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMaliyetHesapla.ForeColor = Color.Firebrick;
            btnMaliyetHesapla.Location = new Point(371, 540);
            btnMaliyetHesapla.Name = "btnMaliyetHesapla";
            btnMaliyetHesapla.Size = new Size(150, 67);
            btnMaliyetHesapla.TabIndex = 28;
            btnMaliyetHesapla.Text = "Eksik Maliyet Hesapla";
            btnMaliyetHesapla.UseVisualStyleBackColor = false;
            btnMaliyetHesapla.Click += btnMaliyetHesapla_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(24, 69);
            label12.Name = "label12";
            label12.Size = new Size(32, 20);
            label12.TabIndex = 29;
            label12.Text = "Adı";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(24, 125);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 30;
            label13.Text = "Birimi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(24, 193);
            label14.Name = "label14";
            label14.Size = new Size(123, 20);
            label14.TabIndex = 31;
            label14.Text = "Elinizdeki Miktar";
            // 
            // EksikmaliyetDataGridView
            // 
            EksikmaliyetDataGridView.BackgroundColor = Color.MistyRose;
            EksikmaliyetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EksikmaliyetDataGridView.Location = new Point(371, 312);
            EksikmaliyetDataGridView.Name = "EksikmaliyetDataGridView";
            EksikmaliyetDataGridView.RowHeadersWidth = 51;
            EksikmaliyetDataGridView.Size = new Size(324, 207);
            EksikmaliyetDataGridView.TabIndex = 32;
            // 
            // AramaFiltreleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1280, 717);
            Controls.Add(EksikmaliyetDataGridView);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnMaliyetHesapla);
            Controls.Add(label11);
            Controls.Add(MalzemeMiktar);
            Controls.Add(MalzemeBirimiCmb);
            Controls.Add(dataGridEslestirilenTarifler);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(MalzemeCOmboBOxx);
            Controls.Add(KategoriComboBox);
            Controls.Add(Filtreleme);
            Controls.Add(HazırlanmaSuresiComboBox);
            Controls.Add(TarifleriGÖsterList);
            Controls.Add(TarifArabtn);
            Controls.Add(label4);
            Controls.Add(TarifAdıAraTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MzmAraBtn);
            Controls.Add(label1);
            Controls.Add(Malzeme_Listesi);
            Controls.Add(MalzmEkleBtn);
            Controls.Add(MalzemeTxt);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AramaFiltreleme";
            Text = "AramaFiltreleme";
            ((System.ComponentModel.ISupportInitialize)dataGridEslestirilenTarifler).EndInit();
            ((System.ComponentModel.ISupportInitialize)EksikmaliyetDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MalzemeTxt;
        private Button MalzmEkleBtn;
        private ListBox Malzeme_Listesi;
        private Label label1;
        private Button MzmAraBtn;
        private Label label2;
        private Label label3;
        private TextBox TarifAdıAraTxt;
        private Label label4;
        private Button TarifArabtn;
        private ListBox TarifleriGÖsterList;
        private ComboBox HazırlanmaSuresiComboBox;
        private ListBox Filtreleme;
        private ComboBox KategoriComboBox;
        private ComboBox MalzemeCOmboBOxx;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dataGridEslestirilenTarifler;
        private ComboBox MalzemeBirimiCmb;
        private TextBox MalzemeMiktar;
        private Label label11;
        private Button btnMaliyetHesapla;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridView EksikmaliyetDataGridView;
    }
}