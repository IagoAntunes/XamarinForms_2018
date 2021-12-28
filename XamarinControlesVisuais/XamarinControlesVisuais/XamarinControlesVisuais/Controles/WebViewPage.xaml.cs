using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControlesVisuais.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

        }

        private void GoPagina(Object sender,EventArgs args)
        {
            Navegador.Source = EnderecoSite.Text;
        }
        private void GoProximo(Object sender,EventArgs args)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }
        private void GoVoltar(Object sender,EventArgs args)
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
            }
        }
        private void ActionCarregando(Object sender,EventArgs args)
        {
            lblStatus.Text = "Carregando...";
        }
        private void ActionCarregado(Object sender,EventArgs args)
        {
            lblStatus.Text = "Finalizado...";
        }
    }
}