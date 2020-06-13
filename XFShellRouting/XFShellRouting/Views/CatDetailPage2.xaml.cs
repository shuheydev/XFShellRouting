using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellRouting.ViewModels;

namespace XFShellRouting.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatDetailPage2 : ContentPage
    {
        public CatDetailPage2()
        {
            InitializeComponent();

            this.BindingContext = new CatDetailPage2ViewModel();
        }
    }
}