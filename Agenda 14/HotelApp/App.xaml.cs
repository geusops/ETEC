using HotelApp.Models;

namespace HotelApp
{

	public partial class App : Application
	{
		public List<Quarto> lista_quartos = new List<Quarto>()
		{
			new Quarto()
			{
				Descricao = "Suíte Super Luxo",
				ValorDiariaAdulto = 110.0,
				ValorDiariaCrianca = 55.0
			},
			new Quarto()
			{
				Descricao = "Suíte  Luxo",
				ValorDiariaAdulto = 80.0,
				ValorDiariaCrianca = 40.0
			},
			new Quarto()
			{
				Descricao = "Suíte Single",
				ValorDiariaAdulto = 50.0,
				ValorDiariaCrianca = 25.0
			},
			new Quarto()
			{
				Descricao = "Suíte Crise",
				ValorDiariaAdulto = 25.0,
				ValorDiariaCrianca = 12.5
			}

		};
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
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
