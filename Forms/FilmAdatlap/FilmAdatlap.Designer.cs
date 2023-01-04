namespace Filmek
{
    partial class FilmAdatlap
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
            this.pbBorito = new System.Windows.Forms.PictureBox();
            this.lblCim = new System.Windows.Forms.Label();
            this.lblBemutatasEveEsHossza = new System.Windows.Forms.Label();
            this.tlpFilmAdatok = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMufajok = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMufajok = new System.Windows.Forms.Label();
            this.lblLeiras = new System.Windows.Forms.Label();
            this.tlpRendezok = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRendezok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSzereplok = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIMDBErtekeles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorito)).BeginInit();
            this.tlpFilmAdatok.SuspendLayout();
            this.tlpMufajok.SuspendLayout();
            this.tlpRendezok.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBorito
            // 
            this.pbBorito.ErrorImage = global::Filmek.Properties.Resources.cross;
            this.pbBorito.Image = global::Filmek.Properties.Resources.cross;
            this.pbBorito.InitialImage = global::Filmek.Properties.Resources.cross;
            this.pbBorito.Location = new System.Drawing.Point(12, 12);
            this.pbBorito.MaximumSize = new System.Drawing.Size(284, 426);
            this.pbBorito.Name = "pbBorito";
            this.pbBorito.Size = new System.Drawing.Size(284, 426);
            this.pbBorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBorito.TabIndex = 0;
            this.pbBorito.TabStop = false;
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCim.Location = new System.Drawing.Point(3, 0);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(95, 25);
            this.lblCim.TabIndex = 1;
            this.lblCim.Text = "Film címe";
            // 
            // lblBemutatasEveEsHossza
            // 
            this.lblBemutatasEveEsHossza.AutoSize = true;
            this.lblBemutatasEveEsHossza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBemutatasEveEsHossza.Location = new System.Drawing.Point(3, 27);
            this.lblBemutatasEveEsHossza.Name = "lblBemutatasEveEsHossza";
            this.lblBemutatasEveEsHossza.Size = new System.Drawing.Size(153, 17);
            this.lblBemutatasEveEsHossza.TabIndex = 2;
            this.lblBemutatasEveEsHossza.Text = "(megjelenés éve, hossza)";
            // 
            // tlpFilmAdatok
            // 
            this.tlpFilmAdatok.ColumnCount = 1;
            this.tlpFilmAdatok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilmAdatok.Controls.Add(this.tlpMufajok, 0, 3);
            this.tlpFilmAdatok.Controls.Add(this.lblBemutatasEveEsHossza, 0, 1);
            this.tlpFilmAdatok.Controls.Add(this.lblLeiras, 0, 4);
            this.tlpFilmAdatok.Controls.Add(this.tlpRendezok, 0, 6);
            this.tlpFilmAdatok.Controls.Add(this.label2, 0, 7);
            this.tlpFilmAdatok.Controls.Add(this.lblSzereplok, 0, 8);
            this.tlpFilmAdatok.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpFilmAdatok.Location = new System.Drawing.Point(302, 12);
            this.tlpFilmAdatok.Name = "tlpFilmAdatok";
            this.tlpFilmAdatok.RowCount = 9;
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilmAdatok.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilmAdatok.Size = new System.Drawing.Size(486, 426);
            this.tlpFilmAdatok.TabIndex = 3;
            // 
            // tlpMufajok
            // 
            this.tlpMufajok.ColumnCount = 2;
            this.tlpMufajok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMufajok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMufajok.Controls.Add(this.label3, 0, 0);
            this.tlpMufajok.Controls.Add(this.lblMufajok, 1, 0);
            this.tlpMufajok.Location = new System.Drawing.Point(0, 54);
            this.tlpMufajok.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMufajok.Name = "tlpMufajok";
            this.tlpMufajok.RowCount = 1;
            this.tlpMufajok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMufajok.Size = new System.Drawing.Size(480, 30);
            this.tlpMufajok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Műfaj(ok):";
            // 
            // lblMufajok
            // 
            this.lblMufajok.AutoSize = true;
            this.lblMufajok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMufajok.Location = new System.Drawing.Point(87, 0);
            this.lblMufajok.Name = "lblMufajok";
            this.lblMufajok.Size = new System.Drawing.Size(59, 19);
            this.lblMufajok.TabIndex = 1;
            this.lblMufajok.Text = "Műfajok";
            // 
            // lblLeiras
            // 
            this.lblLeiras.AutoSize = true;
            this.lblLeiras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeiras.Location = new System.Drawing.Point(3, 84);
            this.lblLeiras.Name = "lblLeiras";
            this.lblLeiras.Size = new System.Drawing.Size(86, 19);
            this.lblLeiras.TabIndex = 3;
            this.lblLeiras.Text = "A film leírása";
            // 
            // tlpRendezok
            // 
            this.tlpRendezok.ColumnCount = 2;
            this.tlpRendezok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRendezok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRendezok.Controls.Add(this.label1, 0, 0);
            this.tlpRendezok.Controls.Add(this.lblRendezok, 1, 0);
            this.tlpRendezok.Location = new System.Drawing.Point(0, 113);
            this.tlpRendezok.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRendezok.Name = "tlpRendezok";
            this.tlpRendezok.RowCount = 1;
            this.tlpRendezok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRendezok.Size = new System.Drawing.Size(480, 30);
            this.tlpRendezok.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendező(k):";
            // 
            // lblRendezok
            // 
            this.lblRendezok.AutoSize = true;
            this.lblRendezok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRendezok.Location = new System.Drawing.Point(98, 0);
            this.lblRendezok.Name = "lblRendezok";
            this.lblRendezok.Size = new System.Drawing.Size(76, 19);
            this.lblRendezok.TabIndex = 1;
            this.lblRendezok.Text = "Rendező(k)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Főbb szereplők:";
            // 
            // lblSzereplok
            // 
            this.lblSzereplok.AutoSize = true;
            this.lblSzereplok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSzereplok.Location = new System.Drawing.Point(3, 162);
            this.lblSzereplok.Name = "lblSzereplok";
            this.lblSzereplok.Size = new System.Drawing.Size(143, 19);
            this.lblSzereplok.TabIndex = 0;
            this.lblSzereplok.Text = "Színészek és szerepeik";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblCim, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIMDBErtekeles, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 27);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblIMDBErtekeles
            // 
            this.lblIMDBErtekeles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIMDBErtekeles.AutoSize = true;
            this.lblIMDBErtekeles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIMDBErtekeles.Location = new System.Drawing.Point(436, 0);
            this.lblIMDBErtekeles.Name = "lblIMDBErtekeles";
            this.lblIMDBErtekeles.Size = new System.Drawing.Size(47, 27);
            this.lblIMDBErtekeles.TabIndex = 2;
            this.lblIMDBErtekeles.Text = "IMDB:";
            this.lblIMDBErtekeles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilmAdatlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpFilmAdatok);
            this.Controls.Add(this.pbBorito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FilmAdatlap";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pbBorito)).EndInit();
            this.tlpFilmAdatok.ResumeLayout(false);
            this.tlpFilmAdatok.PerformLayout();
            this.tlpMufajok.ResumeLayout(false);
            this.tlpMufajok.PerformLayout();
            this.tlpRendezok.ResumeLayout(false);
            this.tlpRendezok.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbBorito;
        private Label lblCim;
        private Label lblBemutatasEveEsHossza;
        private TableLayoutPanel tlpFilmAdatok;
        private Label lblLeiras;
        private TableLayoutPanel tlpRendezok;
        private Label label1;
        private Label label2;
        private Label lblSzereplok;
        private TableLayoutPanel tlpMufajok;
        private Label label3;
        private Label lblMufajok;
        private Label lblRendezok;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblIMDBErtekeles;
    }
}