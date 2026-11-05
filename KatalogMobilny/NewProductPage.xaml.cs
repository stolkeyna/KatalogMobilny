namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	public NewProductPage()
	{
		InitializeComponent();
	}
    private void IleZnakow(object sender, EventArgs e)
    {
        string tekst = ZnakiNazwy.Text;
        int IloscZnakow = tekst.Length;
        ZnakiNazwy.Text = $"Nazwa ma {IloscZnakow} znaków";
    }
    private void KtoraKategoria(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int WybranyIndex = picker.SelectedIndex;
        WybranaKategoria.Text = $"Kategoria: {(string)picker.ItemsSource[WybranyIndex]}";
    }
    private void CzyDostepny(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            DostepnyLabel.Text = "Produkt dostępny";
        }
        else
        {
            DostepnyLabel.Text = "Produkt Niedostępny";
        }
    }
    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        //licznik++;
        //EtykietaWyniku2.Text = $"Kliknięto {licznik} razy";
        if(!double.TryParse(CenaEntry.Text, out double cena))
        {
            //jeżeli try parse nie uda się odczytać ceny
            EtykietaWyniku2.Text = "Niepoprawna cena!";
            return;
        }
        if(!int.TryParse(IloscEntry.Text, out int ilosc))
        {
            EtykietaWyniku2.Text = "Niepoprawna ilość!";
            return;
        }
        if(cena <0 || ilosc < 0)
        {
            EtykietaWyniku2.Text = "Niepoprawna ilość lub cena!";
            return;
        }
        double wartosc = cena*ilosc;
        string? nazwa = NazwaEntry.Text;
        if (string.IsNullOrEmpty(nazwa))
        {
            EtykietaWyniku2.Text = "Niepoprawna nazwa!";
        }
        if(KategoriaPicker.SelectedItem == null)
        {
            EtykietaWyniku2.Text = "Niewybrana kategoria!";
        }

        EtykietaWyniku2.Text = $"Produkt: {nazwa}, cena: {cena}, ilość: {ilosc}, kategoria: {KategoriaPicker.SelectedItem} wartość: {wartosc}";
    }
    private void Powrot_Clicked(object sender, EventArgs e)
    {
        EtykietaWyniku2.Text = "";
        ZnakiNazwy.Text = "";
        WybranaKategoria.Text = "";
        DostepnyLabel.Text = "";
    }
}