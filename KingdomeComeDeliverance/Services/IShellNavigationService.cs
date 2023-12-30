

namespace KingdomeComeDeliverance.Services
{
    public interface IShellNavigationService
    {
        event EventHandler NavigationChanged;
        Task NavigateTo(string url);
        Task GoBack();      
    }
}
