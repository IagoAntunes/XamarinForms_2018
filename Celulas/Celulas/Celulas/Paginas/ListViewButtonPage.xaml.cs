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
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
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
        private void FeriasAction(object sender,EventArgs args)
        {
            Button btnFerias = (Button)sender;
            Funcionario func = (Funcionario)btnFerias.CommandParameter;

            DisplayAlert("Ferias", "Mensagem:" + func.Nome + "--" + func.Cargo, "Ok");
        }
    }
}