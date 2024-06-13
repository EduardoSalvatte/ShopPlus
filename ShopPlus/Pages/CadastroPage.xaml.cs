using ShopPlus.Model;

namespace ShopPlus.Pages;

public partial class CadastroPage : ContentPage
{

    Usuario _usuario;

	public CadastroPage()
	{
		InitializeComponent();

        _usuario = new Usuario();

        this.BindingContext = _usuario;
	}

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_usuario.Email) || string.IsNullOrEmpty(_usuario.Senha) || string.IsNullOrEmpty(_usuario.Nome))
        {
            await DisplayAlert("Erro", "Preencha todas as informa��es", "Fechar");
            return;
        }

        var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usu�rio cadastrado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }
    }


    private async void OnEntrarClicked(object sender, EventArgs e)
    {
        // Navegar para a p�gina de cadastro
        await Navigation.PushAsync(new LoginPage());
    }

    private async void OnShopPlusLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}