namespace BasicNavigation.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
        GoToMainPage.Clicked += GoToMainPage_Clicked;
	}

    private async void GoToMainPage_Clicked(object sender, EventArgs e)
    {
        // See Perform navigation, https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation#perform-navigation
        await Shell.Current.GoToAsync("//MainPage");
    }
}