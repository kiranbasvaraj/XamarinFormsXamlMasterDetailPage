using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Runtime.CompilerServices;
using MasterDetail.Interfaces;
using MasterDetail.Droid.DependencyServices;

[assembly: Xamarin.Forms.Dependency(typeof(DownloadFile))]
namespace MasterDetail.Droid.DependencyServices
{
   public class DownloadFile: IDownloadFile
    {
        public DownloadFile()
        {

        }
        public void Download(string uri, string filename)
        {
            Android.Net.Uri contentUri = Android.Net.Uri.Parse(uri);

            Android.App.DownloadManager.Request r = new Android.App.DownloadManager.Request(contentUri);


            r.SetDestinationInExternalPublicDir(Android.OS.Environment.DirectoryDownloads, filename);

            r.AllowScanningByMediaScanner();
            r.SetShowRunningNotification(true);
            r.SetNotificationVisibility(Android.App.DownloadVisibility.VisibleNotifyCompleted);
            r.SetVisibleInDownloadsUi(true);

            Android.App.DownloadManager dm = (Android.App.DownloadManager)Xamarin.Forms.Forms.Context.GetSystemService(Android.Content.Context.DownloadService);
           // dm.NotifyAll();
            dm.Enqueue(r);
        }
    }
}