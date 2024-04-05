namespace OrderApp.View;

public partial class MainMenu : ContentPage
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private async void BackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void CClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CMenu());
    }
    private async void VClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VMenu());
    }
    private async void PClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PMenu());
    }
    private async void TeknologiClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Technology());
    }

    private async void VarukorgClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Cart());
    }
}