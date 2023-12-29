using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using KingdomeComeDeliverance.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingdomeComeDeliverance.Extensions
{
    public static class PageExtensions
    {
        public static ObservableRecipient GetViewModel(this Services.Navigation.NavigationPage page)
        {
            if (page.Page == ENavigationPage.DASHBOARD)
            {
                //return Ioc.Default.GetService<ViewModel> ();
            }
            return null;
        }
    }
}
