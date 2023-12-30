using KingdomeComeDeliverance.Pages;

namespace KingdomeComeDeliverance.Services
{
    public class ShellNavigationService : IShellNavigationService
    {
        public ShellNavigationService() 
        {
            RegisterRoutes();
            AppShell.Instance.Navigated += Instance_Navigated;
        }

        public event EventHandler NavigationChanged;

        private void Instance_Navigated(object? sender, ShellNavigatedEventArgs e)
        {
            NavigationChanged?.Invoke(this, e);
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(Constants.ActivityPageRoute, typeof(ActivitysPage));
            Routing.RegisterRoute(Constants.ArmorPageRoute, typeof(ArmorPage));
            Routing.RegisterRoute(Constants.CharactersPageRoute, typeof(CharactersPage));
            Routing.RegisterRoute(Constants.ClothesPageRoute, typeof(ClothesPage));
            Routing.RegisterRoute(Constants.ItemsPageRoute, typeof(ItemsPage));
            Routing.RegisterRoute(Constants.MainQuestsPageRoute, typeof(MainQuestsPage));
            Routing.RegisterRoute(Constants.SideQuestsPageRoute, typeof(SideQuestsPage));
            Routing.RegisterRoute(Constants.SkillsPageRoute, typeof(SkillsPage));
            Routing.RegisterRoute(Constants.WeaponsPageRoute, typeof(WeaponsPage));
        }
        public async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        public async Task NavigateTo(string url)
        {
            await Shell.Current.GoToAsync(url);
        }
    }
}
