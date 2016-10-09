using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;

namespace CoreVisesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICoreVisesServices" in both code and config file together.
    [ServiceContract]
    public interface ICoreVisesServices
    {
        [OperationContract]
        int insertAdministrator(Administrator administrator);
    }
}
