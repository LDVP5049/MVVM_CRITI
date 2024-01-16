using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_CRITI.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_CRITI.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Critico : ContentPage
    {
        public Critico()
        {
            InitializeComponent();
            BindingContext = new VMcritico(Navigation);
        }

    }
}