using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        List<Banka> ListaBanki = new List<Banka>() {
            new Banka() {Simbol="PBZ", Naziv=" Privredna banka Zagreb" } ,
            new Banka() {Simbol="ZABA", Naziv=" Zagrebačka banka"  },
            new Banka() {Simbol="OTP", Naziv=" OTP banka" },
            new Banka() {Simbol="HPB", Naziv=" Hrvatska poštanska banka" }
        };

        List<Klijent> ListaKlijenata = new List<Klijent>()
        {
            new Klijent() {ImePrezime="Ivo Ivić", Stanje=1033450.30, Banka="PBZ"},
            new Klijent() {ImePrezime="Ana Anić", Stanje=5450, Banka="OTP"},
            new Klijent() {ImePrezime="Darko Matić", Stanje=800, Banka="ZABA"},
            new Klijent() {ImePrezime="Jure Jurić", Stanje=34342.1, Banka="PBZ"},
            new Klijent() {ImePrezime="Pero Petrić", Stanje=5258.30, Banka="PBZ"},
            new Klijent() {ImePrezime="Vana Ljubić", Stanje=2341117.99, Banka="ZABA"},
            new Klijent() {ImePrezime="Magda Bogdan", Stanje=1051099.47, Banka="OTP"},
            new Klijent() {ImePrezime="Matea Petric", Stanje=38814620, Banka="HPB"},
            new Klijent() {ImePrezime="Nikolina Jozić", Stanje=8523.17, Banka="HPB"},
            new Klijent() {ImePrezime="Bruno Begić", Stanje=754.83, Banka="PBZ"},
            new Klijent() {ImePrezime="Slavko Matoš", Stanje=45617.22, Banka="ZABA"},
            new Klijent() {ImePrezime="Ivan Borić", Stanje=1549873.6, Banka="OTP"}
        };

        public List<Klijent> DajListuKlijenata
        {
            get { return ListaKlijenata; }
        }

        public List<Banka> DajListuBanki
        {
            get { return ListaBanki; }
        }
    }
}
