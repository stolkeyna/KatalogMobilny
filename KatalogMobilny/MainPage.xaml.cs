namespace KatalogMobilny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            //alternatywa tworzenia elementów interfejsu zamiast xamla
            //tego nie robimy, tutaj tylko logika!
            InitializeComponent();
        }

        private void PokazButton(object sender, EventArgs e)
        {
            EtykietaWyniku.Text = "Wybrano processor";
        }

        //private void OnCounterClicked(object? sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        Kliknieto.Text = $"Kliknięto {count} raz";
        //    else
        //        Kliknieto.Text = $"Kliknięto {count} razy";

        //    SemanticScreenReader.Announce(Kliknieto.Text);
        //} 
    }
}
