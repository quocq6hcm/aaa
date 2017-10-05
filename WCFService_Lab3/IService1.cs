using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService_Lab3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //   [WebInvoke(RequestFormat =)]
        [OperationContract]
        List<Models.Store> GetStoreList();

        [OperationContract]
        Models.Store GetStore();

        [OperationContract]
        void PostStore(Models.Store s);

        [OperationContract]
        bool DeleteStore(int id);


    }
}
