using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services;

namespace WcfCommerce
{
    [ServiceContract]
    interface ICustomer
    {
        [OperationContract]
        Customer GetOrderOfCustomer(int id);

        
    }
}