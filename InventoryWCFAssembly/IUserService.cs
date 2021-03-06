﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using InventoryDataAssembly;

namespace InventoryWCFAssembly
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        bool logIn(String fname, String lname);

        [OperationContract]
        bool addPart(String id, String descr, double price, int count);

        [OperationContract]
        bool addUser(String firstName, String lastName);

        [OperationContract]
        bool deleteUser(int id);

        [OperationContract]
        bool deleteInventory(String id);

        [OperationContract]
        bool reservePart(String id, int count);

        [OperationContract]
        List<User> searchUserByFirstName(String name);

        [OperationContract]
        bool addCart(String usrID, String invID, String count);

        [OperationContract]
        bool deleteCart(int id);

        [OperationContract]
        List<CART_TABLE> searchCartByUsrID(String usrID);

        [OperationContract]
        List<CART_TABLE> searchCartByInvID(String invID);

        [OperationContract]
        bool deleteCartByUserID(String id);

        [OperationContract]
        List<CART_TABLE> getAllCarts();

        [OperationContract]
        List<User> searchUserByLastName(String name);

        [OperationContract]
        List<Inventory> searchPartByDescription(String descr);

        [OperationContract]
        List<Inventory> getAllParts();

        [OperationContract]
        List<User> getAllUsers();

        [OperationContract]
        double calculateTotal();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        double calculateReserved();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        double calculateBalance();
    }
}
