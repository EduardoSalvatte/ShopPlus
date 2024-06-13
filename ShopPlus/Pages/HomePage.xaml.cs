using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ShopPlus.Pages
{
    public partial class HomePage : ContentPage
    {

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<BestSeller> BestSellers { get; set; }

        public HomePage()
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

            // Inicializa a lista de mais vendidos
            BestSellers = new ObservableCollection<BestSeller>
            {
                new BestSeller { Name = "Camisa", Image = "camisamasculinaquadrada.png", Price = "R$ 199,99", Installments = "ou 3x de R$67" },
                new BestSeller { Name = "Tênis Nike", Image = "tenisnikequadrado.png", Price = "R$ 449,90", Installments = "ou 5x de R$110" },
                new BestSeller { Name = "Relógio", Image = "relogioquadrado.png", Price = "R$ 99,50", Installments = "ou 2x de R$50" },
                new BestSeller { Name = "Tênis Adidas", Image = "tenisadidasquadrado.png", Price = "R$ 379,49", Installments = "ou 4x de R$95" }
            };

            // Define o contexto de dados para a página
            BindingContext = this;
        }

        // Manipulador de evento para a seta de navegação anterior das categorias
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

        // Manipulador de evento para a seta de navegação anterior dos mais vendidos
        private void PreviousBestSeller_Clicked(object sender, EventArgs e)
        {
            if (BestSellersCarousel.Position > 0)
            {
                BestSellersCarousel.Position -= 1;
            }
            else
            {
                BestSellersCarousel.Position = BestSellers.Count - 1;
            }
        }

        // Manipulador de evento para a seta de navegação seguinte dos mais vendidos
        private void NextBestSeller_Clicked(object sender, EventArgs e)
        {
            if (BestSellersCarousel.Position < BestSellers.Count - 1)
            {
                BestSellersCarousel.Position += 1;
            }
            else
            {
                BestSellersCarousel.Position = 0;
            }
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
        private async void Imagem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CatalogoPage()); 
        }
        private async void ImagemCompras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComprasPage()); 
        }


    }

    //Botar aqui mesmo pra ficar mais facil
    public class Category
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }

    public class BestSeller
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Installments { get; set; }
    }
}
