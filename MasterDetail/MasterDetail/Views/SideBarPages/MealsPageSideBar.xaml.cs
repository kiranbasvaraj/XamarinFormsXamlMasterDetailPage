using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views.SideBarPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealsPageSideBar : ContentPage
    {
        public static string mainurl { get; set; }
        public MealsPageSideBar()
        {
            InitializeComponent();
            Browser.Source = "https://www.google.co.in/?gfe_rd=cr&dcr=0&ei=q6fDWfrHKJSGX6iLnJAM&gws_rd=ssl";
        }

        private void backClicked(object sender, EventArgs e)
        {
           // mainurl = Browser.Source;
            // Check to see if there is anywhere to go back to
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
            else
            { // If not, leave the view
                Navigation.PopAsync();
            }
        }

        private void forwardClicked(object sender, EventArgs e)
        {
          //  mainurl = Browser.Source;
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
            }
        }
        //void webOnNavigating(object sender, WebNavigatingEventArgs e)
        //{
        //    LoadingLabel.IsVisible = true;
        //}

        //void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        //{
        //    LoadingLabel.IsVisible = false;
        //}
    }
}