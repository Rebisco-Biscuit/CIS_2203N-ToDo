namespace ToDo_G10;
using ToDo_G10.Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	// 	protected override Window CreateWindow(IActivationState? activationState)
	// {
	// 	return new Window(new NavigationPage(new MainPage()));
	// }
}
