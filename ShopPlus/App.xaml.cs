using ShopPlus.Data;
using ShopPlus.Model;
using ShopPlus.Pages;
using System.Collections.ObjectModel;

namespace ShopPlus
{
    public partial class App : Application
    {
        static SQLiteData _bancoDados;

        internal static ObservableCollection<Produto> Carrinho { get; set; } = new ObservableCollection<Produto>();

        public static SQLiteData BancoDados
        {
            get
            {
                if (_bancoDados == null)
                {
                    _bancoDados = new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dados.db3"));
                }
                return _bancoDados;
            }
        }
        public static Usuario Usuario { get; set; }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
