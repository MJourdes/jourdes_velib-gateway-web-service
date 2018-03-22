﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientGUI.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contract", Namespace="http://schemas.datacontract.org/2004/07/IWS_VelibWS")]
    [System.SerializableAttribute()]
    public partial class Contract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string country_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string country_code {
            get {
                return this.country_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.country_codeField, value) != true)) {
                    this.country_codeField = value;
                    this.RaisePropertyChanged("country_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/IWS_VelibWS")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int available_bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int available_bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int available_bike_stands {
            get {
                return this.available_bike_standsField;
            }
            set {
                if ((this.available_bike_standsField.Equals(value) != true)) {
                    this.available_bike_standsField = value;
                    this.RaisePropertyChanged("available_bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int available_bikes {
            get {
                return this.available_bikesField;
            }
            set {
                if ((this.available_bikesField.Equals(value) != true)) {
                    this.available_bikesField = value;
                    this.RaisePropertyChanged("available_bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetInfoAbout", ReplyAction="http://tempuri.org/IService/GetInfoAboutResponse")]
        string GetInfoAbout(string station, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetInfoAbout", ReplyAction="http://tempuri.org/IService/GetInfoAboutResponse")]
        System.Threading.Tasks.Task<string> GetInfoAboutAsync(string station, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        ClientGUI.ServiceReference.Contract[] GetCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        System.Threading.Tasks.Task<ClientGUI.ServiceReference.Contract[]> GetCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStations", ReplyAction="http://tempuri.org/IService/GetStationsResponse")]
        ClientGUI.ServiceReference.Station[] GetStations(string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStations", ReplyAction="http://tempuri.org/IService/GetStationsResponse")]
        System.Threading.Tasks.Task<ClientGUI.ServiceReference.Station[]> GetStationsAsync(string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RefreshStations", ReplyAction="http://tempuri.org/IService/RefreshStationsResponse")]
        void RefreshStations(string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RefreshStations", ReplyAction="http://tempuri.org/IService/RefreshStationsResponse")]
        System.Threading.Tasks.Task RefreshStationsAsync(string cityName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ClientGUI.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClientGUI.ServiceReference.IService>, ClientGUI.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetInfoAbout(string station, string cityName) {
            return base.Channel.GetInfoAbout(station, cityName);
        }
        
        public System.Threading.Tasks.Task<string> GetInfoAboutAsync(string station, string cityName) {
            return base.Channel.GetInfoAboutAsync(station, cityName);
        }
        
        public ClientGUI.ServiceReference.Contract[] GetCities() {
            return base.Channel.GetCities();
        }
        
        public System.Threading.Tasks.Task<ClientGUI.ServiceReference.Contract[]> GetCitiesAsync() {
            return base.Channel.GetCitiesAsync();
        }
        
        public ClientGUI.ServiceReference.Station[] GetStations(string cityName) {
            return base.Channel.GetStations(cityName);
        }
        
        public System.Threading.Tasks.Task<ClientGUI.ServiceReference.Station[]> GetStationsAsync(string cityName) {
            return base.Channel.GetStationsAsync(cityName);
        }
        
        public void RefreshStations(string cityName) {
            base.Channel.RefreshStations(cityName);
        }
        
        public System.Threading.Tasks.Task RefreshStationsAsync(string cityName) {
            return base.Channel.RefreshStationsAsync(cityName);
        }
    }
}