using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleQuiz.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public KvizPitanje[] PitanjaKviz { get; private set;}
        public String slicicaZaPitanja { get; set; }
        public StartPage()
        {
            InitializeComponent();
        }
        public StartPage(String Opis, String Kategorija, String Slika, KvizPitanje[] PitanjaK, String S)
        {
            InitializeComponent();
            opisniTekst.Text = Opis;
            slicicaZaPitanja = S;
            nazivKategorije.Text = Kategorija;
            slicica.Source = Slika;
            PitanjaKviz = PitanjaK;
        }

        private void ZapocniKviz(object sender, EventArgs e)
        {
            var stranica = new Pitanja(PitanjaKviz, slicicaZaPitanja);
            Navigation.PushAsync(stranica);
        }
    }
}