using BasicNavigation.Views;

namespace BasicNavigation;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private async void SimpleNavigationButton_Clicked(object sender, EventArgs e)
    {
        // See Page navigation, https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/get-started#page-navigation
        var simpleNavigationPage = new SimpleNavigationPage();
		simpleNavigationPage.SomeIntegerData = count;
		await Navigation.PushAsync(simpleNavigationPage);
    }
}

