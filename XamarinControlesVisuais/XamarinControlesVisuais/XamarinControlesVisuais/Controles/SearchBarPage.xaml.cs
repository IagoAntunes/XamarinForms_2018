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
    public partial class SearchBarPage : ContentPage
    {
        private List<string> EmpresasTI;
        public SearchBarPage()
        {
            InitializeComponent();
            EmpresasTI = new List<string>();
            EmpresasTI.Add("Microsoft");
            EmpresasTI.Add("Apple");
            EmpresasTI.Add("Oracle");
            EmpresasTI.Add("IBM");
            EmpresasTI.Add("Uber");

            Preencher(EmpresasTI);
        }

        //TextChangedEventArgs args
        public void PesquisarButton(object sender, EventArgs args)
        {
            var resultado = EmpresasTI.Where((a) => a.Contains(((SearchBar)sender).Text)).ToList<string>();
            Preencher(resultado);
        }
        private void Pesquisar(object sender,TextChangedEventArgs args){
            var resultado = EmpresasTI.Where((a)=> a.Contains(((SearchBar)sender).Text)).ToList<string>();

            Preencher(resultado);
        }


        private void Preencher(List<string> EmpresasTI)
        {
            listResult.Children.Clear();
            foreach (var emp in EmpresasTI)
            {
                listResult.Children.Add(new Label { Text = emp });
            }
        }
    }
}