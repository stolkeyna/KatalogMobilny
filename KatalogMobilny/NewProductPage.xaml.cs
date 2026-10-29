namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	public NewProductPage()
	{
		InitializeComponent();
	}
    private int licznik = 0;
    private int znaki = 0;
    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        licznik++;
        EtykietaWyniku2.Text = $"Kliknięto {licznik} razy";
    }
    private void Powrot_Clicked(object sender, EventArgs e) 
    {
        licznik = 0;
        EtykietaWyniku2.Text = "";
    }
    private void IleZnakow(object sender, EventArgs e)
    {
        znaki++;
        ZnakiNazwy.Text = $"Nazwa ma {znaki} znaków";
    }
    private void KtoraKategoria(object sender, EventArgs e)
    {
        WybranaKategoria.Text = $"Kategoria: {e}";
    }
    private void CzyDostepny(object sender, EventArgs e)
    {
        DostepnyLabel.Text = "Produkt dostępny";
    }
}