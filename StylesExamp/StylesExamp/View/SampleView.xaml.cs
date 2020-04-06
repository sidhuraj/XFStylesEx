using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StylesExamp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesExamp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleView : ContentPage
    {
        public SampleView()
        {
            InitializeComponent();
            BindingContext = new SampleViewModel();
        }
    }
}