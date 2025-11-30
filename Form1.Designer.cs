namespace Yazlab1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Tarif_Ekle = new Button();
            Tarif_Güncelle = new Button();
            Tarif_Sil = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Firebrick;
            dataGridView1.Location = new Point(483, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.MistyRose;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(724, 588);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(14, 107);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(395, 185);
            button1.TabIndex = 1;
            button1.Text = "Arama ve Filtreleme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(534, 28);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "TARİFLER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 123);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(373, 348);
            label3.Name = "label3";
            label3.Size = new Size(67, 26);
            label3.TabIndex = 4;
            label3.Text = "MENU";
            // 
            // Tarif_Ekle
            // 
            Tarif_Ekle.BackColor = Color.Linen;
            Tarif_Ekle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Tarif_Ekle.Location = new Point(357, 423);
            Tarif_Ekle.Margin = new Padding(3, 4, 3, 4);
            Tarif_Ekle.Name = "Tarif_Ekle";
            Tarif_Ekle.Size = new Size(104, 51);
            Tarif_Ekle.TabIndex = 5;
            Tarif_Ekle.Text = "Tarif Ekle";
            Tarif_Ekle.UseVisualStyleBackColor = false;
            Tarif_Ekle.Click += Tarif_Ekle_Click;
            // 
            // Tarif_Güncelle
            // 
            Tarif_Güncelle.BackColor = Color.Linen;
            Tarif_Güncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Tarif_Güncelle.Location = new Point(357, 499);
            Tarif_Güncelle.Margin = new Padding(3, 4, 3, 4);
            Tarif_Güncelle.Name = "Tarif_Güncelle";
            Tarif_Güncelle.Size = new Size(104, 51);
            Tarif_Güncelle.TabIndex = 6;
            Tarif_Güncelle.Text = "Tarif Güncelle";
            Tarif_Güncelle.UseVisualStyleBackColor = false;
            Tarif_Güncelle.Click += Tarif_Güncelle_Click;
            // 
            // Tarif_Sil
            // 
            Tarif_Sil.BackColor = Color.Linen;
            Tarif_Sil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Tarif_Sil.Location = new Point(357, 591);
            Tarif_Sil.Margin = new Padding(3, 4, 3, 4);
            Tarif_Sil.Name = "Tarif_Sil";
            Tarif_Sil.Size = new Size(104, 48);
            Tarif_Sil.TabIndex = 7;
            Tarif_Sil.Text = "Tarif_Sil";
            Tarif_Sil.UseVisualStyleBackColor = false;
            Tarif_Sil.Click += Tarif_Sil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 321);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(14, 51);
            label4.Name = "label4";
            label4.Size = new Size(449, 29);
            label4.TabIndex = 9;
            label4.Text = "ECEM İLE BERİL'İN SİHİRLİ LEZZETLERİ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1219, 677);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(Tarif_Sil);
            Controls.Add(Tarif_Güncelle);
            Controls.Add(Tarif_Ekle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Tarif_Ekle;
        private Button Tarif_Güncelle;
        private Button Tarif_Sil;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
