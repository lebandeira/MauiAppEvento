
using MauiAppEvento.Models;

namespace MauiAppEvento
{
    public partial class App : Application
    {
        public List<IngressoTipo> lista_ingresso = new List<IngressoTipo>
       {
           new IngressoTipo()
           {
               Descricao = "Theatro Municipal De São Paulo",
               ValorIngresso = 210.0
           },
           new IngressoTipo()
           {
               Descricao = "Online",
               ValorIngresso = 190.0
            }
       };



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Evento());
        }
    }
}
