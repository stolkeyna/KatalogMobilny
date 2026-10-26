namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	public NewProductPage()
	{
		InitializeComponent();
	}
    private int licznik = 0;
    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        licznik++;
        EtykietaWyniku2.Text = $"Kliknięto {licznik} razy";
    }
}