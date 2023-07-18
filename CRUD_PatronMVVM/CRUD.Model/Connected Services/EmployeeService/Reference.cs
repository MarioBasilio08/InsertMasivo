﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.Model.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/TareaWCF")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertEmployee", ReplyAction="http://tempuri.org/IService1/InsertEmployeeResponse")]
        bool InsertEmployee(CRUD.Model.EmployeeService.Employee obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertEmployee", ReplyAction="http://tempuri.org/IService1/InsertEmployeeResponse")]
        System.Threading.Tasks.Task<bool> InsertEmployeeAsync(CRUD.Model.EmployeeService.Employee obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployee", ReplyAction="http://tempuri.org/IService1/GetAllEmployeeResponse")]
        CRUD.Model.EmployeeService.Employee[] GetAllEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployee", ReplyAction="http://tempuri.org/IService1/GetAllEmployeeResponse")]
        System.Threading.Tasks.Task<CRUD.Model.EmployeeService.Employee[]> GetAllEmployeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployee", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeResponse")]
        bool DeleteEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployee", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployee", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeResponse")]
        bool UpdateEmployee(CRUD.Model.EmployeeService.Employee obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployee", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(CRUD.Model.EmployeeService.Employee obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertEmployeeMasive", ReplyAction="http://tempuri.org/IService1/InsertEmployeeMasiveResponse")]
        bool InsertEmployeeMasive(CRUD.Model.EmployeeService.Employee[] obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertEmployeeMasive", ReplyAction="http://tempuri.org/IService1/InsertEmployeeMasiveResponse")]
        System.Threading.Tasks.Task<bool> InsertEmployeeMasiveAsync(CRUD.Model.EmployeeService.Employee[] obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CRUD.Model.EmployeeService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CRUD.Model.EmployeeService.IService1>, CRUD.Model.EmployeeService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool InsertEmployee(CRUD.Model.EmployeeService.Employee obj) {
            return base.Channel.InsertEmployee(obj);
        }
        
        public System.Threading.Tasks.Task<bool> InsertEmployeeAsync(CRUD.Model.EmployeeService.Employee obj) {
            return base.Channel.InsertEmployeeAsync(obj);
        }
        
        public CRUD.Model.EmployeeService.Employee[] GetAllEmployee() {
            return base.Channel.GetAllEmployee();
        }
        
        public System.Threading.Tasks.Task<CRUD.Model.EmployeeService.Employee[]> GetAllEmployeeAsync() {
            return base.Channel.GetAllEmployeeAsync();
        }
        
        public bool DeleteEmployee(int id) {
            return base.Channel.DeleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int id) {
            return base.Channel.DeleteEmployeeAsync(id);
        }
        
        public bool UpdateEmployee(CRUD.Model.EmployeeService.Employee obj) {
            return base.Channel.UpdateEmployee(obj);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(CRUD.Model.EmployeeService.Employee obj) {
            return base.Channel.UpdateEmployeeAsync(obj);
        }
        
        public bool InsertEmployeeMasive(CRUD.Model.EmployeeService.Employee[] obj) {
            return base.Channel.InsertEmployeeMasive(obj);
        }
        
        public System.Threading.Tasks.Task<bool> InsertEmployeeMasiveAsync(CRUD.Model.EmployeeService.Employee[] obj) {
            return base.Channel.InsertEmployeeMasiveAsync(obj);
        }
    }
}
