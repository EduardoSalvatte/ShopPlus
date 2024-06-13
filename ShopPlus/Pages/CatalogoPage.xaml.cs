using ShopPlus.Model;

namespace ShopPlus.Pages;

public partial class CatalogoPage : ContentPage
{
    public CatalogoPage()
	{
		InitializeComponent();
    }

    private async void MenuTab_Clicked(object sender, EventArgs e)
    {
        if (SideMenu.IsVisible)
        {
            await SideMenu.TranslateTo(-200, 0, 250, Easing.CubicIn);
            SideMenu.IsVisible = false;
        }
        else
        {
            SideMenu.IsVisible = true;
            await SideMenu.TranslateTo(0, 0, 250, Easing.CubicOut);
        }
    }

    private async void CloseMenu_Clicked(object sender, EventArgs e)
    {
        await SideMenu.TranslateTo(-200, 0, 250, Easing.CubicIn);
        SideMenu.IsVisible = false;
    }

    private async void GoToLoginPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void Feminino_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatalogoPage());
    }
    
    private async void Masculino_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatalogoPage());
    }
    private async void Acessorios_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatalogoPage());
    }
    private async void SobreNos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }

    private async void MeuPerfil_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PerfilPage());
    }

    private async void GoToHomePage_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void CamisaMasculina_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

    private async void Nike_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

    private async void Relogio_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

    private async void Adidas_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

    private async void Perfume_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }
    private async void CamisaFeminina_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

    private async void Carrinho_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

}