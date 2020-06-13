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
    [QueryProperty("CatId", "catId")]
    [QueryProperty("Name", "name")]
    public partial class CatDetailsPage : ContentPage
    {
        private string _catId;
        public string CatId
        {
            get => _catId;
            set
            {
                _catId = value;
                OnPropertyChanged();
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = Uri.UnescapeDataString(value);//URLデコードする
                OnPropertyChanged();
            }
        }

        public CatDetailsPage()
        {
            InitializeComponent();

            this.BindingContext = this;
        }
    }
}