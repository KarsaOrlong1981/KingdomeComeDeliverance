

namespace KingdomeComeDeliverance.Services
{
    public interface IShellNavigationService
    {
        event EventHandler<ShellNavigatedEventArgs> NavigationChanged;
        Task NavigateTo(string url);
        Task GoBack();      
    }
}
