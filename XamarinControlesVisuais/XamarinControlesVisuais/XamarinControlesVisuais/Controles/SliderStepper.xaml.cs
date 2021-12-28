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
    public partial class SliderStepper : ContentPage
    {
        public SliderStepper()
        {
            InitializeComponent();
        }
        private void ActionValorMudou(object sender, ValueChangedEventArgs args)
        {
            slideResult.Text = args.NewValue.ToString();
        }        
        private void ActionValorMudouStepper(object sender, ValueChangedEventArgs args)
        {
            stepperResult.Text = args.NewValue.ToString();
        }
    }
}