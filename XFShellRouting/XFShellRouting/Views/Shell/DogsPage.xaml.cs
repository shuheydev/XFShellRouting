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
    public partial class DogsPage : ContentPage
    {
        public DogsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation PushModal
            //await Shell.Current.Navigation.PushModalAsync(new ElephantsPage());

            //Navigation Push
            //await Shell.Current.Navigation.PushAsync(new ElephantsPage());

            //GoToAsyncで遷移
            //両方のRouteを登録してあるのでどちらでも良い
            //await Shell.Current.GoToAsync("elephants/details");
            await Shell.Current.GoToAsync("elephantDetails");
        }
    }
}