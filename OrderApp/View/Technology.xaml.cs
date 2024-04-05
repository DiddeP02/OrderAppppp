using OrderApp.Models;
using OrderApp.ViewModel;

namespace OrderApp.View;

public partial class Technology : ContentPage
{
    public Technology()
    {
        InitializeComponent();
        BindingContext = new ProductViewModel().TheTechnologyProducts;

    }

    private async void OBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void VarukorgClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Cart());
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
}