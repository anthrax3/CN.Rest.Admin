﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.3615
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.3615.
// 
#pragma warning disable 1591

namespace POS.Admin.Data.WSPOS {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="posserviceSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObjParameters[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Parameters[]))]
    public partial class posservice : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback setTransactionsArrayOperationCompleted;
        
        private System.Threading.SendOrPostCallback setTransactionsQueryOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public posservice() {
            this.Url = global::POS.Admin.Data.Properties.Settings.Default.POS_Admin_Data_WSPOS_posservice;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event setTransactionsArrayCompletedEventHandler setTransactionsArrayCompleted;
        
        /// <remarks/>
        public event setTransactionsQueryCompletedEventHandler setTransactionsQueryCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/setTransactionsArray", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable setTransactionsArray(TransactionDb transactionDb, ArrayParameters arrayParameters) {
            object[] results = this.Invoke("setTransactionsArray", new object[] {
                        transactionDb,
                        arrayParameters});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void setTransactionsArrayAsync(TransactionDb transactionDb, ArrayParameters arrayParameters) {
            this.setTransactionsArrayAsync(transactionDb, arrayParameters, null);
        }
        
        /// <remarks/>
        public void setTransactionsArrayAsync(TransactionDb transactionDb, ArrayParameters arrayParameters, object userState) {
            if ((this.setTransactionsArrayOperationCompleted == null)) {
                this.setTransactionsArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetTransactionsArrayOperationCompleted);
            }
            this.InvokeAsync("setTransactionsArray", new object[] {
                        transactionDb,
                        arrayParameters}, this.setTransactionsArrayOperationCompleted, userState);
        }
        
        private void OnsetTransactionsArrayOperationCompleted(object arg) {
            if ((this.setTransactionsArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setTransactionsArrayCompleted(this, new setTransactionsArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/setTransactionsQuery", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable setTransactionsQuery(TransactionDb transactionDb, string[] Parameters) {
            object[] results = this.Invoke("setTransactionsQuery", new object[] {
                        transactionDb,
                        Parameters});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void setTransactionsQueryAsync(TransactionDb transactionDb, string[] Parameters) {
            this.setTransactionsQueryAsync(transactionDb, Parameters, null);
        }
        
        /// <remarks/>
        public void setTransactionsQueryAsync(TransactionDb transactionDb, string[] Parameters, object userState) {
            if ((this.setTransactionsQueryOperationCompleted == null)) {
                this.setTransactionsQueryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetTransactionsQueryOperationCompleted);
            }
            this.InvokeAsync("setTransactionsQuery", new object[] {
                        transactionDb,
                        Parameters}, this.setTransactionsQueryOperationCompleted, userState);
        }
        
        private void OnsetTransactionsQueryOperationCompleted(object arg) {
            if ((this.setTransactionsQueryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setTransactionsQueryCompleted(this, new setTransactionsQueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum TransactionDb {
        
        /// <comentarios/>
        SELECT,
        
        /// <comentarios/>
        UPDATE,
        
        /// <comentarios/>
        INSERT,
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ArrayParameters {
        
        private ObjParameters[] objParametersField;
        
        /// <comentarios/>
        public ObjParameters[] objParameters {
            get {
                return this.objParametersField;
            }
            set {
                this.objParametersField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ObjParameters {
        
        private Parameters[] listParametersField;
        
        private string strProcField;
        
        /// <comentarios/>
        public Parameters[] ListParameters {
            get {
                return this.listParametersField;
            }
            set {
                this.listParametersField = value;
            }
        }
        
        /// <comentarios/>
        public string strProc {
            get {
                return this.strProcField;
            }
            set {
                this.strProcField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Parameters {
        
        private string nameField;
        
        private string typeField;
        
        private string sizeField;
        
        private object valueField;
        
        /// <comentarios/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <comentarios/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <comentarios/>
        public string size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <comentarios/>
        public object value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void setTransactionsArrayCompletedEventHandler(object sender, setTransactionsArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setTransactionsArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setTransactionsArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void setTransactionsQueryCompletedEventHandler(object sender, setTransactionsQueryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setTransactionsQueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setTransactionsQueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591