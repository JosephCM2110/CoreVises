﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISaleService" in both code and config file together.
    [ServiceContract]
    public interface ISaleService
    {
        [OperationContract]
        string registerSale(string idClient, string phones, string total,string key);
    }
}
