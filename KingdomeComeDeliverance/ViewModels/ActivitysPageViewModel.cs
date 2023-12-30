using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using KingdomeComeDeliverance.Services;

namespace KingdomeComeDeliverance.ViewModels
{
    public partial class ActivitysPageViewModel : ObservableObject
    {
        private IShellNavigationService shellNavigationService;

        public ActivitysPageViewModel() 
        {
            shellNavigationService = Ioc.Default.GetService<IShellNavigationService>();
            shellNavigationService.NavigationChanged += ShellNavigationService_NavigationChanged;
        }

        private void ShellNavigationService_NavigationChanged(object? sender, ShellNavigatedEventArgs e)
        {
            var test = e.Current.Location.OriginalString;
        }
    }   
}
