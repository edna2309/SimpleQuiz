using SimpleQuiz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleQuiz
{
    public partial class MainPage : ContentPage
    {
        public KvizPitanje[] PitanjaKviz { get; private set; }
        public String opis { get; private set; }
        public String slika { get; private set; }
        public String kategorija { get; private set; }
        public String slicica { get; private set; }

        public int broj = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Fade(bool vrijednost)
        {
            if (Dalje.IsVisible == false)
            {
                await Dalje.FadeTo(0, 300);
                Dalje.IsVisible = vrijednost;
                await Dalje.FadeTo(1, 300);
            }
            else
            {
                if (vrijednost == false)
                {
                    await Dalje.FadeTo(0, 200);
                    Dalje.IsVisible = vrijednost;
                    await Dalje.FadeTo(1, 200);
                }
                else
                {
                    Dalje.IsVisible = vrijednost;
                }

            }

        }
        private void OnFrameSvemir(object sender, EventArgs e)
        {

            if (Svemir.BorderColor == Color.FromHex("#66d2c8"))
            {
                Svemir.BackgroundColor = Color.White;
                Svemir.BorderColor = Color.FromHex("#dcdcdc");
                Fade(false);
            }
            else
            {
                Pitanja(3);
                Svemir.BackgroundColor = Color.FromHex("#F8F8F8");
                Svemir.BorderColor = Color.FromHex("#66d2c8");

                Sport.BackgroundColor = Color.White;
                Geografija.BackgroundColor = Color.White;
                Mitologija.BackgroundColor = Color.White;

                Sport.BorderColor = Color.FromHex("#dcdcdc");
                Geografija.BorderColor = Color.FromHex("#dcdcdc");
                Mitologija.BorderColor = Color.FromHex("#dcdcdc");

                Fade(true);
            }

        }

        private void OnFrameSport(object sender, EventArgs e)
        {
            if (Sport.BorderColor == Color.FromHex("#66d2c8"))
            {
                Sport.BackgroundColor = Color.White;
                Sport.BorderColor = Color.FromHex("#dcdcdc");

                Fade(false);
            }
            else
            {
                Pitanja(4);
                Sport.BackgroundColor = Color.FromHex("#F8F8F8");
                Sport.BorderColor = Color.FromHex("#66d2c8");

                Svemir.BackgroundColor = Color.White;
                Geografija.BackgroundColor = Color.White;
                Mitologija.BackgroundColor = Color.White;

                Svemir.BorderColor = Color.FromHex("#dcdcdc");
                Geografija.BorderColor = Color.FromHex("#dcdcdc");
                Mitologija.BorderColor = Color.FromHex("#dcdcdc");

                Fade(true);
            }

        }

        private void OnFrameGeografija(object sender, EventArgs e)
        {
            if (Geografija.BorderColor == Color.FromHex("#66d2c8"))
            {
                Geografija.BackgroundColor = Color.White;
                Geografija.BorderColor = Color.FromHex("#dcdcdc");

                Fade(false);
            }
            else
            {
                Pitanja(2);
                Geografija.BackgroundColor = Color.FromHex("#F8F8F8");
                Geografija.BorderColor = Color.FromHex("#66d2c8");

                Sport.BackgroundColor = Color.White;
                Svemir.BackgroundColor = Color.White;
                Mitologija.BackgroundColor = Color.White;

                Sport.BorderColor = Color.FromHex("#dcdcdc");
                Svemir.BorderColor = Color.FromHex("#dcdcdc");
                Mitologija.BorderColor = Color.FromHex("#dcdcdc");

                Fade(true);
            }

        }

        private void OnFrameMitologija(object sender, EventArgs e)
        {
            if (Mitologija.BorderColor == Color.FromHex("#66d2c8"))
            {
                Mitologija.BackgroundColor = Color.White;
                Mitologija.BorderColor = Color.FromHex("#dcdcdc");

                Fade(false);
            }
            else
            {
                Pitanja(1);
                Mitologija.BackgroundColor = Color.FromHex("#F8F8F8");
                Mitologija.BorderColor = Color.FromHex("#66d2c8");

                Sport.BackgroundColor = Color.White;
                Svemir.BackgroundColor = Color.White;
                Geografija.BackgroundColor = Color.White;

                Sport.BorderColor = Color.FromHex("#dcdcdc");
                Svemir.BorderColor = Color.FromHex("#dcdcdc");
                Geografija.BorderColor = Color.FromHex("#dcdcdc");

                Fade(true);
            }

        }

        private KvizPitanje PostaviPitanje(String pit, String[] odg, int tacan)
        {
            KvizPitanje k = new KvizPitanje();
            k.pitanje = pit;
            for (int i = 0; i < 4; i++)
            {
                k.odgovori[i] = odg[i];
            }
            k.tacanOdgovor = tacan;
            return k;
        }
        private String[] PostaviOdgovore(String prvi, String drugi, String treci, String cetvrti)
        {
            String[] odg = new String[4];
            odg[0] = prvi;
            odg[1] = drugi;
            odg[2] = treci;
            odg[3] = cetvrti;
            return odg;
        }
        private void Pitanja(int brKategorije)
        {

            String[] odg;
            PitanjaKviz = new KvizPitanje[5];
            switch (brKategorije)
            {

                case 1:
                    //MITOLOGIJA 
                    slicica = "mitologija";
                    //prvo pitanje
                    odg = PostaviOdgovore("Heraklo", "Hermes", "Ares", "Pan");
                    PitanjaKviz[0] = PostaviPitanje("Kako je bilo ime bogu rata, prezrenom sinu Zeusa i Here?", odg, 2);

                    //drugo pitanje
                    odg = PostaviOdgovore("Temis", "Prometej", "Atlas", "Metis");
                    PitanjaKviz[1] = PostaviPitanje("Kako se zvao Titan kojem je, po kazni Zeusovoj, prikovanom na litici orao kljucao jetru?", odg, 1);

                    //trece pitanje
                    odg = PostaviOdgovore("Melpomena", "Erato", "Talija", "Klio");
                    PitanjaKviz[2] = PostaviPitanje("Koja je od muza bila zadužena za komediju?", odg, 2);

                    //cetvrto pitanje
                    odg = PostaviOdgovore("Zeus", "Posejdon", "Had", "Hefest");
                    PitanjaKviz[3] = PostaviPitanje("Vrhovni bog svih bogova s Olimpa, bog neba, svijeta i kiše zvao se...", odg, 0);

                    //peto pitanje
                    odg = PostaviOdgovore("Posejdon", "Kronos", "Ares", "Had");
                    PitanjaKviz[4] = PostaviPitanje("Kako se zvao bog podzemlja, vladar mrtvih, Zeusov brat?", odg, 3);

                    //postavke za start
                    opis = "Mitologija je znanost koja proučava priče fantastičnog sadržaja u kojima su junaci bogovi, polubogovi, heroji i slično. Te priče bilježi mit, legenda, tradicija, usmena predaja i drugo. Kviz sadrži pet pitanja koja imaju četiri ponuđena odgovora od kojih je samo jedan tačan. Sretno!";
                    kategorija = "Mitologija";
                    slika = "https://cdn.discordapp.com/attachments/674554517626552321/795771687165231104/zeus.png";
                    break;
                case 2:
                    //GEOGRAFIJA
                    slicica = "geografija";
                    //prvo pitanje
                    odg = PostaviOdgovore("Evropa", "Sjeverna Amerika", "Brazil", "Azija");
                    PitanjaKviz[0] = PostaviPitanje("Označi uljeza", odg, 2);

                    //drugo pitanje
                    odg = PostaviOdgovore("Amazon", "Nil", "Kongo", "Dunav");
                    PitanjaKviz[1] = PostaviPitanje("Koja je najveća rijeka na svijetu?", odg, 0);

                    //trece pitanje
                    odg = PostaviOdgovore("Himalaji", "Mount Everest", "Pirineji", "Alpe");
                    PitanjaKviz[2] = PostaviPitanje("Koji je najviši planinski vrh na svijetu?", odg, 1);

                    //cetvrto pitanje
                    odg = PostaviOdgovore("Apenini", "Atlas", "Ural", "Dinaridi");
                    PitanjaKviz[3] = PostaviPitanje("Koja planina dijeli Evropu od Azije?", odg, 2);

                    //peto pitanje
                    odg = PostaviOdgovore("Gobi", "Sahara", "Takla Makan", "Kalahari");
                    PitanjaKviz[4] = PostaviPitanje("Koja je najveća pustinja na svijetu?", odg, 1);

                    //postavke za start
                    opis = "Geografija je znanost koja proučava prostornu stvarnost Zemljine površine. Naziv potječe iz klasične starine, a upućuje na prvotno značenje geografije, pa je prema tome nastala i riječ zemljopis. Kviz sadrži pet pitanja koja imaju četiri ponuđena odgovora od kojih je samo jedan tačan. Sretno!";
                    kategorija = "Geografija";
                    slika = "https://cdn.discordapp.com/attachments/674554517626552321/795780323995942972/compass.png";
                    break;
                case 3:
                    //SVEMIR
                    slicica = "svemir";
                    //prvo pitanje
                    odg = PostaviOdgovore("6 planeta", "7 planeta", "8 planeta", "9 planeta");
                    PitanjaKviz[0] = PostaviPitanje("U Sunčevom sistemu ima...", odg, 2);

                    //drugo pitanje
                    odg = PostaviOdgovore("tri planete", "jedna planeta", "četiri planete", "dvije planete");
                    PitanjaKviz[1] = PostaviPitanje("Između Zemlje i Sunca nalaze se...", odg, 3);

                    //trece pitanje
                    odg = PostaviOdgovore("Saturn", "Zemlja", "Mars", "Mjesec");
                    PitanjaKviz[2] = PostaviPitanje("Planet sa prstenom zove se...", odg, 0);

                    //cetvrto pitanje
                    odg = PostaviOdgovore("suze i bijes", "strah i užas", "jad i bijeda", "tuga i jad");
                    PitanjaKviz[3] = PostaviPitanje("Mars ima dva satelita koji se zovu Phobos i Deimos, što u prijevodu znači...", odg, 1);

                    //peto pitanje
                    odg = PostaviOdgovore("54 godine", "64 godine", "74 godine", "84 godine");
                    PitanjaKviz[4] = PostaviPitanje("Uranu su za jedan obilazak oko Sunca potrebne...", odg, 3);

                    //postavke za start
                    opis = "Svemir, kosmos, kozmos, vasiona ili univerzum jest beskonačno prostranstvo koje nas okružuje. To je ustvari vremenski prostor u kome plovi mnoštvo nebeskih tijela i koji postoji neovisno od ljudskog znanja. Kviz sadrži pet pitanja koja imaju četiri ponuđena odgovora od kojih je samo jedan tačan. Sretno!";
                    kategorija = "Svemir";
                    slika = "https://cdn.discordapp.com/attachments/674554517626552321/795773114579157012/astronomy.png";
                    break;
                case 4:
                    //SPORT
                    slicica = "sport";
                    //prvo pitanje
                    odg = PostaviOdgovore("9.58s", "10.12s", "9.12s", "15.23s");
                    PitanjaKviz[0] = PostaviPitanje("Koji je Usain Boltov rekord u trčanju na 100m?", odg, 0);

                    //drugo pitanje
                    odg = PostaviOdgovore("tenis", "plivanje", "američki fudbal", "košarka");
                    PitanjaKviz[1] = PostaviPitanje("LA Lakers i New York Knicks su timovi koji igraju koji sport?", odg, 3);

                    //trece pitanje
                    odg = PostaviOdgovore("15 minuta", "65 minuta", "90 minuta", "120 minuta");
                    PitanjaKviz[2] = PostaviPitanje("Koliko traje fudbalska utakmica?", odg, 2);

                    //cetvrto pitanje
                    odg = PostaviOdgovore("3", "12", "5", "1");
                    PitanjaKviz[3] = PostaviPitanje("Koliko prstenova ima zastava Olimpijade?", odg, 2);

                    //peto pitanje
                    odg = PostaviOdgovore("12km", "72.5km", "42.1km", "20km");
                    PitanjaKviz[4] = PostaviPitanje("Maraton je utrka koja je duga...", odg, 2);

                    //postavke za start
                    opis = "Sport je svaka fizička i psihička aktivnost koju čovjek izvodi po utvrđenom skupu pravila, u cilju takmičenja sa protivnikom ili protivničkim timom, uz primjenu propisanog sistema bodovanja na osnovu kojeg se utvrđuje pobjednik.  Kviz sadrži pet pitanja koja imaju četiri ponuđena odgovora od kojih je samo jedan tačan. Sretno!";
                    kategorija = "Sport";
                    slika = "https://cdn.discordapp.com/attachments/674554517626552321/795773625222824026/volleyball.png";
                    break;
            }
        }

        private void PrelazNaStart(object sender, EventArgs e)
        {
            var stranica = new StartPage(opis, kategorija, slika, PitanjaKviz, slicica);
            Navigation.PushAsync(stranica);
        }
    }


}
    

