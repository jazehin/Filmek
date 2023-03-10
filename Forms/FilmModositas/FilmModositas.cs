using Filmek.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmek
{
    public partial class FilmModositas : Form
    {
        private Film film;
        public FilmModositas(Film film)
        {
            InitializeComponent();
            this.film = film;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Icon = Resources.editIcon;
            Text = $"{film.Cim} módosítása";

            tbCim.Text = film.Cim;
            tbBemutatasEve.Text = film.BemutatasEve.ToString();
            tbIMDBRating.Text = film.Ertekeles.ToString();
            tbHossz.Text = film.HosszPercben.ToString();
            tbLeiras.Text = film.Leiras;
            tbKepURL.Text = film.BoritokepURL;

            // műfajok beolvasása
            clbMufajok.Items.Clear();
            string mufajokSql = "SELECT DISTINCT mufajNev, mufajID FROM mufajok ORDER BY mufajID ASC;";
            FilmekMain.connection.Open();
            SqlDataReader reader = new SqlCommand(mufajokSql, FilmekMain.connection).ExecuteReader();
            while (reader.Read())
            {
                clbMufajok.Items.Add(reader.GetString(0));
            }
            reader.Close();
            FilmekMain.connection.Close();

            foreach (string mufaj in film.Mufajok)
            {
                clbMufajok.SetItemChecked(clbMufajok.Items.IndexOf(mufaj), true);
            }

            // rendezők
            clbRendezok.Items.Clear();
            List<string> rendezok = film.Rendezok;

            for (int i = 0; i < rendezok.Count; i++)
            {
                clbRendezok.Items.Add(rendezok[i]);
                clbRendezok.SetItemChecked(i, true);
            }

            // szereplők
            clbSzereplok.Items.Clear();
            Dictionary<string, string> szereplok = film.Szereplok;

            for (int i = 0; i < szereplok.Count; i++)
            {
                var szereplo = szereplok.ElementAt(i); // színész -> szerep
                clbSzereplok.Items.Add($"{szereplo.Key} ({szereplo.Value})");
                clbSzereplok.SetItemChecked(i, true);
            }
        }

        private void OnRendezoHozzaadClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUjRendezo.Text))
            {
                MessageBox.Show("A rendező mező nem maradhat üresen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clbRendezok.Items.Add(tbUjRendezo.Text);
            clbRendezok.SetItemChecked(clbRendezok.Items.Count - 1, true);

            tbUjRendezo.Text = "";
        }

        private void OnSzereploHozzaadClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUjSzinesz.Text) || string.IsNullOrWhiteSpace(tbUjSzerep.Text))
            {
                MessageBox.Show("Sem a színész, sem a szerep mező nem maradhat üresen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbUjSzinesz.Text.Contains('(') || tbUjSzinesz.Text.Contains(')') || tbUjSzerep.Text.Contains('(') || tbUjSzerep.Text.Contains(')'))
            {
                MessageBox.Show("Sem a színész, sem a szerep nem tartamazhatja a '(' és ')' karaktereket!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clbSzereplok.Items.Add($"{tbUjSzinesz.Text} ({tbUjSzerep.Text})");
            clbSzereplok.SetItemChecked(clbSzereplok.Items.Count - 1, true);

            tbUjSzinesz.Text = "";
            tbUjSzerep.Text = "";
        }

        private void OnMentesClick(object sender, EventArgs e)
        {
            if (!AreFieldsValid()) return;

            string cim = tbCim.Text.Trim();
            int bemutatasEve = int.Parse(tbBemutatasEve.Text.Trim());
            decimal ertekeles = decimal.Parse(tbIMDBRating.Text.Trim().Replace('.', ','));
            int hosszPercben = int.Parse(tbHossz.Text.Trim());
            List<string> mufajok = clbMufajok.CheckedItems.Cast<string>().ToList();
            List<string> rendezok = clbRendezok.CheckedItems.Cast<string>().ToList();
            Dictionary<string, string> szereplok = new();
            foreach (string szoveg in clbSzereplok.CheckedItems.Cast<string>())
            {
                string szinesz = szoveg.Substring(0, szoveg.IndexOf('(') - 1);
                string szerep = szoveg.Substring(szoveg.IndexOf('(') + 1, szoveg.Length - szoveg.IndexOf('(') - 2);

                if (szereplok.Keys.Contains(szinesz))
                {
                    MessageBox.Show("Ha egy színész több szerepet is játszik, kérem a szerep mezőben vesszővel sorolja fel azokat.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                szereplok.Add(szinesz.Trim(), szerep.Trim());
            }
            string leiras = tbLeiras.Text.Trim();
            string kepURL = tbKepURL.Text.Trim();

            Film ujFilm = new(cim, bemutatasEve, hosszPercben, ertekeles, leiras, kepURL, mufajok, rendezok, szereplok);

            FilmekMain.DeleteFilm(film);
            FilmekMain.AddFilm(ujFilm);
            MessageBox.Show("A módosítás sikeresen megtörtént!");
            Dispose();
        }

        private bool AreFieldsValid()
        {
            if (string.IsNullOrWhiteSpace(tbCim.Text.Trim()))
            {
                MessageBox.Show("A film címe nem lehet üres.", "Üres cím", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tbCim.Text.Trim().Length > 100)
            {
                MessageBox.Show("Túl hosszú a film címe.", "Hosszú cím", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Film.IsValidYear(tbBemutatasEve.Text.Trim()))
            {
                MessageBox.Show("Érvénytelen évszámot adott meg a bemutatás évének.", "Hibás évszám", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Film.IsValidRating(tbIMDBRating.Text.Trim().Replace('.', ',')))
            {
                MessageBox.Show("Érvénytelen IMDB értékelés.", "Hibás értékelés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Film.isValidLength(tbHossz.Text.Trim()))
            {
                MessageBox.Show("Érvénytelen filmhossz.", "Hibás hossz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clbMufajok.CheckedItems.Count == 0)
            {
                MessageBox.Show("Jelöljön meg legalább egy műfajt.", "Hiányzó műfajok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clbRendezok.CheckedItems.Count == 0)
            {
                MessageBox.Show("Jelöljön meg legalább egy rendezőt.", "Hiányzó rendezők", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clbSzereplok.CheckedItems.Count == 0)
            {
                MessageBox.Show("Jelöljön meg legalább egy színész-szereplő párost.", "Hiányzó szereplők", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void OnMegseClick(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
