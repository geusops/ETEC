namespace EventsApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Views.ResumoEvento());
		//MainPage = new AppShell();
		Application.Current.UserAppTheme = AppTheme.Light;
	}
}
