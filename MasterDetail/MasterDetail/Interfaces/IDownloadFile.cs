using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Interfaces
{
   public interface IDownloadFile
    {
        void Download(string uri, string filename);
    }
}
