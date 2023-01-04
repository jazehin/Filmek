using Filmek.Properties;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace Filmek
{
    public partial class FilmekMain : Form
    {
        public static SqlConnection connection;
        private SqlConnection listConnection;
        private List<Film> filmek;
        private string whereClause = "1=1 AND 1=1";
        
        public FilmekMain()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Icon = Resources.filmIcon;
            connection = new SqlConnection(Resources.ConnectionString);
            listConnection = new SqlConnection(Resources.ConnectionString);
            filmek = new();
            ReadFilms();
            RefreshTable();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            listConnection.Close();
        }

        private void ReadFilms()
        {
            filmek.Clear();

            connection.Open();
            SqlDataReader filmReader = new SqlCommand($"SELECT * FROM filmek WHERE {whereClause};", connection).ExecuteReader();

            while (filmReader.Read())
            {
                #region alapadatok olvasása
                int id = filmReader.GetInt32("filmID");
                string cim = filmReader.GetString("filmCim");
                int bemutatasEve = filmReader.GetInt32("bemutatasEve");
                int hosszPercben = filmReader.GetInt32("hosszPercben");
                decimal ertekeles = filmReader.GetDecimal("ertekeles");
                string leiras = filmReader.GetString("leiras");
                string boritokepURL = filmReader.GetString("boritokepURL");
                #endregion

                listConnection.Open();

                #region műfajok olvasása
                List<string> mufajok = new();
                SqlDataReader mufajReader = new SqlCommand($"SELECT mufajok.mufajNev " +
                    $"FROM mufajok INNER JOIN filmek_mufajok ON mufajok.mufajID = filmek_mufajok.mufajID " +
                    $"WHERE filmek_mufajok.filmID = {id};", listConnection).ExecuteReader();

                while (mufajReader.Read())
                {
                    mufajok.Add(mufajReader.GetString("mufajNev"));
                }

                mufajReader.Close();
                #endregion

                #region rendezők olvasása
                List<string> rendezok = new();
                SqlDataReader rendezokReader = new SqlCommand($"SELECT rendezok.rendezoNev " +
                    $"FROM rendezok INNER JOIN filmek_rendezok ON rendezok.rendezoID = filmek_rendezok.rendezoID " +
                    $"WHERE filmek_rendezok.filmID = {id};", listConnection).ExecuteReader();

                while (rendezokReader.Read())
                {
                    rendezok.Add(rendezokReader.GetString("rendezoNev"));
                }

                rendezokReader.Close();
                #endregion

                #region szereplők olvasása
                Dictionary<string, string> szereplok = new();
                SqlDataReader szereploReader =
                    new SqlCommand($"SELECT szineszek.szineszNev, filmek_szineszek.szereploNev " +
                    $"FROM szineszek INNER JOIN filmek_szineszek ON szineszek.szineszID = filmek_szineszek.szineszID " +
                    $"WHERE filmek_szineszek.filmID = {id};", listConnection).ExecuteReader();

                while (szereploReader.Read())
                {
                    szereplok.Add(szereploReader.GetString("szineszNev"), szereploReader.GetString("szereploNev"));
                }

                szereploReader.Close();
                #endregion

                listConnection.Close();

                Film film = new Film(id, cim, bemutatasEve, hosszPercben, ertekeles, leiras, boritokepURL, mufajok, rendezok, szereplok);

                filmek.Add(film);
            }

            filmReader.Close();
            connection.Close();
        }

        private void RefreshTable()
        {
            dgv.Rows.Clear();

            foreach (Film film in filmek)
            {
                dgv.Rows.Add(film.Cim, film.BemutatasEve, film.Hossz, film.Ertekeles);
            }
        }

        private void OnTableSelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                btnModositas.Enabled = false;
                btnTorles.Enabled = false;
                return;
            }

            btnModositas.Enabled = true;
            btnTorles.Enabled = true;
        }

        private void OnTableCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FilmAdatlap fa = new(GetSelectedFilm());
            fa.ShowDialog();
        }

        private void OnModositasClick(object sender, EventArgs e)
        {
            FilmModositas fm = new(GetSelectedFilm());
            fm.ShowDialog();
            ReadFilms();
            RefreshTable();
        }

        private void OnHozzaadasClick(object sender, EventArgs e)
        {
            FilmHozzaadas fh = new();
            fh.ShowDialog();
            ReadFilms();
            RefreshTable();
        }

        private void OnTorlesClick(object sender, EventArgs e)
        {
            Film film = GetSelectedFilm();

            if (MessageBox.Show($"Biztosan ki szeretné törölni a(z) {film.Cim} filmet?", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DeleteFilm(film);

                ReadFilms();
                RefreshTable();
            }
        }

        public static void DeleteFilm(Film film)
        {
            int id = film.Id;

            string[] sqlCommands =
                            {
                    $"DELETE FROM filmek_mufajok WHERE filmID = {id};",
                    $"DELETE FROM filmek_rendezok WHERE filmID = {id};",
                    $"DELETE FROM filmek_szineszek WHERE filmID = {id};",
                    $"DELETE FROM filmek WHERE filmID = {id};"
                };

            connection.Open();

            foreach (string sql in sqlCommands)
            {
                SqlCommand command = new(sql, connection);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public static void AddFilm(Film film)
        {
            connection.Open();
            SqlDataAdapter adapter = new();

            // beillesztem a filmet a filmek táblába
            string addFilmSql = $"INSERT INTO filmek (filmCim, bemutatasEve, hosszPercben, ertekeles, leiras, boritokepURL) VALUES ({film.ToString()});";
            adapter.InsertCommand = new(addFilmSql, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            // megkeresem a film helyét
            string filmIdSql = "SELECT Max(filmID) FROM filmek;";
            adapter.SelectCommand = new(filmIdSql, connection);
            SqlDataReader reader = adapter.SelectCommand.ExecuteReader();

            int filmId = 1;
            while (reader.Read()) 
                filmId = reader.GetInt32(0);

            reader.Close();
             

            // eltárolom a film műfajainak indexeit
            List<int> mufajIndexek = new();
            string getGenreIdsSql = $"SELECT mufajID FROM mufajok WHERE mufajNev IN ('{string.Join("', '", film.Mufajok)}');";
            adapter.SelectCommand = new(getGenreIdsSql, connection);
            reader = adapter.SelectCommand.ExecuteReader();

            while (reader.Read()) 
                mufajIndexek.Add(reader.GetInt32("mufajID")); 

            reader.Close();

            // "összekötöm" a filmet és a műfajait
            foreach (int mufajID in mufajIndexek)
            {
                string filmMufajSql = $"INSERT INTO filmek_mufajok (filmID, mufajID) VALUES ({filmId}, {mufajID});";
                adapter.InsertCommand = new(filmMufajSql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
            }

            // kigyűjtöm a már bent lévő rendezőket
            List<int> rendezoIdk = new();
            List<string> tartalmazottRendezokNevei = new();
            string getDirectorIdsSql = $"SELECT rendezoNev, rendezoID FROM rendezok WHERE rendezoNev IN ('{string.Join("', '", film.Rendezok)}');";
            adapter.SelectCommand = new(getDirectorIdsSql, connection);
            reader = adapter.SelectCommand.ExecuteReader();

            while (reader.Read())
            {
                tartalmazottRendezokNevei.Add(reader.GetString("rendezoNev"));
                rendezoIdk.Add(reader.GetInt32("rendezoID"));
            }

            reader.Close();

            // hány darab rendező van az adatbázisban -> következő indexhez
            string rendezoNextIdSql = "SELECT Max(rendezoID) + 1 FROM rendezok;";
            adapter.SelectCommand = new(rendezoNextIdSql, connection);
            reader = adapter.SelectCommand.ExecuteReader();

            int rendezoId = 1;
            while (reader.Read())
                rendezoId = reader.GetInt32(0);

            reader.Close();

            // beillesztem a még hiányzókat és eltárolom az indexükkel együtt
            foreach (string rendezo in film.Rendezok)
            {
                if (!tartalmazottRendezokNevei.Contains(rendezo))
                {
                    rendezoIdk.Add(rendezoId);
                    rendezoId++;

                    string insertRendezoSql = $"INSERT INTO rendezok (rendezoNev) VALUES ('{rendezo}');";
                    adapter.InsertCommand = new(insertRendezoSql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                }
            }

            // "összekötöm" a filmet a rendező(i)vel
            foreach (int id in rendezoIdk)
            {
                string insertRendezoKapcsolatSql = $"INSERT INTO filmek_rendezok (filmID, rendezoID) VALUES ({filmId}, {id});";
                adapter.InsertCommand = new(insertRendezoKapcsolatSql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
            }

            // kigyűjtöm a már bent lévő színészeket/szereplőket
            Dictionary<string, int> szineszIdk = new();
            List<string> tartalmazottSzineszekNevei = new();
            string getSzereploIdsSql = $"SELECT szineszNev, szineszID FROM szineszek WHERE szineszNev IN ('{string.Join("', '", film.Szereplok.Keys)}');";
            adapter.SelectCommand = new(getSzereploIdsSql, connection);
            reader = adapter.SelectCommand.ExecuteReader();

            while (reader.Read())
            {
                tartalmazottSzineszekNevei.Add(reader.GetString("szineszNev"));
                szineszIdk.Add(reader.GetString("szineszNev"), reader.GetInt32("szineszID"));
            }

            reader.Close();

            // hány darab színész van az adatbázisban -> következő indexhez
            string szineszNextIdSql = "SELECT Max(szineszID) + 1 FROM szineszek;";
            adapter.SelectCommand = new(szineszNextIdSql, connection);
            reader = adapter.SelectCommand.ExecuteReader();

            int szineszId = 1;
            while (reader.Read())
                szineszId = reader.GetInt32(0);

            reader.Close();

            // beillesztem a még hiányzókat és eltárolom az indexükkel együtt
            foreach (string szinesz in film.Szereplok.Keys)
            {
                if (!tartalmazottSzineszekNevei.Contains(szinesz))
                {
                    szineszIdk.Add(szinesz, szineszId);
                    szineszId++;

                    string insertSzineszSql = $"INSERT INTO szineszek (szineszNev) VALUES ('{szinesz}');";
                    adapter.InsertCommand = new(insertSzineszSql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                }
            }

            // "összekötöm" a filmet a színészeivel és hozzáadom a szerepüket
            foreach (var kv in szineszIdk) // szineszNev -> szineszID
            {
                string insertSzineszKapcsolatSql = $"INSERT INTO filmek_szineszek (filmID, szineszID, szereploNev) VALUES ({filmId}, {kv.Value}, '{film.Szereplok[kv.Key]}');";
                adapter.InsertCommand = new(insertSzineszKapcsolatSql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
            }

            connection.Close();
        }

        private Film GetSelectedFilm()
        {
            string cim = dgv.SelectedRows[0].Cells["filmCim"].Value.ToString();
            int bemutatasEve = int.Parse(dgv.SelectedRows[0].Cells["bemutatasEve"].Value.ToString());

            Film film = filmek.FirstOrDefault(film => film.Cim == cim && film.BemutatasEve == bemutatasEve);

            return film;
        }

        private void OnSearchFieldsChange(object sender, EventArgs e)
        {
            string text = tbSearchText.Text.Trim();
            string year = tbSearchYear.Text.Trim();

            whereClause = $"{(string.IsNullOrWhiteSpace(text) ? "1=1" : $"filmCim LIKE '%{text}%'")} AND {(string.IsNullOrWhiteSpace(year) ? "1=1" : $"bemutatasEve LIKE '%{year}%'")}";

            ReadFilms();
            RefreshTable();
        }
    }
}
