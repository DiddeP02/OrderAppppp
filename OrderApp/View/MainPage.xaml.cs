namespace OrderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BeställClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.MainMenu());
        }

    }

}
