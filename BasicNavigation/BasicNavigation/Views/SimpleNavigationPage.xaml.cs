namespace BasicNavigation.Views;

public partial class SimpleNavigationPage : ContentPage
{
	int someIntegerData;
    public int SomeIntegerData
	{
		get => someIntegerData;
		set
		{
            someIntegerData = value;
            OnPropertyChanged(nameof(SomeIntegerData));
            // set data to the label
            LabelForData.Text = someIntegerData.ToString();
        }
	}
    public SimpleNavigationPage()
	{
		InitializeComponent();
	}
}