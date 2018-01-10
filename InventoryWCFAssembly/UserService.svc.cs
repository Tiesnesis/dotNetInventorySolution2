using InventoryDataAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InventoryWCFAssembly
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class UserService : IUserService
    {
        internal static InventoryEntities inventoryDataContext = new InventoryEntities();

        [OperationBehavior(TransactionScopeRequired = true)]
        public bool logIn(String fname, String lname)
        {
            if (fname == null || lname == null || fname == "" || lname == "")
                return false;

            var usersData = from usr in inventoryDataContext.Users
                            where usr.LAST_NAME == lname
                            select usr;

            if (usersData.Count() == 0)
            {
                //create a new user object.
                User newUser = new User();
                newUser.FIRST_NAME = fname;
                newUser.LAST_NAME = lname;
                inventoryDataContext.Users.Add(newUser);
                inventoryDataContext.SaveChanges();
            }

            return true;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public bool addPart(String id, String descr, double price, int count)
        {
            if (id == null || id.Equals(""))
                return false;

            var inventoryData = from inv in inventoryDataContext.Inventories
                                where inv.ID == id
                                select inv;

            if (inventoryData.Count() == 0)
            { //create a new inventory item
                Inventory newInventory = new Inventory();
                newInventory.ID = id;
                newInventory.DESCRIPTION = descr;
                newInventory.PRICE = price;
                newInventory.INSTOCK = count;
                newInventory.RESERVED = 0;
                inventoryDataContext.Inventories.Add(newInventory);
            }
            else
            { //add count
                inventoryData.First().INSTOCK = inventoryData.First().INSTOCK + count;
            }
            inventoryDataContext.SaveChanges();
            return true;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public bool addUser(String firstName, String lastName)
        {
            User newUser = new User();
            newUser.FIRST_NAME = firstName;
            newUser.LAST_NAME = lastName;
            inventoryDataContext.Users.Add(newUser);
            inventoryDataContext.SaveChanges();
            return true;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public bool deleteUser(int id)
        {
            if (id == null || id.Equals(""))
                return false;

            var inventoryData = from usr in inventoryDataContext.Users
                                where usr.ID == id
                                select usr;

            if (inventoryData.Count() == 0)
                return false;

            inventoryDataContext.Users.Remove(inventoryData.First());
            inventoryDataContext.SaveChanges();
            return true;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public bool deleteInventory(String id)
        {
            if (id == null || id.Equals(""))
                return false;

            var inventoryData = from inv in inventoryDataContext.Inventories
                                where inv.ID == id
                                select inv;

            if (inventoryData.Count() == 0)
                return false;

            inventoryDataContext.Inventories.Remove(inventoryData.First());
            inventoryDataContext.SaveChanges();
            return true;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public bool reservePart(String id, int count)
        {
            if (id == null || id.Equals(""))
                return false;

            var inventoryData = from inv in inventoryDataContext.Inventories
                                where inv.ID == id
                                select inv;

            if (inventoryData.Count() == 0)
                return false;

            inventoryData.First().RESERVED = inventoryData.First().RESERVED + count;
            inventoryDataContext.SaveChanges();
            return true;
        }

        public List<Inventory> searchPartByDescription(String descr)
        {
            return (from inv in inventoryDataContext.Inventories
                    where inv.DESCRIPTION.Contains(descr)
                    select inv).ToList();
        }


        public List<Inventory> getAllParts()
        {
            return inventoryDataContext.Inventories.OrderBy(c => c.DESCRIPTION).ToList();
        }

        public List<User> getAllUsers()
        {
            return inventoryDataContext.Users.ToList();
        }

        public double calculateTotal()
        {
            IInventoryService tmpInvService = new InventoryService();
            return tmpInvService.calculateTotal();
        }

        public double calculateReserved()
        {
            IInventoryService tmpInvService = new InventoryService();
            return tmpInvService.calculateReserved();
        }

        public double calculateBalance()
        {
            IInventoryService tmpInvService = new InventoryService();
            return tmpInvService.calculateBalance();
        }
    }
}
