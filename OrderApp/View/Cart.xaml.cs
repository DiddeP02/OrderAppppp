using OrderApp.Models;

namespace OrderApp.View;

public partial class Cart : ContentPage
{
    public Cart()
    {
        InitializeComponent();
        UpdateItems();
    }

    private void UpdateItems()
    {
        var items = ShoppingCartSingleton.Instance.GetItems();
        if (items.Count > 0)
        {
            Text.Text = items[0].Title;
            Text.IsVisible = true;
            RemoveButton1.IsVisible = true;
        }
        else
        {
            Text.IsVisible = false;
            RemoveButton1.IsVisible = false;
        }

        if (items.Count > 1)
        {
            Text2.Text = items[1].Title;
            Text2.IsVisible = true;
            RemoveButton2.IsVisible = true;
        }
        else
        {
            Text2.IsVisible = false;
            RemoveButton2.IsVisible = false;
        }

        if (items.Count > 2)
        {
            Text3.Text = items[2].Title;
            Text3.IsVisible = true;
            RemoveButton3.IsVisible = true;
        }
        else
        {
            Text3.IsVisible = false;
            RemoveButton3.IsVisible = false;
        }
    }

    private void RemoveButton_Clicked(object sender, EventArgs e)
    {
        var itemToRemove = ShoppingCartSingleton.Instance.GetItems().FirstOrDefault(item => item.Title == Text.Text);
        if (itemToRemove != null)
        {
            ShoppingCartSingleton.Instance.RemoveItemm(itemToRemove);
            UpdateItems();
        }
    }

    private void RemoveButton_Clicked2(object sender, EventArgs e)
    {
        var itemToRemove = ShoppingCartSingleton.Instance.GetItems().FirstOrDefault(item => item.Title == Text2.Text);
        if (itemToRemove != null)
        {
            ShoppingCartSingleton.Instance.RemoveItemm(itemToRemove);
            UpdateItems();
        }
    }

    private void RemoveButton_Clicked3(object sender, EventArgs e)
    {
        var itemToRemove = ShoppingCartSingleton.Instance.GetItems().FirstOrDefault(item => item.Title == Text3.Text);
        if (itemToRemove != null)
        {
            ShoppingCartSingleton.Instance.RemoveItemm(itemToRemove);
            UpdateItems();
        }
    }

    private void OrderButton_Clicked(object sender, EventArgs e)
    {
        ShoppingCartSingleton.Instance.ClearItems();
        UpdateItems();
        Navigation.PushAsync(new MainPage());
    }
}