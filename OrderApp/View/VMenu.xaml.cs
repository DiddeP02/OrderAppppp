using OrderApp.Models;

namespace OrderApp.View;

public partial class VMenu : ContentPage
{
    public VMenu()
    {
        InitializeComponent();
        BindingContext = new ViewModel.ProductViewModel().TheWomenProducts;
    }
    private async void Läggtill(object sender, EventArgs e)
    {
        var button = sender as Button;
        var produkter = button?.BindingContext as Product;

        if (produkter != null)
        {
            ShoppingCartSingleton.Instance.AddItem(produkter);
        }
    }

    private async void VarukorgClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Cart());
    }

    private async void BackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}