namespace Filmek
{
    partial class FilmekMain
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.filmCim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bemutatasEve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hossz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ertekeles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnHozzaadas = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(701, 427);
            this.panelMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 427);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbSearchYear);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbSearchText);
            this.panel2.Location = new System.Drawing.Point(194, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 48);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cím";
            // 
            // tbSearchYear
            // 
            this.tbSearchYear.Location = new System.Drawing.Point(394, 22);
            this.tbSearchYear.Name = "tbSearchYear";
            this.tbSearchYear.Size = new System.Drawing.Size(100, 23);
            this.tbSearchYear.TabIndex = 8;
            this.tbSearchYear.TextChanged += new System.EventHandler(this.OnSearchFieldsChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Év";
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(3, 22);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(385, 23);
            this.tbSearchText.TabIndex = 6;
            this.tbSearchText.TextChanged += new System.EventHandler(this.OnSearchFieldsChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filmek";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmCim,
            this.bemutatasEve,
            this.hossz,
            this.ertekeles});
            this.dgv.Location = new System.Drawing.Point(3, 63);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(695, 327);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnTableCellDoubleClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.OnTableSelectionChanged);
            // 
            // filmCim
            // 
            this.filmCim.HeaderText = "Cím";
            this.filmCim.Name = "filmCim";
            this.filmCim.ReadOnly = true;
            // 
            // bemutatasEve
            // 
            this.bemutatasEve.HeaderText = "Bemutatás éve";
            this.bemutatasEve.Name = "bemutatasEve";
            this.bemutatasEve.ReadOnly = true;
            // 
            // hossz
            // 
            this.hossz.HeaderText = "Hossz";
            this.hossz.Name = "hossz";
            this.hossz.ReadOnly = true;
            // 
            // ertekeles
            // 
            this.ertekeles.HeaderText = "Értékelés";
            this.ertekeles.Name = "ertekeles";
            this.ertekeles.ReadOnly = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.btnModositas);
            this.panelButtons.Controls.Add(this.btnTorles);
            this.panelButtons.Controls.Add(this.btnHozzaadas);
            this.panelButtons.Location = new System.Drawing.Point(455, 396);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(243, 28);
            this.panelButtons.TabIndex = 5;
            // 
            // btnModositas
            // 
            this.btnModositas.Enabled = false;
            this.btnModositas.Location = new System.Drawing.Point(165, 3);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(75, 23);
            this.btnModositas.TabIndex = 4;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.OnModositasClick);
            // 
            // btnTorles
            // 
            this.btnTorles.BackColor = System.Drawing.Color.Red;
            this.btnTorles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTorles.Enabled = false;
            this.btnTorles.ForeColor = System.Drawing.Color.White;
            this.btnTorles.Location = new System.Drawing.Point(6, 3);
            this.btnTorles.Margin = new System.Windows.Forms.Padding(0);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 3;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = false;
            this.btnTorles.Click += new System.EventHandler(this.OnTorlesClick);
            // 
            // btnHozzaadas
            // 
            this.btnHozzaadas.Location = new System.Drawing.Point(84, 3);
            this.btnHozzaadas.Name = "btnHozzaadas";
            this.btnHozzaadas.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaadas.TabIndex = 2;
            this.btnHozzaadas.Text = "Hozzáadás";
            this.btnHozzaadas.UseVisualStyleBackColor = true;
            this.btnHozzaadas.Click += new System.EventHandler(this.OnHozzaadasClick);
            // 
            // FilmekMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(701, 428);
            this.Controls.Add(this.panelMain);
            this.Name = "FilmekMain";
            this.Text = "Filmek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMain;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn filmCim;
        private DataGridViewTextBoxColumn bemutatasEve;
        private DataGridViewTextBoxColumn hossz;
        private DataGridViewTextBoxColumn ertekeles;
        private Label label1;
        private Button btnModositas;
        private Button btnTorles;
        private Button btnHozzaadas;
        private Panel panelButtons;
        private Label label2;
        private TextBox tbSearchText;
        private Label label3;
        private TextBox tbSearchYear;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}