using Celulas.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Celulas.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void GoPagina1(object sender,EventArgs args)
        {
            Detail = new NavigationPage(new TextCellPage());
        }
        private void GoPagina2(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ImageCellPage());
        }
        private void GoPagina3(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new EntryCellPage());
        }
        private void GoPagina4(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new SwitchCellPage());
        }
        private void GoPagina5(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ViewCellPage());
        }
        private void GoPagina6(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ListViewPage());
        }
        private void GoPagina7(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ListViewButtonPage());
        }
    }
}