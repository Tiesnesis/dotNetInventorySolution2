﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryWPFApplication.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Inventory", Namespace="http://schemas.datacontract.org/2004/07/InventoryDataAssembly")]
    [System.SerializableAttribute()]
    public partial class Inventory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DESCRIPTIONField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> INSTOCKField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> PRICEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> RESERVEDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DESCRIPTION {
            get {
                return this.DESCRIPTIONField;
            }
            set {
                if ((object.ReferenceEquals(this.DESCRIPTIONField, value) != true)) {
                    this.DESCRIPTIONField = value;
                    this.RaisePropertyChanged("DESCRIPTION");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> INSTOCK {
            get {
                return this.INSTOCKField;
            }
            set {
                if ((this.INSTOCKField.Equals(value) != true)) {
                    this.INSTOCKField = value;
                    this.RaisePropertyChanged("INSTOCK");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> PRICE {
            get {
                return this.PRICEField;
            }
            set {
                if ((this.PRICEField.Equals(value) != true)) {
                    this.PRICEField = value;
                    this.RaisePropertyChanged("PRICE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> RESERVED {
            get {
                return this.RESERVEDField;
            }
            set {
                if ((this.RESERVEDField.Equals(value) != true)) {
                    this.RESERVEDField = value;
                    this.RaisePropertyChanged("RESERVED");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/InventoryDataAssembly")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FIRST_NAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LAST_NAMEField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FIRST_NAME {
            get {
                return this.FIRST_NAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.FIRST_NAMEField, value) != true)) {
                    this.FIRST_NAMEField = value;
                    this.RaisePropertyChanged("FIRST_NAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LAST_NAME {
            get {
                return this.LAST_NAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.LAST_NAMEField, value) != true)) {
                    this.LAST_NAMEField = value;
                    this.RaisePropertyChanged("LAST_NAME");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/logIn", ReplyAction="http://tempuri.org/IUserService/logInResponse")]
        bool logIn(string fname, string lname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/logIn", ReplyAction="http://tempuri.org/IUserService/logInResponse")]
        System.Threading.Tasks.Task<bool> logInAsync(string fname, string lname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/addPart", ReplyAction="http://tempuri.org/IUserService/addPartResponse")]
        bool addPart(string id, string descr, double price, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/addPart", ReplyAction="http://tempuri.org/IUserService/addPartResponse")]
        System.Threading.Tasks.Task<bool> addPartAsync(string id, string descr, double price, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/addUser", ReplyAction="http://tempuri.org/IUserService/addUserResponse")]
        bool addUser(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/addUser", ReplyAction="http://tempuri.org/IUserService/addUserResponse")]
        System.Threading.Tasks.Task<bool> addUserAsync(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/deleteUser", ReplyAction="http://tempuri.org/IUserService/deleteUserResponse")]
        bool deleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/deleteUser", ReplyAction="http://tempuri.org/IUserService/deleteUserResponse")]
        System.Threading.Tasks.Task<bool> deleteUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/reservePart", ReplyAction="http://tempuri.org/IUserService/reservePartResponse")]
        bool reservePart(string id, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/reservePart", ReplyAction="http://tempuri.org/IUserService/reservePartResponse")]
        System.Threading.Tasks.Task<bool> reservePartAsync(string id, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/searchPartByDescription", ReplyAction="http://tempuri.org/IUserService/searchPartByDescriptionResponse")]
        System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory> searchPartByDescription(string descr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/searchPartByDescription", ReplyAction="http://tempuri.org/IUserService/searchPartByDescriptionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory>> searchPartByDescriptionAsync(string descr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getAllParts", ReplyAction="http://tempuri.org/IUserService/getAllPartsResponse")]
        System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory> getAllParts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getAllParts", ReplyAction="http://tempuri.org/IUserService/getAllPartsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory>> getAllPartsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getAllUsers", ReplyAction="http://tempuri.org/IUserService/getAllUsersResponse")]
        System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.User> getAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getAllUsers", ReplyAction="http://tempuri.org/IUserService/getAllUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.User>> getAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/calculateTotal", ReplyAction="http://tempuri.org/IUserService/calculateTotalResponse")]
        double calculateTotal();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/calculateTotal", ReplyAction="http://tempuri.org/IUserService/calculateTotalResponse")]
        System.Threading.Tasks.Task<double> calculateTotalAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/calculateReserved", ReplyAction="http://tempuri.org/IUserService/calculateReservedResponse")]
        double calculateReserved();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/calculateReserved", ReplyAction="http://tempuri.org/IUserService/calculateReservedResponse")]
        System.Threading.Tasks.Task<double> calculateReservedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/calculateBalance", ReplyAction="http://tempuri.org/IUserService/calculateBalanceResponse")]
        double calculateBalance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/calculateBalance", ReplyAction="http://tempuri.org/IUserService/calculateBalanceResponse")]
        System.Threading.Tasks.Task<double> calculateBalanceAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : InventoryWPFApplication.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<InventoryWPFApplication.UserServiceReference.IUserService>, InventoryWPFApplication.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool logIn(string fname, string lname) {
            return base.Channel.logIn(fname, lname);
        }
        
        public System.Threading.Tasks.Task<bool> logInAsync(string fname, string lname) {
            return base.Channel.logInAsync(fname, lname);
        }
        
        public bool addPart(string id, string descr, double price, int count) {
            return base.Channel.addPart(id, descr, price, count);
        }
        
        public System.Threading.Tasks.Task<bool> addPartAsync(string id, string descr, double price, int count) {
            return base.Channel.addPartAsync(id, descr, price, count);
        }
        
        public bool addUser(string firstName, string lastName) {
            return base.Channel.addUser(firstName, lastName);
        }
        
        public System.Threading.Tasks.Task<bool> addUserAsync(string firstName, string lastName) {
            return base.Channel.addUserAsync(firstName, lastName);
        }
        
        public bool deleteUser(int id) {
            return base.Channel.deleteUser(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteUserAsync(int id) {
            return base.Channel.deleteUserAsync(id);
        }
        
        public bool reservePart(string id, int count) {
            return base.Channel.reservePart(id, count);
        }
        
        public System.Threading.Tasks.Task<bool> reservePartAsync(string id, int count) {
            return base.Channel.reservePartAsync(id, count);
        }
        
        public System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory> searchPartByDescription(string descr) {
            return base.Channel.searchPartByDescription(descr);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory>> searchPartByDescriptionAsync(string descr) {
            return base.Channel.searchPartByDescriptionAsync(descr);
        }
        
        public System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory> getAllParts() {
            return base.Channel.getAllParts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.Inventory>> getAllPartsAsync() {
            return base.Channel.getAllPartsAsync();
        }
        
        public System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.User> getAllUsers() {
            return base.Channel.getAllUsers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<InventoryWPFApplication.UserServiceReference.User>> getAllUsersAsync() {
            return base.Channel.getAllUsersAsync();
        }
        
        public double calculateTotal() {
            return base.Channel.calculateTotal();
        }
        
        public System.Threading.Tasks.Task<double> calculateTotalAsync() {
            return base.Channel.calculateTotalAsync();
        }
        
        public double calculateReserved() {
            return base.Channel.calculateReserved();
        }
        
        public System.Threading.Tasks.Task<double> calculateReservedAsync() {
            return base.Channel.calculateReservedAsync();
        }
        
        public double calculateBalance() {
            return base.Channel.calculateBalance();
        }
        
        public System.Threading.Tasks.Task<double> calculateBalanceAsync() {
            return base.Channel.calculateBalanceAsync();
        }
    }
}
