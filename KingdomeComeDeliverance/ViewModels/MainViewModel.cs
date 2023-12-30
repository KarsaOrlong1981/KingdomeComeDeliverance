using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using KingdomeComeDeliverance.Models;
using KingdomeComeDeliverance.Services;
using System.Collections.ObjectModel;

namespace KingdomeComeDeliverance.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Options> options;
        [ObservableProperty]
        private Options option;

        private IShellNavigationService shellNavigationService;

        public MainViewModel()
        {
            shellNavigationService = Ioc.Default.GetService<IShellNavigationService>();
            shellNavigationService.NavigationChanged += ShellNavigationService_NavigationChanged;
            CreateOptions();
        }

        private void ShellNavigationService_NavigationChanged(object? sender, ShellNavigatedEventArgs e)
        {
            Option = null;
        }

        private void CreateOptions()
        {
            Options = new ObservableCollection<Options>();
            Options.Add(new Models.Options { Title = "Hauptquests", BackgroundImage = "mainquests.jpg", NavigationPath = Constants.MainQuestsPageRoute });
            Options.Add(new Models.Options { Title = "NebenQuests", BackgroundImage = "sidequests.jpg", NavigationPath = Constants.SideQuestsPageRoute });
            Options.Add(new Models.Options { Title = "Aktivitäten", BackgroundImage = "kcd7bg.jpg", NavigationPath = Constants.ActivityPageRoute});
            Options.Add(new Models.Options { Title = "Fertigkeiten", BackgroundImage = "thief.jpg", NavigationPath = Constants.SkillsPageRoute });
            Options.Add(new Models.Options { Title = "Rüstungen", BackgroundImage = "armor.jpg", NavigationPath = Constants.ArmorPageRoute});
            Options.Add(new Models.Options { Title = "Waffen", BackgroundImage = "weapons.jpg", NavigationPath = Constants.WeaponsPageRoute });
            Options.Add(new Models.Options { Title = "Kleidung", BackgroundImage = "clothes.jpg", NavigationPath = Constants.ClothesPageRoute });
            Options.Add(new Models.Options { Title = "Charaktere", BackgroundImage = "characters.jpg", NavigationPath = Constants.CharactersPageRoute });
            Options.Add(new Models.Options { Title = "Gegenstände", BackgroundImage = "kcd2bg.jpg", NavigationPath = Constants.ItemsPageRoute });
            Options.Add(new Models.Options { Title = "Alchemie", BackgroundImage = "alchemie.jpg", NavigationPath = Constants.AlchemiePageRoute });
            Options.Add(new Models.Options { Title = "Trophäen", BackgroundImage = "trophyking.png", NavigationPath = Constants.TrophysPageRoute });
            Options.Add(new Models.Options { Title = "Karten", BackgroundImage = "kcd6bg.jpg", NavigationPath = Constants.MapsPageRoute });
        }

        [RelayCommand]
        private async Task GotoPage(string path)
        {
            await shellNavigationService.NavigateTo(path);
        }
    }
}
