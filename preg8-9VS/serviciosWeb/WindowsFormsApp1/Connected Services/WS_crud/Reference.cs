﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.WS_crud {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS_crud.WS_crudSoap")]
    public interface WS_crudSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarDatos(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarDatos", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarDatosAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertarDatos(string nombre, string apellido, string edad, string coddep, string email, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarDatos", ReplyAction="*")]
        System.Threading.Tasks.Task insertarDatosAsync(string nombre, string apellido, string edad, string coddep, string email, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarDatos(string id, string nombre, string apellido, string edad, string coddep, string email, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarDatos", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarDatosAsync(string id, string nombre, string apellido, string edad, string coddep, string email, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tablaDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable tablaDatos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/tablaDatos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> tablaDatosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_crudSoapChannel : WindowsFormsApp1.WS_crud.WS_crudSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_crudSoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.WS_crud.WS_crudSoap>, WindowsFormsApp1.WS_crud.WS_crudSoap {
        
        public WS_crudSoapClient() {
        }
        
        public WS_crudSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_crudSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_crudSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_crudSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void eliminarDatos(string id) {
            base.Channel.eliminarDatos(id);
        }
        
        public System.Threading.Tasks.Task eliminarDatosAsync(string id) {
            return base.Channel.eliminarDatosAsync(id);
        }
        
        public void insertarDatos(string nombre, string apellido, string edad, string coddep, string email, string telefono) {
            base.Channel.insertarDatos(nombre, apellido, edad, coddep, email, telefono);
        }
        
        public System.Threading.Tasks.Task insertarDatosAsync(string nombre, string apellido, string edad, string coddep, string email, string telefono) {
            return base.Channel.insertarDatosAsync(nombre, apellido, edad, coddep, email, telefono);
        }
        
        public void actualizarDatos(string id, string nombre, string apellido, string edad, string coddep, string email, string telefono) {
            base.Channel.actualizarDatos(id, nombre, apellido, edad, coddep, email, telefono);
        }
        
        public System.Threading.Tasks.Task actualizarDatosAsync(string id, string nombre, string apellido, string edad, string coddep, string email, string telefono) {
            return base.Channel.actualizarDatosAsync(id, nombre, apellido, edad, coddep, email, telefono);
        }
        
        public System.Data.DataTable tablaDatos() {
            return base.Channel.tablaDatos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> tablaDatosAsync() {
            return base.Channel.tablaDatosAsync();
        }
    }
}
