namespace KisiselBilgiler
{
    partial class Form1
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
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.tb_Isim = new System.Windows.Forms.TextBox();
            this.tb_SoyIsim = new System.Windows.Forms.TextBox();
            this.lbl_SoyIsim = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.tb_Tel = new System.Windows.Forms.MaskedTextBox();
            this.tb_TC = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.tb_Sehir = new System.Windows.Forms.Label();
            this.cb_Sehirler = new System.Windows.Forms.ComboBox();
            this.cb_Ilceler = new System.Windows.Forms.ComboBox();
            this.lbl_Ilce = new System.Windows.Forms.Label();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.cb_Universiteler = new System.Windows.Forms.ComboBox();
            this.lbl_Universite = new System.Windows.Forms.Label();
            this.cb_Fakulteler = new System.Windows.Forms.ComboBox();
            this.lbl_Fakulte = new System.Windows.Forms.Label();
            this.cb_Bolumler = new System.Windows.Forms.ComboBox();
            this.lbl_Bolumler = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(86, 70);
            this.lbl_Ad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(53, 25);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "İsim:";
            // 
            // tb_Isim
            // 
            this.tb_Isim.Location = new System.Drawing.Point(147, 65);
            this.tb_Isim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_Isim.Name = "tb_Isim";
            this.tb_Isim.Size = new System.Drawing.Size(220, 29);
            this.tb_Isim.TabIndex = 1;
            this.tb_Isim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Isim_KeyPress);
            // 
            // tb_SoyIsim
            // 
            this.tb_SoyIsim.Location = new System.Drawing.Point(147, 113);
            this.tb_SoyIsim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_SoyIsim.Name = "tb_SoyIsim";
            this.tb_SoyIsim.Size = new System.Drawing.Size(220, 29);
            this.tb_SoyIsim.TabIndex = 3;
            this.tb_SoyIsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SoyIsim_KeyPress);
            // 
            // lbl_SoyIsim
            // 
            this.lbl_SoyIsim.AutoSize = true;
            this.lbl_SoyIsim.Location = new System.Drawing.Point(48, 118);
            this.lbl_SoyIsim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_SoyIsim.Name = "lbl_SoyIsim";
            this.lbl_SoyIsim.Size = new System.Drawing.Size(88, 25);
            this.lbl_SoyIsim.TabIndex = 2;
            this.lbl_SoyIsim.Text = "Soyİsim:";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(53, 172);
            this.lbl_Telefon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(84, 25);
            this.lbl_Telefon.TabIndex = 4;
            this.lbl_Telefon.Text = "Telefon:";
            // 
            // tb_Tel
            // 
            this.tb_Tel.Location = new System.Drawing.Point(147, 166);
            this.tb_Tel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_Tel.Mask = "(999) 000-0000";
            this.tb_Tel.Name = "tb_Tel";
            this.tb_Tel.Size = new System.Drawing.Size(143, 29);
            this.tb_Tel.TabIndex = 5;
            this.tb_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tel_KeyPress);
            // 
            // tb_TC
            // 
            this.tb_TC.Location = new System.Drawing.Point(147, 214);
            this.tb_TC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_TC.Mask = "99999999999";
            this.tb_TC.Name = "tb_TC";
            this.tb_TC.Size = new System.Drawing.Size(143, 29);
            this.tb_TC.TabIndex = 7;
            this.tb_TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TC_KeyPress);
            this.tb_TC.Validating += new System.ComponentModel.CancelEventHandler(this.tb_TC_Validating);
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(59, 220);
            this.lbl_TC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(81, 25);
            this.lbl_TC.TabIndex = 6;
            this.lbl_TC.Text = "TC NO:";
            // 
            // tb_Sehir
            // 
            this.tb_Sehir.AutoSize = true;
            this.tb_Sehir.Location = new System.Drawing.Point(55, 279);
            this.tb_Sehir.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tb_Sehir.Name = "tb_Sehir";
            this.tb_Sehir.Size = new System.Drawing.Size(85, 25);
            this.tb_Sehir.TabIndex = 8;
            this.tb_Sehir.Text = "Şehirler:";
            // 
            // cb_Sehirler
            // 
            this.cb_Sehirler.FormattingEnabled = true;
            this.cb_Sehirler.Location = new System.Drawing.Point(148, 273);
            this.cb_Sehirler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Sehirler.Name = "cb_Sehirler";
            this.cb_Sehirler.Size = new System.Drawing.Size(218, 32);
            this.cb_Sehirler.TabIndex = 9;
            this.cb_Sehirler.SelectedIndexChanged += new System.EventHandler(this.cb_Sehirler_SelectedIndexChanged);
            // 
            // cb_Ilceler
            // 
            this.cb_Ilceler.FormattingEnabled = true;
            this.cb_Ilceler.Location = new System.Drawing.Point(148, 340);
            this.cb_Ilceler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Ilceler.Name = "cb_Ilceler";
            this.cb_Ilceler.Size = new System.Drawing.Size(218, 32);
            this.cb_Ilceler.TabIndex = 11;
            // 
            // lbl_Ilce
            // 
            this.lbl_Ilce.AutoSize = true;
            this.lbl_Ilce.Location = new System.Drawing.Point(68, 345);
            this.lbl_Ilce.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Ilce.Name = "lbl_Ilce";
            this.lbl_Ilce.Size = new System.Drawing.Size(69, 25);
            this.lbl_Ilce.TabIndex = 10;
            this.lbl_Ilce.Text = "İlçeler:";
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Location = new System.Drawing.Point(70, 450);
            this.lbl_Adres.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(70, 25);
            this.lbl_Adres.TabIndex = 12;
            this.lbl_Adres.Text = "Adres:";
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(148, 406);
            this.tb_Adres.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_Adres.Multiline = true;
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(385, 113);
            this.tb_Adres.TabIndex = 13;
            // 
            // cb_Universiteler
            // 
            this.cb_Universiteler.FormattingEnabled = true;
            this.cb_Universiteler.Location = new System.Drawing.Point(182, 565);
            this.cb_Universiteler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Universiteler.Name = "cb_Universiteler";
            this.cb_Universiteler.Size = new System.Drawing.Size(356, 32);
            this.cb_Universiteler.TabIndex = 15;
            this.cb_Universiteler.SelectedIndexChanged += new System.EventHandler(this.cb_Universiteler_SelectedIndexChanged);
            // 
            // lbl_Universite
            // 
            this.lbl_Universite.AutoSize = true;
            this.lbl_Universite.Location = new System.Drawing.Point(66, 570);
            this.lbl_Universite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Universite.Name = "lbl_Universite";
            this.lbl_Universite.Size = new System.Drawing.Size(104, 25);
            this.lbl_Universite.TabIndex = 14;
            this.lbl_Universite.Text = "Üniversite:";
            // 
            // cb_Fakulteler
            // 
            this.cb_Fakulteler.FormattingEnabled = true;
            this.cb_Fakulteler.Location = new System.Drawing.Point(182, 615);
            this.cb_Fakulteler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Fakulteler.Name = "cb_Fakulteler";
            this.cb_Fakulteler.Size = new System.Drawing.Size(356, 32);
            this.cb_Fakulteler.TabIndex = 17;
            this.cb_Fakulteler.SelectedIndexChanged += new System.EventHandler(this.cb_Fakulteler_SelectedIndexChanged);
            // 
            // lbl_Fakulte
            // 
            this.lbl_Fakulte.AutoSize = true;
            this.lbl_Fakulte.Location = new System.Drawing.Point(66, 620);
            this.lbl_Fakulte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Fakulte.Name = "lbl_Fakulte";
            this.lbl_Fakulte.Size = new System.Drawing.Size(82, 25);
            this.lbl_Fakulte.TabIndex = 16;
            this.lbl_Fakulte.Text = "Fakülte:";
            // 
            // cb_Bolumler
            // 
            this.cb_Bolumler.FormattingEnabled = true;
            this.cb_Bolumler.Location = new System.Drawing.Point(182, 665);
            this.cb_Bolumler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Bolumler.Name = "cb_Bolumler";
            this.cb_Bolumler.Size = new System.Drawing.Size(351, 32);
            this.cb_Bolumler.TabIndex = 19;
            // 
            // lbl_Bolumler
            // 
            this.lbl_Bolumler.AutoSize = true;
            this.lbl_Bolumler.Location = new System.Drawing.Point(66, 670);
            this.lbl_Bolumler.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Bolumler.Name = "lbl_Bolumler";
            this.lbl_Bolumler.Size = new System.Drawing.Size(94, 25);
            this.lbl_Bolumler.TabIndex = 18;
            this.lbl_Bolumler.Text = "Bölümler:";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(182, 750);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(356, 42);
            this.btn_Kaydet.TabIndex = 20;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 831);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.cb_Bolumler);
            this.Controls.Add(this.lbl_Bolumler);
            this.Controls.Add(this.cb_Fakulteler);
            this.Controls.Add(this.lbl_Fakulte);
            this.Controls.Add(this.cb_Universiteler);
            this.Controls.Add(this.lbl_Universite);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.cb_Ilceler);
            this.Controls.Add(this.lbl_Ilce);
            this.Controls.Add(this.cb_Sehirler);
            this.Controls.Add(this.tb_Sehir);
            this.Controls.Add(this.tb_TC);
            this.Controls.Add(this.lbl_TC);
            this.Controls.Add(this.tb_Tel);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.tb_SoyIsim);
            this.Controls.Add(this.lbl_SoyIsim);
            this.Controls.Add(this.tb_Isim);
            this.Controls.Add(this.lbl_Ad);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.TextBox tb_Isim;
        private System.Windows.Forms.TextBox tb_SoyIsim;
        private System.Windows.Forms.Label lbl_SoyIsim;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.MaskedTextBox tb_Tel;
        private System.Windows.Forms.MaskedTextBox tb_TC;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label tb_Sehir;
        private System.Windows.Forms.ComboBox cb_Sehirler;
        private System.Windows.Forms.ComboBox cb_Ilceler;
        private System.Windows.Forms.Label lbl_Ilce;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.ComboBox cb_Universiteler;
        private System.Windows.Forms.Label lbl_Universite;
        private System.Windows.Forms.ComboBox cb_Fakulteler;
        private System.Windows.Forms.Label lbl_Fakulte;
        private System.Windows.Forms.ComboBox cb_Bolumler;
        private System.Windows.Forms.Label lbl_Bolumler;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}

