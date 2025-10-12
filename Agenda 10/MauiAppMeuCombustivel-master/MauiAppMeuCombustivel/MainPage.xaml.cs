namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                string marca = text_marca.Text;
                string modelo = text_modelo.Text;
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                //calculo sobre o combustivel
                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando para seu ";
                }
                else
                {
                    msg = "A gasolina está compensando para seu ";
                }

                //estrutura da mensagem a ser exibida caso o usuario nao adicione o modelo ou marca
                //referencia: https://stackoverflow.com/questions/15660461/one-liner-for-if-string-is-not-null-or-empty-else
                if (String.IsNullOrEmpty(marca) && String.IsNullOrEmpty(modelo))
                {
                    msg = msg + "carro.";
                }
                else if (String.IsNullOrEmpty(marca))
                {
                    msg = msg + modelo + ".";
                }
                else if (String.IsNullOrEmpty(modelo))
                {
                    msg = msg + marca + ".";
                }
                else
                {
                    msg = msg + marca + " " + modelo + ".";
                }
                DisplayAlert("Calculado", msg, "OK");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } // Fecha método
    } //Fecha Class
} // Fecha namespace
