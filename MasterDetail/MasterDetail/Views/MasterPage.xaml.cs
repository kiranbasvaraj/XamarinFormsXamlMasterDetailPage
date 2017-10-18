using MasterDetail.Models;
using MasterDetail.ViewModels;
using MasterDetail.Views.SideBarPages;
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
    public partial class MasterPage : ContentPage
    {
        private MasterDetailPageViewModel _masterDetailVm;

        public MasterPage()
        {
            InitializeComponent();
            _masterDetailVm = new MasterDetailPageViewModel();
            BindingContext = _masterDetailVm;
        }

        //private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //   var item= e.Item as MasterDetailPageModel;
        //    if (item.Title.ToLower()=="about")
        //    {
        //        Navigation.PushAsync(new AboutPageSideBar());
        //    }
        //    else if (item.Title.ToLower() == "dinner")
        //    {
        //        Navigation.PushAsync(new DinnerPageSideBar());
        //    }
        //    else if (item.Title.ToLower() == "meals")
        //    {
        //        Navigation.PushAsync(new MealsPageSideBar());
        //    }
        //    else if (item.Title.ToLower() == "drinks")
        //    {
        //        Navigation.PushAsync(new DrinksPageSideBar());
        //    }
        //}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           var item= e.SelectedItem as MasterDetailPageModel;
            if (item.Title.ToLower() == "about")
            {
                Navigation.PushAsync(new AboutPageSideBar());
            }
            else if (item.Title.ToLower() == "dinner")
            {
                Navigation.PushAsync(new DinnerPageSideBar());
            }
            else if (item.Title.ToLower() == "meals")
            {
                Navigation.PushAsync(new MealsPageSideBar());
            }
            else if (item.Title.ToLower() == "drinks")
            {
                Navigation.PushAsync(new DrinksPageSideBar());
            }
        }
    }
}