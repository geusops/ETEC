// App.xaml.cs

using MauiAppMeuCombustivel; // Mantenha este 'using'
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MauiAppMeuCombustivel //  ADICIONE AQUI O INÍCIO DO NAMESPACE
{
    public partial class App : Application
    {
        public App()
        {
            // Agora, o InitializeComponent deve ser reconhecido!
            InitializeComponent(); 

            // Seu código de inicialização da página:
            MainPage = new AppShell(); // Ou o que você estiver usando
        }
    }
} // 👈 ADICIONE AQUI O FIM DO NAMESPACE