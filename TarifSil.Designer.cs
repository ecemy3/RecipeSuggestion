namespace Yazlab1
{
    partial class TarifSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifSil));
            TarifAdıTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Silbtn = new Button();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TarifAdıTxt
            // 
            TarifAdıTxt.BackColor = Color.Linen;
            TarifAdıTxt.ForeColor = SystemColors.WindowText;
            TarifAdıTxt.Location = new Point(476, 212);
            TarifAdıTxt.Margin = new Padding(3, 4, 3, 4);
            TarifAdıTxt.Name = "TarifAdıTxt";
            TarifAdıTxt.Size = new Size(159, 27);
            TarifAdıTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(284, 209);
            label1.Name = "label1";
            label1.Size = new Size(116, 26);
            label1.TabIndex = 1;
            label1.Text = "Tarif Adı";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(284, 284);
            label2.Name = "label2";
            label2.Size = new Size(121, 26);
            label2.TabIndex = 2;
            label2.Text = "Kategori";
            // 
            // Silbtn
            // 
            Silbtn.BackColor = Color.Linen;
            Silbtn.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Silbtn.ForeColor = Color.Firebrick;
            Silbtn.Location = new Point(383, 344);
            Silbtn.Margin = new Padding(3, 4, 3, 4);
            Silbtn.Name = "Silbtn";
            Silbtn.Size = new Size(135, 81);
            Silbtn.TabIndex = 4;
            Silbtn.Text = "Sil";
            Silbtn.UseVisualStyleBackColor = false;
            Silbtn.Click += Silbtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Linen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ana Yemek", "Çorba", "Salata", "Ara Sıcak", "Tatlı", "İçecek" });
            comboBox1.Location = new Point(476, 282);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(916, 602);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // TarifSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(914, 600);
            Controls.Add(comboBox1);
            Controls.Add(Silbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TarifAdıTxt);
            Controls.Add(pictureBox2);
            ForeColor = Color.MistyRose;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TarifSil";
            Text = "TarifSİl";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TarifAdıTxt;
        private Label label1;
        private Label label2;
        private Button Silbtn;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
    }
}