using Filmek.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmek
{
    public partial class FilmAdatlap : Form
    {
        private readonly Film film;

        public FilmAdatlap(Film film)
        {
            InitializeComponent();
            this.film = film;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Icon = Resources.filmIcon;
            Text = film.Cim;

            pbBorito.ImageLocation = film.BoritokepURL;

            lblCim.Text = film.Cim;
            lblIMDBErtekeles.Text = $"IMDB: {film.Ertekeles}";
            lblBemutatasEveEsHossza.Text = $"{film.BemutatasEve} · {film.Hossz}";
            lblMufajok.Text = string.Join(", ", film.Mufajok);
            lblLeiras.Text = film.Leiras;
            lblRendezok.Text = string.Join(", ", film.Rendezok);

            Dictionary<string, string> szereplok = film.Szereplok;
            string text = "";
            foreach (var kv in szereplok)
            {
                text += $"{kv.Key} ({kv.Value})\r\n";
            }

            lblSzereplok.Text = text;

            tlpRendezok.Update();
            tlpFilmAdatok.Update();
        }
    }
}
