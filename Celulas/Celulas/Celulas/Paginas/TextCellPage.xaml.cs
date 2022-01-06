using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Celulas.Modelo;

namespace Celulas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
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
            ListaFuncionarios.ItemsSource = Lista;
        }
    }
}