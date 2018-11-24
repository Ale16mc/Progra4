﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrograIV.AW.Products.SI.WcfProducto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ProgaIV.AW.Products.BL")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SI.WcfProducto.IAWProductos")]
    public interface IAWProductos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/GetData", ReplyAction="http://tempuri.org/IAWProductos/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/GetData", ReplyAction="http://tempuri.org/IAWProductos/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IAWProductos/GetDataUsingDataContractResponse")]
        PrograIV.AW.Products.SI.WcfProducto.CompositeType GetDataUsingDataContract(PrograIV.AW.Products.SI.WcfProducto.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IAWProductos/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<PrograIV.AW.Products.SI.WcfProducto.CompositeType> GetDataUsingDataContractAsync(PrograIV.AW.Products.SI.WcfProducto.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/ListarProductosPorRangoDePrecio", ReplyAction="http://tempuri.org/IAWProductos/ListarProductosPorRangoDePrecioResponse")]
        PrograIV.AW.Products.Model.Product[] ListarProductosPorRangoDePrecio(decimal precioInferior, decimal PrecioSuperior);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/ListarProductosPorRangoDePrecio", ReplyAction="http://tempuri.org/IAWProductos/ListarProductosPorRangoDePrecioResponse")]
        System.Threading.Tasks.Task<PrograIV.AW.Products.Model.Product[]> ListarProductosPorRangoDePrecioAsync(decimal precioInferior, decimal PrecioSuperior);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/ListarProductosPorColor", ReplyAction="http://tempuri.org/IAWProductos/ListarProductosPorColorResponse")]
        void ListarProductosPorColor(string elColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/ListarProductosPorColor", ReplyAction="http://tempuri.org/IAWProductos/ListarProductosPorColorResponse")]
        System.Threading.Tasks.Task ListarProductosPorColorAsync(string elColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/ListarProductosPorNombreDeCategoria", ReplyAction="http://tempuri.org/IAWProductos/ListarProductosPorNombreDeCategoriaResponse")]
        void ListarProductosPorNombreDeCategoria(string laCtegoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWProductos/ListarProductosPorNombreDeCategoria", ReplyAction="http://tempuri.org/IAWProductos/ListarProductosPorNombreDeCategoriaResponse")]
        System.Threading.Tasks.Task ListarProductosPorNombreDeCategoriaAsync(string laCtegoria);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAWProductosChannel : PrograIV.AW.Products.SI.WcfProducto.IAWProductos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AWProductosClient : System.ServiceModel.ClientBase<PrograIV.AW.Products.SI.WcfProducto.IAWProductos>, PrograIV.AW.Products.SI.WcfProducto.IAWProductos {
        
        public AWProductosClient() {
        }
        
        public AWProductosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AWProductosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AWProductosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AWProductosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public PrograIV.AW.Products.SI.WcfProducto.CompositeType GetDataUsingDataContract(PrograIV.AW.Products.SI.WcfProducto.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<PrograIV.AW.Products.SI.WcfProducto.CompositeType> GetDataUsingDataContractAsync(PrograIV.AW.Products.SI.WcfProducto.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public PrograIV.AW.Products.Model.Product[] ListarProductosPorRangoDePrecio(decimal precioInferior, decimal PrecioSuperior) {
            return base.Channel.ListarProductosPorRangoDePrecio(precioInferior, PrecioSuperior);
        }
        
        public System.Threading.Tasks.Task<PrograIV.AW.Products.Model.Product[]> ListarProductosPorRangoDePrecioAsync(decimal precioInferior, decimal PrecioSuperior) {
            return base.Channel.ListarProductosPorRangoDePrecioAsync(precioInferior, PrecioSuperior);
        }
        
        public void ListarProductosPorColor(string elColor) {
            base.Channel.ListarProductosPorColor(elColor);
        }
        
        public System.Threading.Tasks.Task ListarProductosPorColorAsync(string elColor) {
            return base.Channel.ListarProductosPorColorAsync(elColor);
        }
        
        public void ListarProductosPorNombreDeCategoria(string laCtegoria) {
            base.Channel.ListarProductosPorNombreDeCategoria(laCtegoria);
        }
        
        public System.Threading.Tasks.Task ListarProductosPorNombreDeCategoriaAsync(string laCtegoria) {
            return base.Channel.ListarProductosPorNombreDeCategoriaAsync(laCtegoria);
        }
    }
}