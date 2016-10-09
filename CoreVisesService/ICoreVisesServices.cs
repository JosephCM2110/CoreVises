using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;
using System.ServiceModel.Web;
using System.Data;

namespace CoreVisesService
{
    [ServiceContract]
    public interface ICoreVisesServices
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "/getAdministrators")]
        DataSet getAdministrators();
    }
}
