using KingdomeComeDeliverance.Pages;

namespace KingdomeComeDeliverance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
