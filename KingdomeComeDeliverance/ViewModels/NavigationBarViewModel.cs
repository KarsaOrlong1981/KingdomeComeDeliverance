using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using KingdomeComeDeliverance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingdomeComeDeliverance.ViewModels
{
    public partial class NavigationBarViewModel : ObservableObject
    {
        [ObservableProperty] private string title;
        [ObservableProperty] private char firstChar;    

        [ObservableProperty]
        private bool canGoBack = true;

        private IShellNavigationService shellNavigationService;
        public NavigationBarViewModel() 
        {
            shellNavigationService = Ioc.Default.GetService<IShellNavigationService>();
            shellNavigationService.NavigationChanged += ShellNavigationService_NavigationChanged;
        }

        private void ShellNavigationService_NavigationChanged(object? sender, ShellNavigatedEventArgs e)
        {
           var tempTitle = GetPageTitle(e.Current.Location.OriginalString);
           FirstChar = tempTitle[0];
           Title = tempTitle.Substring(1);
        }

        private string GetPageTitle(string locationUri)
        {
            CanGoBack = true;
            var result = string.Empty;
            var location = locationUri.Split('/').Last();
            if (location == Constants.ActivityPageRoute)
                result = "Aktivitäten";
            else if (location == Constants.ArmorPageRoute)
                result = "Rüstungen";
            else if (location == Constants.CharactersPageRoute)
                result = "Charaktere";
            else if (location == Constants.ClothesPageRoute)
                result = "Kleidung";
            else if (location == Constants.ItemsPageRoute)
                result = "Gegenstände";
            else if (location == Constants.MainMenuePageRoute)
            {
                result = "Optionen";
                CanGoBack = false;
            }  
            else if (location == Constants.MainQuestsPageRoute)
                result = "Hauptquests";
            else if (location == Constants.SideQuestsPageRoute)
                result = "Nebenquests";
            else if (location == Constants.SkillsPageRoute)
                result = "Fertigkeiten";
            else if (location == Constants.WeaponsPageRoute)
                result = "Waffen";
            else if (location == Constants.TrophysPageRoute)
                result = "Trophäen";
            else if (location == Constants.MapsPageRoute)
                result = "Karten";
            else if (location == Constants.AlchemiePageRoute)
                result = "Alchemie";
            return result;
        }

        [RelayCommand]
        private async Task GoBack()
        {
           await shellNavigationService.GoBack();
        }
    }
}
