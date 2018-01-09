using InventoryDataAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InventoryWCFAssembly
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InventoryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InventoryService.svc or InventoryService.svc.cs at the Solution Explorer and start debugging.
    public class InventoryService : IInventoryService
    {
        //[OperationBehavior(TransactionScopeRequired = true)]
        public double calculateTotal()
        {
            //using (InventoryEntities inventoryDataContext = new InventoryEntities())
            InventoryEntities inventoryDataContext = new InventoryEntities();
            {
                return (double)(from inv in inventoryDataContext.Inventories
                                select inv.PRICE * inv.INSTOCK).Sum();
            }
        }

        public double calculateReserved()
        {
            //using (InventoryEntities inventoryDataContext = new InventoryEntities())
            InventoryEntities inventoryDataContext = new InventoryEntities();
            {
                return (double)(from inv in inventoryDataContext.Inventories
                                select inv.PRICE * inv.RESERVED).Sum();
            }
        }

        public double calculateBalance()
        {
            return calculateTotal() - calculateReserved();
        }        
    }
}
