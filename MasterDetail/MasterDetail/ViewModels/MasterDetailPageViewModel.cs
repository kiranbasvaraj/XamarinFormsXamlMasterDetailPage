using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.ViewModels
{
  public  class MasterDetailPageViewModel
    {
        public ObservableCollection<MasterDetailPageModel> List { get; set;}
        public MasterDetailPageViewModel()
        {
            List = new ObservableCollection<MasterDetailPageModel>();
            List.Add(new MasterDetailPageModel {Title="about",Icon="icon" });
            List.Add(new MasterDetailPageModel { Title = "contacts", Icon = "icon" });
            List.Add(new MasterDetailPageModel { Title = "items", Icon = "icon" });
            List.Add(new MasterDetailPageModel { Title = "food", Icon = "icon" });
            List.Add(new MasterDetailPageModel { Title = "drinks", Icon = "icon" });
            List.Add(new MasterDetailPageModel { Title = "meals", Icon = "icon" });
            List.Add(new MasterDetailPageModel { Title = "dinner", Icon = "icon" });
        }
    }
}
