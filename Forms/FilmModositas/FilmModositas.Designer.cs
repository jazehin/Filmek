namespace Filmek
{
    partial class FilmModositas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmModositas));
            this.label1 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.tbBemutatasEve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIMDBRating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHossz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clbMufajok = new System.Windows.Forms.CheckedListBox();
            this.gbRendezok = new System.Windows.Forms.GroupBox();
            this.btnRendezoHozzaad = new System.Windows.Forms.Button();
            this.tbUjRendezo = new System.Windows.Forms.TextBox();
            this.clbRendezok = new System.Windows.Forms.CheckedListBox();
            this.gbSzereplok = new System.Windows.Forms.GroupBox();
            this.tbUjSzerep = new System.Windows.Forms.TextBox();
            this.btnSzereploHozzaad = new System.Windows.Forms.Button();
            this.tbUjSzinesz = new System.Windows.Forms.TextBox();
            this.clbSzereplok = new System.Windows.Forms.CheckedListBox();
            this.tbLeiras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKepURL = new System.Windows.Forms.TextBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gbRendezok.SuspendLayout();
            this.gbSzereplok.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(47, 18);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(218, 23);
            this.tbCim.TabIndex = 1;
            // 
            // tbBemutatasEve
            // 
            this.tbBemutatasEve.Location = new System.Drawing.Point(102, 47);
            this.tbBemutatasEve.MaxLength = 4;
            this.tbBemutatasEve.Name = "tbBemutatasEve";
            this.tbBemutatasEve.Size = new System.Drawing.Size(73, 23);
            this.tbBemutatasEve.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bemutatás éve";
            // 
            // tbIMDBRating
            // 
            this.tbIMDBRating.Location = new System.Drawing.Point(102, 76);
            this.tbIMDBRating.MaxLength = 4;
            this.tbIMDBRating.Name = "tbIMDBRating";
            this.tbIMDBRating.Size = new System.Drawing.Size(73, 23);
            this.tbIMDBRating.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "IMDB értékelés";
            // 
            // tbHossz
            // 
            this.tbHossz.Location = new System.Drawing.Point(110, 105);
            this.tbHossz.MaxLength = 3;
            this.tbHossz.Name = "tbHossz";
            this.tbHossz.Size = new System.Drawing.Size(65, 23);
            this.tbHossz.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hossz (percben)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Műfaj(ok) (jelölje be az összes vonatkozót)";
            // 
            // clbMufajok
            // 
            this.clbMufajok.FormattingEnabled = true;
            this.clbMufajok.Location = new System.Drawing.Point(12, 165);
            this.clbMufajok.Name = "clbMufajok";
            this.clbMufajok.Size = new System.Drawing.Size(253, 274);
            this.clbMufajok.TabIndex = 9;
            // 
            // gbRendezok
            // 
            this.gbRendezok.Controls.Add(this.btnRendezoHozzaad);
            this.gbRendezok.Controls.Add(this.tbUjRendezo);
            this.gbRendezok.Controls.Add(this.clbRendezok);
            this.gbRendezok.Location = new System.Drawing.Point(314, 6);
            this.gbRendezok.Name = "gbRendezok";
            this.gbRendezok.Size = new System.Drawing.Size(262, 134);
            this.gbRendezok.TabIndex = 10;
            this.gbRendezok.TabStop = false;
            this.gbRendezok.Text = "Rendező(k)";
            // 
            // btnRendezoHozzaad
            // 
            this.btnRendezoHozzaad.Location = new System.Drawing.Point(190, 104);
            this.btnRendezoHozzaad.Name = "btnRendezoHozzaad";
            this.btnRendezoHozzaad.Size = new System.Drawing.Size(66, 23);
            this.btnRendezoHozzaad.TabIndex = 12;
            this.btnRendezoHozzaad.Text = "Hozzáad";
            this.btnRendezoHozzaad.UseVisualStyleBackColor = true;
            this.btnRendezoHozzaad.Click += new System.EventHandler(this.OnRendezoHozzaadClick);
            // 
            // tbUjRendezo
            // 
            this.tbUjRendezo.Location = new System.Drawing.Point(6, 104);
            this.tbUjRendezo.Name = "tbUjRendezo";
            this.tbUjRendezo.PlaceholderText = "Új rendező neve";
            this.tbUjRendezo.Size = new System.Drawing.Size(178, 23);
            this.tbUjRendezo.TabIndex = 11;
            // 
            // clbRendezok
            // 
            this.clbRendezok.FormattingEnabled = true;
            this.clbRendezok.Location = new System.Drawing.Point(6, 22);
            this.clbRendezok.Name = "clbRendezok";
            this.clbRendezok.Size = new System.Drawing.Size(250, 76);
            this.clbRendezok.TabIndex = 0;
            // 
            // gbSzereplok
            // 
            this.gbSzereplok.Controls.Add(this.tbUjSzerep);
            this.gbSzereplok.Controls.Add(this.btnSzereploHozzaad);
            this.gbSzereplok.Controls.Add(this.tbUjSzinesz);
            this.gbSzereplok.Controls.Add(this.clbSzereplok);
            this.gbSzereplok.Location = new System.Drawing.Point(314, 147);
            this.gbSzereplok.Name = "gbSzereplok";
            this.gbSzereplok.Size = new System.Drawing.Size(262, 291);
            this.gbSzereplok.TabIndex = 13;
            this.gbSzereplok.TabStop = false;
            this.gbSzereplok.Text = "Szereplők";
            // 
            // tbUjSzerep
            // 
            this.tbUjSzerep.Location = new System.Drawing.Point(6, 261);
            this.tbUjSzerep.Name = "tbUjSzerep";
            this.tbUjSzerep.PlaceholderText = "Szerep(lő neve)";
            this.tbUjSzerep.Size = new System.Drawing.Size(178, 23);
            this.tbUjSzerep.TabIndex = 13;
            // 
            // btnSzereploHozzaad
            // 
            this.btnSzereploHozzaad.Location = new System.Drawing.Point(190, 232);
            this.btnSzereploHozzaad.Name = "btnSzereploHozzaad";
            this.btnSzereploHozzaad.Size = new System.Drawing.Size(66, 52);
            this.btnSzereploHozzaad.TabIndex = 12;
            this.btnSzereploHozzaad.Text = "Hozzáad";
            this.btnSzereploHozzaad.UseVisualStyleBackColor = true;
            this.btnSzereploHozzaad.Click += new System.EventHandler(this.OnSzereploHozzaadClick);
            // 
            // tbUjSzinesz
            // 
            this.tbUjSzinesz.Location = new System.Drawing.Point(6, 232);
            this.tbUjSzinesz.Name = "tbUjSzinesz";
            this.tbUjSzinesz.PlaceholderText = "Új (szinkron)színész neve";
            this.tbUjSzinesz.Size = new System.Drawing.Size(178, 23);
            this.tbUjSzinesz.TabIndex = 11;
            // 
            // clbSzereplok
            // 
            this.clbSzereplok.FormattingEnabled = true;
            this.clbSzereplok.Location = new System.Drawing.Point(6, 22);
            this.clbSzereplok.Name = "clbSzereplok";
            this.clbSzereplok.Size = new System.Drawing.Size(250, 202);
            this.clbSzereplok.TabIndex = 0;
            // 
            // tbLeiras
            // 
            this.tbLeiras.Location = new System.Drawing.Point(625, 27);
            this.tbLeiras.Multiline = true;
            this.tbLeiras.Name = "tbLeiras";
            this.tbLeiras.Size = new System.Drawing.Size(284, 326);
            this.tbLeiras.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Leírás";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Plakát kép URL";
            // 
            // tbKepURL
            // 
            this.tbKepURL.Location = new System.Drawing.Point(625, 374);
            this.tbKepURL.Multiline = true;
            this.tbKepURL.Name = "tbKepURL";
            this.tbKepURL.Size = new System.Drawing.Size(284, 65);
            this.tbKepURL.TabIndex = 17;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(834, 450);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 18;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.OnMentesClick);
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(753, 450);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 19;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.OnMegseClick);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(735, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // FilmModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(921, 480);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.tbKepURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLeiras);
            this.Controls.Add(this.gbSzereplok);
            this.Controls.Add(this.gbRendezok);
            this.Controls.Add(this.clbMufajok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHossz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIMDBRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBemutatasEve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FilmModositas";
            this.Text = "Film módosítása";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.gbRendezok.ResumeLayout(false);
            this.gbRendezok.PerformLayout();
            this.gbSzereplok.ResumeLayout(false);
            this.gbSzereplok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbCim;
        private TextBox tbBemutatasEve;
        private Label label2;
        private TextBox tbIMDBRating;
        private Label label3;
        private TextBox tbHossz;
        private Label label4;
        private Label label5;
        private CheckedListBox clbMufajok;
        private GroupBox gbRendezok;
        private Button btnRendezoHozzaad;
        private TextBox tbUjRendezo;
        private CheckedListBox clbRendezok;
        private GroupBox gbSzereplok;
        private TextBox tbUjSzerep;
        private Button btnSzereploHozzaad;
        private TextBox tbUjSzinesz;
        private CheckedListBox clbSzereplok;
        private TextBox tbLeiras;
        private Label label6;
        private Label label7;
        private TextBox tbKepURL;
        private Button btnMentes;
        private Button btnMegse;
        private Label label8;
    }
}