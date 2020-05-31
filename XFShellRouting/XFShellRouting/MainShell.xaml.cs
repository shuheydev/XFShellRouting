using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellRouting.Views;

namespace XFShellRouting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainShell : Shell
    {
        public MainShell()
        {
            InitializeComponent();

            #region Set default page if you want

            //Set page in tab as default page
            //ShellのCurrentItemを指定(shellAnimalsという名前のFlyoutItem)
            CurrentItem = shellAnimals;

            //shellAnimalsのCurrentItemを指定(shellDomesticという名前のTab)
            shellAnimals.CurrentItem = shellDomestic;

            //shellDomesticのCurrentItemを指定(shellDogsという名前のShellContent)
            shellDomestic.CurrentItem = shellDogs;


            ////Set page under FlyoutItem as default page
            ////ShellSectionで囲み, そちらをCurrentItemとして指定する
            //CurrentItem = shellAnimals;
            //shellAnimals.CurrentItem = shellElephants;


            //CurrentItem = shellAbout;


            ////ShellSectionで囲まない場合,
            ////Bearsページは表示されるが,下タブのBearsは選択状態にならないので注意.
            //CurrentItem = shellAnimals;
            //shellAnimals.CurrentItem = shellBears;
            #endregion
        }
    }
}