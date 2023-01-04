using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    public class Film
    {
        private int _id;
        private string _cim;
        private int _bemutatasEve;
        private int _hosszPercben;
        private decimal _ertekeles;
        private string _leiras;
        private string _boritokepURL;
        private List<string> _mufajok;
        private List<string> _rendezok;
        private Dictionary<string, string> _szereplok; // színész -> szerep

        public Film(int id, string cim, int bemutatasEve, int hosszPercben, decimal ertekeles, string leiras, string boritokepURL, List<string> mufajok, List<string> rendezok, Dictionary<string, string> szereplok)
        {
            _id = id;
            _cim = cim;
            _bemutatasEve = bemutatasEve;
            _hosszPercben = hosszPercben;
            _ertekeles = ertekeles;
            _leiras = leiras;
            _boritokepURL = boritokepURL;
            _mufajok = mufajok;
            _rendezok = rendezok;
            _szereplok = szereplok;
        }

        public Film(string cim, int bemutatasEve, int hosszPercben, decimal ertekeles, string leiras, string boritokepURL, List<string> mufajok, List<string> rendezok, Dictionary<string, string> szereplok)
        {
            _cim = cim;
            _bemutatasEve = bemutatasEve;
            _hosszPercben = hosszPercben;
            _ertekeles = ertekeles;
            _leiras = leiras;
            _boritokepURL = boritokepURL;
            _mufajok = mufajok;
            _rendezok = rendezok;
            _szereplok = szereplok;
        }

        public int Id { get => _id; }
        public string Cim { get => _cim; }
        public int BemutatasEve { get => _bemutatasEve; }
        public string Hossz { get => $"{_hosszPercben / 60} óra {(_hosszPercben % 60):00} perc"; }
        public int HosszPercben { get => _hosszPercben; }
        public decimal Ertekeles { get => _ertekeles; }
        public string Leiras { get => _leiras; }
        public string BoritokepURL { get => _boritokepURL; }
        public List<string> Mufajok { get => _mufajok; }
        public List<string> Rendezok { get => _rendezok; }
        public Dictionary<string, string> Szereplok { get => _szereplok; }

        public static bool IsValidYear(string text)
        {
            bool success = int.TryParse(text, out int year);

            if (!success) return false;

            if (year < 1900 || year > DateTime.Now.Year) return false;

            return true;
        }

        public static bool IsValidRating(string text)
        {
            bool success = decimal.TryParse(text, out decimal rating);

            if (!success) return false;

            rating = Math.Round(rating, 1);

            if (rating < 0 || rating > 10) return false;

            return true;
        }

        public static bool isValidLength(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            bool success = int.TryParse(text, out int length);

            if (!success) return false;

            return length > 0;
        }

        public new string ToString()
        {
            return $"'{_cim}', {_bemutatasEve}, {_hosszPercben}, {_ertekeles.ToString().Replace(',', '.')}, '{_leiras}', '{_boritokepURL}'";
        }
    }
}
