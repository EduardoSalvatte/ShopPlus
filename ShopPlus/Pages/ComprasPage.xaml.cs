
using ShopPlus.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ShopPlus.Pages;

public partial class ComprasPage : ContentPage
{
    public ObservableCollection<Category> Categories { get; set; }
    public ObservableCollection<BestSeller> BestSellers { get; set; }

    public ComprasPage()
    {
        InitializeComponent();

        // Inicializa a lista de categorias
        Categories = new ObservableCollection<Category>
            {
                new Category { Name = "Camisa Masculina", Image = "camisamasculina.png" },
                new Category { Name = "Camisa Feminina", Image = "camisafeminina.png" },
                new Category { Name = "Tênis", Image = "tenis.png" },
                new Category { Name = "Relógios", Image = "relogio.png" },
                new Category { Name = "Perfumes", Image = "perfume.png" },
                new Category { Name = "Pijamas", Image = "pijama.png" }
            };

        // Define o contexto de dados para a página
        BindingContext = this;
    }

    private async void Aviso_Tapped(object sender, EventArgs e)
    {
        await DisplayAlert("Aviso", "A página de compras se encontra em manutenção. Não é possível fazer compras no momento.", "OK");
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

    private void PreviousCategory_Clicked(object sender, EventArgs e)
    {
        if (CategoriesCarousel.Position > 0)
        {
            CategoriesCarousel.Position -= 1;
        }
        else
        {
            CategoriesCarousel.Position = Categories.Count - 1;
        }
    }

    // Manipulador de evento para a seta de navegação seguinte das categorias
    private void NextCategory_Clicked(object sender, EventArgs e)
    {
        if (CategoriesCarousel.Position < Categories.Count - 1)
        {
            CategoriesCarousel.Position += 1;
        }
        else
        {
            CategoriesCarousel.Position = 0;
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

    private async void Carrinho_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ComprasPage());
    }

}