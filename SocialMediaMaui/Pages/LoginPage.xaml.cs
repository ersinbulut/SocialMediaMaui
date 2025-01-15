namespace SocialMediaMaui.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void RegisterBtn_Clicked(object sender, EventArgs e)
    {
        // Navigate to RegisterPage
        await Shell.Current.GoToAsync("RegisterPage");
    }

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        // Navigate to HomePage
        await Shell.Current.GoToAsync("HomePage");
    }
}