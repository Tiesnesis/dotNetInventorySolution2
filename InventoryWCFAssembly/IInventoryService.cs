using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using InventoryDataAssembly;

namespace InventoryWCFAssembly
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInventoryService" in both code and config file together.
    [ServiceContract]
    public interface IInventoryService
    {
        [OperationContract]
//      [TransactionFlow(TransactionFlowOption.Allowed)]
        double calculateTotal();

        [OperationContract]
        double calculateReserved();

        [OperationContract]
        double calculateBalance();
    }
}

// add additional data contracts if needed ....
//[DataContract()]
//public class AuxClass
//{
//}