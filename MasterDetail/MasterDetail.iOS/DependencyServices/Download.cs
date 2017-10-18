using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using MasterDetail.iOS.DependencyServices;
using MasterDetail.Interfaces;
using System.Net;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Download))]
namespace MasterDetail.iOS.DependencyServices
{
    public class Download : IDownloadFile
    {
        void IDownloadFile.Download(string uri, string filename)
        {
            var webClient = new WebClient();

            webClient.DownloadDataCompleted += (s, e) =>
            {
                var bytes = e.Result; // get the downloaded data
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string localFilename = filename;
                string localPath = Path.Combine(documentsPath, localFilename);
                File.WriteAllBytes(localPath, bytes); // writes to local storage   
            };

            var url = new Uri(uri);

            webClient.DownloadDataAsync(url);

            new UIAlertView("Done", "Download Done.", null, "OK", null).Show();
        }
    }
}