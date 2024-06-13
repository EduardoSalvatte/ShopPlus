using ShopPlus.Model;
using ShopPlus.Data;

namespace ShopPlus.Pages;

public partial class PerfilPage : ContentPage
{

    private Usuario _usuario;
	public PerfilPage()
	{
		InitializeComponent();

        _usuario = App.Usuario;

        this.BindingContext = _usuario;

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

    private async void GoToHomePage_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void Feminino_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatalogoPage());
    }

    private async void Masculino_Clicked(object sender, EventArgs e)
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

    private async void Acessorios_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatalogoPage());
    }

    private async void Carrinho_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

    private async void Apagar_Clicked(object sender, EventArgs e)
    {
        bool resposta = await DisplayAlert("Confirmar Exclusão", "Tem certeza de que deseja apagar a conta?", "Sim", "Não");
        if (resposta)
        {
            // Apagar as informações do usuário
            await ApagarUsuario();

            // Redirecionar para a página de cadastro
            await Navigation.PushAsync(new CadastroPage());
        }
    }

    private async Task ApagarUsuario()
    {
        // Lógica para apagar as informações do usuário
        await App.BancoDados.UsuarioDataTable.DeletarUsuario(_usuario);

        // Limpar as informações do usuário localmente
        _usuario = new Usuario();
        this.BindingContext = _usuario;
    }
}