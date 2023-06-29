using BasicNavigation.Views;

namespace BasicNavigation;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("secondpage/details", typeof(DetailsPage));
	}
}
