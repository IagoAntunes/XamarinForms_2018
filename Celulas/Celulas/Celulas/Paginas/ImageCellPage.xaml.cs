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
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario
            {
                Nome = "Jose",
                Cargo = "Presidente",
                Foto = "FotoPerfil.png"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Maria",
                Cargo = "GerenteVendas",
                Foto = "FotoPerfil.png"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Elaine",
                Cargo = "Gerente de Marketing",
                Foto = "FotoPerfil.png"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Felipe",
                Cargo = "Entregador",
                Foto = "FotoPerfil.png"
            });
            Lista.Add(new Funcionario
            {
                Nome = "Joao",
                Cargo = "Vendedor",
                Foto = "FotoPerfil.png"
            });
            ListaFuncionario.ItemsSource = Lista;

        }
    }
}