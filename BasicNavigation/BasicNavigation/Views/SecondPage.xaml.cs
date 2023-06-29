namespace BasicNavigation.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
        GoToMainPage.Clicked += GoToMainPage_Clicked;

        OpenDetailsPage.Clicked += OpenDetailsPage_Clicked;
	}

    private async void OpenDetailsPage_Clicked(object sender, EventArgs e)
    {
        // See Pass data, https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation#pass-data
        string data = InfoForDetailsPage.Text;

        // Remember to register the route before navigating to it, https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation#register-detail-page-routes
        // In this app the registering is done in the AppShell.xaml.cs file in the constructor.
        await Shell.Current.GoToAsync($"secondpage/details?passeddata={data}");
    }

    private async void GoToMainPage_Clicked(object sender, EventArgs e)
    {
        // See Perform navigation, https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation#perform-navigation
        await Shell.Current.GoToAsync("//MainPage");
    }
}