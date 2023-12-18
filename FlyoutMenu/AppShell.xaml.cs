using FlyoutMenu.Pages;

namespace FlyoutMenu
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("//Settings", typeof(Settings));
            Routing.RegisterRoute("//Profile", typeof(Profile));
            Routing.RegisterRoute("//Support", typeof(Support));
            Routing.RegisterRoute("//Announce", typeof(Announce));
            Routing.RegisterRoute("//Events", typeof(Events));
        }

        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    await Shell.Current.DisplayAlert("Menu item tapped", "This item was tapped from the custom flyout content", "Ok");
        //}

        private async void Profile_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Profile");
            Shell.Current.FlyoutIsPresented = false;
        }

        private async void Settings_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Settings");
            Shell.Current.FlyoutIsPresented = false;
        }

        private async void Support_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Support");
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
