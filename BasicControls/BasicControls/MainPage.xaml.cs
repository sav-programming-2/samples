namespace BasicControls;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        // Event handling in XAML, https://learn.microsoft.com/fi-fi/training/modules/create-user-interface-xaml/4-event-handling-xaml
        this.ReadMyTextInput.Clicked += ReadMyTextInput_Clicked_Other;
	}

    private async void ReadMyTextInput_Clicked_Other(object sender, EventArgs e)
    {
        // Display pop-ups, https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pop-ups
        await DisplayAlert("Tekstisyöte", this.MyTextInput.Text, "OK");
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

    private void ReadMyTextInput_Clicked(object sender, EventArgs e)
    {
		this.MyLabel.Text = this.MyTextInput.Text;
    }
}

