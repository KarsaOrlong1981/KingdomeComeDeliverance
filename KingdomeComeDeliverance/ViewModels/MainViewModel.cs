using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using KingdomeComeDeliverance.Services;

namespace KingdomeComeDeliverance.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private IShellNavigationService shellNavigationService;

        public MainViewModel()
        {
            shellNavigationService = Ioc.Default.GetService<IShellNavigationService>();
        }

        [RelayCommand]
        private void GotoActivitysPage()
        {
            shellNavigationService.NavigateTo(Constants.ActivityPageRoute);
        }
    }
}
