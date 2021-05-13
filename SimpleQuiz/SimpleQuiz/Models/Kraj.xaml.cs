using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleQuiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kraj : ContentPage
    {
        public List<Zavrsna> ListaZavrsna { get; private set; }
        public Kraj()
        {
            InitializeComponent();
        }
        public Kraj(int brojBodova)
        {
            InitializeComponent();
            ListaZavrsna = new List<Zavrsna>();

            ListaZavrsna.Add(new Zavrsna
            {
                Slika = "nula",
                Poruka = "Imate još mnogo za naučiti. Više sreće drugi put!"
            }) ;
            ListaZavrsna.Add(new Zavrsna
            {
                Slika = "jedan",
                Poruka = "Imate još mnogo za naučiti, još uvijek ste početnik!"
            }); ListaZavrsna.Add(new Zavrsna
            {
                Slika = "dva",
                Poruka = "Niste neznalica, ali dug je put pred Vama. Sretno!"
            }); ListaZavrsna.Add(new Zavrsna
            {
                Slika = "tri",
                Poruka = "Prosječno, ali možete bolje."
            }); ListaZavrsna.Add(new Zavrsna
            {
                Slika = "cetiri",
                Poruka = "Svaka čast, fali Vam još malo i postat ćete pravi ekspert!"
            }); ListaZavrsna.Add(new Zavrsna
            {
                Slika = "pet",
                Poruka = "Svaka čast, jako dobro poznajete ovo područje!"
            });
            Postavi(ListaZavrsna[brojBodova].Slika, brojBodova.ToString(), ListaZavrsna[brojBodova].Poruka);

        }
        private void Postavi(String S, String B, String P)
        {
            String porukica = B;
            porukica += "/5";
            Slika.Source = S;
            Bodovi.Text = porukica;
            Poruka.Text = P;
        }

        private void Restart(object sender, EventArgs e)
        {
            var stranica = new MainPage();
            Navigation.PushAsync(stranica);
        }
    }
}