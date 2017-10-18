using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
          
            this.Detail = new MyTabbedPage();
            this.Master = new MasterPage();
            this.Detail.Icon = "icon.png";
            this.Icon = "icon.png";
           // NavigationPage.SetHasNavigationBar(this,false);
            // this.IsGestureEnabled = false;




        }
    }
}