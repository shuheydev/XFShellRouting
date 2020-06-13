using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFShellRouting.ViewModels
{
    [QueryProperty("CatId", "catId")]
    [QueryProperty("Name", "name")]
    public class CatDetailPage2ViewModel : ObservableObject
    {
        private string _catId;
        public string CatId
        {
            get => _catId;
            set => SetProperty(ref _catId, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                SetProperty(ref _name, Uri.UnescapeDataString(value));
            }
        }

        public CatDetailPage2ViewModel()
        {

        }
    }

    [QueryProperty("CatId", "catId")]
    [QueryProperty("Name", "name")]
    public class TestClass : ObservableObject
    {
        private string _catId;
        public string CatId
        {
            get => _catId;
            set => SetProperty(ref _catId, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                SetProperty(ref _name, Uri.UnescapeDataString(value));
            }
        }

        public TestClass()
        {

        }
    }
}
