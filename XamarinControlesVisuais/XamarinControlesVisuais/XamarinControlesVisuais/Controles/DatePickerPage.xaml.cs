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
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
        }
        public void ActionDateSelected(object sender,DateChangedEventArgs args)
        {
            lblResultado.Text = args.OldDate.ToString("dd/MM/yyyy") + " > " + args.NewDate.ToString("dd/MM/yyyy");
        }
    }
}