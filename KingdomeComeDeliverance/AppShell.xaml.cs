using CommunityToolkit.Mvvm.DependencyInjection;
using KingdomeComeDeliverance.Services;

namespace KingdomeComeDeliverance
{
    public partial class AppShell : Shell
    {
        public static AppShell Instance;
        public AppShell()
        {
            InitializeComponent();
            Instance = this;
        }
    }
}
