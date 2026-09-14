namespace KatalogMobilny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                Kliknieto.Text = $"Kliknięto {count} raz";
            else
                Kliknieto.Text = $"Kliknięto {count} razy";

            SemanticScreenReader.Announce(Kliknieto.Text);
        }
    }
}
