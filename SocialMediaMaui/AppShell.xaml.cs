using SocialMediaMaui.Pages;

namespace SocialMediaMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            HomeRoutes();
            RegisterRoutes();
        }

        private static void HomeRoutes()
        {
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        }

        private static void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        }
    }
}
