using Celulas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Celulas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario
            {
                Nome = "Jose",
                Cargo = "Presidente"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Maria",
                Cargo = "GerenteVendas"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Elaine",
                Cargo = "Gerente de Marketing"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Felipe",
                Cargo = "Entregador"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Joao",
                Cargo = "Vendedor"
            });
            ListaFuncionario.ItemsSource = Lista;
        }
    
        private void ItemSelecionadoAction(object sender,SelectedItemChangedEventArgs args)
        {
            Funcionario func = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new Detalhe.DetailPage(func));


        }
        private void FeriasAction(object sender,EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;

            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Titulo: " + func.Nome, "Mensagem:" + func.Nome + "-" + func.Cargo, "Ok");
        }
        private void AbonoAction(object sender,EventArgs args)
        {

        }
    
    }
}