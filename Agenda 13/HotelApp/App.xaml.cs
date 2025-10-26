namespace HotelApp
{

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Views.Sobre());
			//Searched on google for "maui disable device dark mode" and found
			//https://stackoverflow.com/questions/75716460/how-to-switch-to-light-mode-despite-dark-mode-setting-for-the-phone
			Application.Current.UserAppTheme = AppTheme.Light;
		}
		protected override Window CreateWindow(IActivationState? activationState)
        {
			var window = base.CreateWindow(activationState);

			window.Width = 400;
			window.Height = 600;

			return window;
        }
	}//closing class
}//closing namespace
