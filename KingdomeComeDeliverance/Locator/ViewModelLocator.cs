using CommunityToolkit.Mvvm.DependencyInjection;
using KingdomeComeDeliverance.Services;
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
                   .AddSingleton<IShellNavigationService,  ShellNavigationService>()
                   //ViewModels
                   .AddSingleton<MainViewModel>()
                   .AddSingleton<ActivitysPageViewModel>()
                   .AddSingleton<ArmorPageViewModel>()
                   .AddSingleton<CharactersPageViewModel>()
                   .AddSingleton<ClothesPageViewModel>()
                   .AddSingleton<ItemsPageViewModel>()
                   .AddSingleton<MainQuestsPageViewModel>()
                   .AddSingleton<SideQuestsPageViewModel>()
                   .AddSingleton<SkillsPageViewModel>()
                   .AddSingleton<WeaponsPageViewModel>()
                    .BuildServiceProvider()
                    );
        }

        public MainViewModel Main => Ioc.Default.GetService<MainViewModel>();
        public ActivitysPageViewModel Activitys => Ioc.Default.GetService<ActivitysPageViewModel>();
        public ArmorPageViewModel Armor => Ioc.Default.GetService<ArmorPageViewModel>();
        public CharactersPageViewModel Characters => Ioc.Default.GetService<CharactersPageViewModel>();
        public ClothesPageViewModel Clothes => Ioc.Default.GetService<ClothesPageViewModel>();
        public ItemsPageViewModel Items => Ioc.Default.GetService<ItemsPageViewModel>();
        public MainQuestsPageViewModel MainQuests => Ioc.Default.GetService<MainQuestsPageViewModel>();
        public SideQuestsPageViewModel SideQuests => Ioc.Default.GetService<SideQuestsPageViewModel>();
        public SkillsPageViewModel Skills => Ioc.Default.GetService<SkillsPageViewModel>();
        public WeaponsPageViewModel Weapons => Ioc.Default.GetService<WeaponsPageViewModel>();

    }
}
