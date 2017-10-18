using MasterDetail.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterDetail.Views.SideBarPages;
namespace MasterDetail.Views.SideBarPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPageSideBar : ContentPage
    {
        string selectedValue;
        public AboutPageSideBar()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string url = selectedValue;

          //  http://media1.santabanta.com/full1/Cricket/Sachin%20Tendulkar/sachin-tendulkar-75v.jpg
          DependencyService.Get<IDownloadFile>().Download(url, "GoogleImage");
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedValue = picker.Items[picker.SelectedIndex];
        }
    }
}