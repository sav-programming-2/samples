using System.ComponentModel;

namespace BasicNavigation.Views;

[QueryProperty("PassedData", "passeddata")]
public partial class DetailsPage : ContentPage
{
	string passedData;

	public string PassedData
	{
        get => passedData;
        set
		{
            passedData = value;
            OnPropertyChanged(nameof(PassedData));
            
            // set passed data to the label
            ShowPassedData.Text = passedData;
        }
    }
    
    public DetailsPage()
	{
		InitializeComponent();
	}
}