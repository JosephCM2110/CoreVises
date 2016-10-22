using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhonesLikeService" in both code and config file together.
    [ServiceContract]
    public interface IPhonesLikeService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Json, UriTemplate = "getPhonesLike/{word}/{key}")]
        string getPhonesLike(string word, string key);
    }
}
