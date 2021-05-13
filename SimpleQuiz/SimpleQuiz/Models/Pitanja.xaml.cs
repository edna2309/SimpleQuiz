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
    public partial class Pitanja : ContentPage
    {
        public KvizPitanje[] PitanjaS { get; private set; }
        int b = 0;
        int bodovi = 0;
        public Pitanja()
        {
            InitializeComponent();
        }
        public Pitanja(KvizPitanje []Pitanja, String S)
        {
            InitializeComponent();
            PitanjaS = Pitanja;
            KvizPitanje p = Pitanja[0];
            Slika.Source = S;
           
            Pitanje.Text = p.pitanje;
            Odgovor1.Text = p.odgovori[0];
            Odgovor2.Text = p.odgovori[1];
            Odgovor3.Text = p.odgovori[2];
            Odgovor4.Text = p.odgovori[3];
            b++;
            String pit = "Pitanje ";
            pit = pit + b.ToString();
            pit = pit + "/5";
            BrojPitanja.Text = pit;
        }
        private async void nextPitanje(object sender, EventArgs e)
        {
            String poruka;
            int odg = -1;
            if (prviOdgovor.IsChecked == true)
            {
                odg = 0;
            }
            if (drugiOdgovor.IsChecked == true)
            {
                odg = 1;
            }
            if (treciOdgovor.IsChecked == true)
            {
                odg = 2;
            }
            if (cetvrtiOdgovor.IsChecked == true)
            {
                odg = 3;
            }
            KvizPitanje p = PitanjaS[b-1];
            
                if (p.tacanOdgovor == odg)
                {
                    poruka = "Odgovorili ste tačno!";                
                    bodovi++;
                }
                else
                {
                    poruka = "Odgovorili ste netačno. Tačan odgovor je " + p.odgovori[p.tacanOdgovor] + ".";
                }
                await DisplayAlert("", poruka, "ok");

                if (b < 5)
                {

                    drugiOdgovor.IsChecked = false;
                    prviOdgovor.IsChecked = false;
                    treciOdgovor.IsChecked = false;
                    cetvrtiOdgovor.IsChecked = false;

                    await Sve.FadeTo(0,250);
                    p = PitanjaS[b];

                    
                    Pitanje.Text = p.pitanje;
                    Odgovor1.Text = p.odgovori[0];
                    Odgovor2.Text = p.odgovori[1];
                    Odgovor3.Text = p.odgovori[2];
                    Odgovor4.Text = p.odgovori[3];

                    b++;
                    String pit = "Pitanje ";
                    pit += b.ToString(); 
                    pit += "/5";
                    BrojPitanja.Text = pit;
                    await Sve.FadeTo(1, 250);                    
                }
                else
                {
                    var stranica = new Kraj(bodovi);
                    await Navigation.PushAsync(stranica);
            }
                    
           
        }
        

        private async void Odg1Checked(object sender, CheckedChangedEventArgs e)
        {
            int m = 0;
            if (cetvrtiOdgovor.IsChecked || drugiOdgovor.IsChecked || treciOdgovor.IsChecked)
            {
                m = 1;
            }
            if (prviOdgovor.IsChecked == true)
            {
                drugiOdgovor.IsChecked = false;
                treciOdgovor.IsChecked = false;
                cetvrtiOdgovor.IsChecked = false;
                if (m == 0)
                {
                    Dalje1.IsEnabled = true;
                    await Dalje1.FadeTo(0, 0);
                    Dalje1.IsVisible = true;
                    await Dalje1.FadeTo(1, 200);
                }
            }
            else
            {
                if (m == 0)
                {                    
                    await Dalje1.FadeTo(0, 200);
                    Dalje1.IsEnabled = false;
                }

            }

        }
        
        private async void Odg2Checked(object sender, CheckedChangedEventArgs e)
        {
            int m = 0;
            if (prviOdgovor.IsChecked || cetvrtiOdgovor.IsChecked || treciOdgovor.IsChecked)
            {
                m = 1;
            }
            if (drugiOdgovor.IsChecked == true)
            {
                cetvrtiOdgovor.IsChecked = false;
                treciOdgovor.IsChecked = false;
                prviOdgovor.IsChecked = false;
                if (m == 0)
                {
                    Dalje1.IsEnabled = true;
                    await Dalje1.FadeTo(0, 0);
                    Dalje1.IsVisible = true;
                    await Dalje1.FadeTo(1, 300);

                }

            }
            else
            {
                if (m == 0)
                {
                    await Dalje1.FadeTo(0, 300);
                    Dalje1.IsEnabled = false;
                }

            }


        }

        private async void Odg3Checked(object sender, CheckedChangedEventArgs e)
        {
            int m = 0;
            if (prviOdgovor.IsChecked || drugiOdgovor.IsChecked || cetvrtiOdgovor.IsChecked)
            {
                m = 1;
            }
            if (treciOdgovor.IsChecked == true)
            {
                drugiOdgovor.IsChecked = false;
                cetvrtiOdgovor.IsChecked = false;
                prviOdgovor.IsChecked = false;
                if (m == 0)
                {
                    Dalje1.IsEnabled = true;
                    await Dalje1.FadeTo(0, 0);
                    Dalje1.IsVisible = true;
                    await Dalje1.FadeTo(1, 300);
                }
            }
            else
            {
                if (m == 0)
                {
                    await Dalje1.FadeTo(0, 300);
                    Dalje1.IsEnabled = false;
                }
            }


        }

        private async void Odg4Checked(object sender, CheckedChangedEventArgs e)
        {
            int m = 0;
            if (prviOdgovor.IsChecked || drugiOdgovor.IsChecked || treciOdgovor.IsChecked)
            {
                m = 1;
            }
            if (cetvrtiOdgovor.IsChecked == true)
            {                            
                drugiOdgovor.IsChecked = false;
                treciOdgovor.IsChecked = false;
                prviOdgovor.IsChecked = false;
                if (m == 0)
                {
                    Dalje1.IsEnabled = true;
                    await Dalje1.FadeTo(0, 0);
                    Dalje1.IsVisible = true;
                    await Dalje1.FadeTo(1, 300);
                }               

            }
            else
            {
                if (m == 0)
                {
                    await Dalje1.FadeTo(0, 300);
                    Dalje1.IsEnabled = false;
                }
                
            }
        }
    }
}