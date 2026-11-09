namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
    private int licznik = 0;
    public NewProductPage()
    {
        InitializeComponent();
    }

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        //licznik++;
        //EtykietaWyniku.Text = $"Kliknięto {licznik} razy";
        //czytamy: jeżeli tryparse nie uda się odczytać ceny
        if (!double.TryParse(CenaEntry.Text, out double cena))
        {
            EtykietaWyniku.Text = "Niepoprawna cena!"; //wyświetlamy komunikat o błędzie
            return; //wychodzimy z metody, nie wykonujemy dalszych instrukcji
        }
        if (!int.TryParse(IloscEntry.Text, out int ilosc))
        {
            EtykietaWyniku.Text = "Niepoprawna ilość!"; //wyświetlamy komunikat o błędzie
            return; //wychodzimy z metody, nie wykonujemy dalszych instrukcji
        }
        if (cena < 0 || ilosc < 0)
        {
            EtykietaWyniku.Text = "Cena i ilość nie mogą być ujemne!"; //wyświetlamy komunikat o błędzie
            return; //wychodzimy z metody, nie wykonujemy dalszych instrukcji
        }
        //jeśli doszlimy tutaj to znaczy, że poprawnie odczytaliśmy cenę i ilość
        double wartosc = cena * ilosc;
        //teraz sprawdzamy nazwę produktu - nie może być pusta ani składać się tylko z białych znaków
        string? nazwa = NazwaEntry.Text;
        if (string.IsNullOrWhiteSpace(nazwa))
        {
            EtykietaWyniku.Text = "Niepoprawna nazwa!"; //wyświetlamy komunikat o błędzie
            return; //wychodzimy z metody, nie wykonujemy dalszych instrukcji
        }
        //na koniec sprawdzamy czy wybrano kategorię
        if (KategoriaPicker.SelectedItem == null)
        {
            EtykietaWyniku.Text = "Nie wybrano kategorii!"; //wyświetlamy komunikat o błędzie
            return; //wychodzimy z metody, nie wykonujemy dalszych instrukcji
        }
        //wszystko sprawdzone - wyswietlamy wynik
        EtykietaWyniku.Text = $"Produkt: {nazwa}, cena: {cena}, ilość: {ilosc}, " +
            $"kategoria: {KategoriaPicker.SelectedItem}, wartość: {wartosc}";
    }

    private void NazwaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string tekst = NazwaEntry.Text;
        int iloscZnakow = tekst.Length;
        EtykietaWyniku.Text = $"Nazwa ma {iloscZnakow} znaków";
    }
    //TODO: oprogramuj drugi guzik w taki sposób żeby resetował licznik i wyświetlał w etykiecie "Kliknięto 0 razy"
    private void Reset_Clicked(object sender, EventArgs e)
    {
        licznik = 0;
        EtykietaWyniku.Text = $"Kliknięto {licznik} razy";
    }

    private void AvailableSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        if (AvailableSwitch.IsToggled)
        {
            AvailableLabel.Text = "Produkt jest dostępny";
        }
        else
        {
            AvailableLabel.Text = "Produkt jest niedostępny";
        }
    }

    private void KategoriaPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        EtykietaWyniku.Text = $"Wybrano kategorię: {KategoriaPicker.SelectedItem}";
    }

    private void CenaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        //jeśli chcielibyście wiedzieć który elementy wysłał zdarzenie
        Entry s = (Entry)sender;
        if (double.TryParse(s.Text, out double wartosc))
        {
            //nie wiem czy to cena czy ilosc ale sprawdze czy jest ujemna
            if (wartosc < 0)
            {
                //jeżeli jest ujemna to podświetle na czerwono
                s.BackgroundColor = Colors.Red;
                return;
            }
            else
            {
                //jeżeli jest dodatnia to podświetle na zielono
                s.BackgroundColor = Colors.Green;
            }
        }

        if (!double.TryParse(CenaEntry.Text, out double cena))
        {
            EtykietaWartosc.Text = $"Niepoprawna cena!";
            return;
        }
        if (!int.TryParse(IloscEntry.Text, out int ilosc))
        {
            EtykietaWartosc.Text = $"Niepoprawna ilość!";
            return;
        }
        EtykietaWartosc.Text = $"Wartość produktu: {cena * ilosc}";
    }
}