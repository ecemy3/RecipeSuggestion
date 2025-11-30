namespace Yazlab1
{
    partial class TarifGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifGuncelle));
            label1 = new Label();
            TarifAdiCombo = new ComboBox();
            GuncelleGrid = new DataGridView();
            Guncelle = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)GuncelleGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(234, 98);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 0;
            label1.Text = "Tarif Adı";
            // 
            // TarifAdiCombo
            // 
            TarifAdiCombo.BackColor = Color.Linen;
            TarifAdiCombo.FormattingEnabled = true;
            TarifAdiCombo.Location = new Point(371, 98);
            TarifAdiCombo.Margin = new Padding(3, 4, 3, 4);
            TarifAdiCombo.Name = "TarifAdiCombo";
            TarifAdiCombo.Size = new Size(204, 28);
            TarifAdiCombo.TabIndex = 9;
            TarifAdiCombo.SelectedIndexChanged += TarifAdiCombo_SelectedIndexChanged;
            // 
            // GuncelleGrid
            // 
            GuncelleGrid.BackgroundColor = Color.OldLace;
            GuncelleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GuncelleGrid.Columns.AddRange(new DataGridViewColumn[] { Guncelle });
            GuncelleGrid.Location = new Point(2, 216);
            GuncelleGrid.Margin = new Padding(3, 4, 3, 4);
            GuncelleGrid.Name = "GuncelleGrid";
            GuncelleGrid.RowHeadersWidth = 51;
            GuncelleGrid.Size = new Size(910, 389);
            GuncelleGrid.TabIndex = 10;
            GuncelleGrid.CellContentClick += GuncelleGrid_CellContentClick;
            // 
            // Guncelle
            // 
            Guncelle.HeaderText = "Guncelle";
            Guncelle.MinimumWidth = 6;
            Guncelle.Name = "Guncelle";
            Guncelle.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(341, 24);
            label2.Name = "label2";
            label2.Size = new Size(234, 35);
            label2.TabIndex = 12;
            label2.Text = "TARİF GÜNCELLE";
            // 
            // TarifGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(GuncelleGrid);
            Controls.Add(TarifAdiCombo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TarifGuncelle";
            Text = "TarifGuncelle";
            ((System.ComponentModel.ISupportInitialize)GuncelleGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox TarifAdiCombo;
        private DataGridView GuncelleGrid;
        private DataGridViewButtonColumn Guncelle;
        private PictureBox pictureBox1;
        private Label label2;
    }
}