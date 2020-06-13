using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFShellRouting.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int selectedCatId = 10;
            string selectedCatName = "たま";
            await Shell.Current.GoToAsync($"catDetails?catId={selectedCatId}&name={selectedCatName}");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            int selectedCatId = 20;
            string selectedCatName = "ポチ";
            await Shell.Current.GoToAsync($"catDetails2?catId={selectedCatId}&name={selectedCatName}");
        }
    }
}