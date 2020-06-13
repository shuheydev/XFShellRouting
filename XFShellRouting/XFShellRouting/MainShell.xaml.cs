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



            #region Define Routes
            //ShellContentからのページ遷移
            //詳細ページへのRouteの書き方は一般的にはこんな感じになる
            //どちらでもよい.
            //1つのページへの複数Routeを登録しても良い.
            //Routing.RegisterRoute("elephants/details", typeof(ElephantDetailPage));
            Routing.RegisterRoute("elephantDetails", typeof(ElephantDetailPage));

            //ShellContentに対してもRouteの登録が必要.
            //でも普通はTabとかドロワーメニューから移動するものなのでいらないはず.
            //試しにやってみた.
            Routing.RegisterRoute("elephants", typeof(ElephantsPage));

            Routing.RegisterRoute("catDetails", typeof(CatDetailsPage));
            Routing.RegisterRoute("catDetails2", typeof(CatDetailPage2));
            #endregion
        }
    }
}