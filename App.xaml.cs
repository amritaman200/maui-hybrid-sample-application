using maui_hybrid.Models;

namespace maui_hybrid
{
    public partial class App : Application
    {
        public static List<Product> CartList = new List<Product>();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }
    }
}
