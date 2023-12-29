using CommunityToolkit.Mvvm.DependencyInjection;
using KingdomeComeDeliverance.ViewModels;

namespace KingdomeComeDeliverance.Locator
{
    public class ViewModelLocator
    {
        public ViewModelLocator() 
        {
            Init();
        }

        private void Init()
        {
            Ioc.Default.ConfigureServices(
                   new ServiceCollection()
                   //Services
                  
                   //ViewModels
                   .AddSingleton<MainViewModel>()
                    .BuildServiceProvider()
                    );
        }

        public MainViewModel Main => Ioc.Default.GetService<MainViewModel>();
        // add the needed viewmodels for Tabs

        // add all other viewModels
    }
}
