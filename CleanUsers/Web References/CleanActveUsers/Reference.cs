﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CleanUsers.CleanActveUsers {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CheckLoginStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCompanyOperationCompleted;
        
        private System.Threading.SendOrPostCallback CleanActiveUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback RecordLoginStatsOperationCompleted;
        
        private System.Threading.SendOrPostCallback RecordLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback RecordPrimaryCompanyOperationCompleted;
        
        private System.Threading.SendOrPostCallback RecordSubCompanyOperationCompleted;
        
        private System.Threading.SendOrPostCallback VIReMailOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::CleanUsers.Properties.Settings.Default.CleanUsers_CleanActveUsers_Service;
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
        public event CheckLoginStatusCompletedEventHandler CheckLoginStatusCompleted;
        
        /// <remarks/>
        public event GetCompanyCompletedEventHandler GetCompanyCompleted;
        
        /// <remarks/>
        public event CleanActiveUserCompletedEventHandler CleanActiveUserCompleted;
        
        /// <remarks/>
        public event RecordLoginStatsCompletedEventHandler RecordLoginStatsCompleted;
        
        /// <remarks/>
        public event RecordLoginCompletedEventHandler RecordLoginCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        public event RecordPrimaryCompanyCompletedEventHandler RecordPrimaryCompanyCompleted;
        
        /// <remarks/>
        public event RecordSubCompanyCompletedEventHandler RecordSubCompanyCompleted;
        
        /// <remarks/>
        public event VIReMailCompletedEventHandler VIReMailCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckLoginStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckLoginStatus(string User, string Company, string password) {
            object[] results = this.Invoke("CheckLoginStatus", new object[] {
                        User,
                        Company,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckLoginStatusAsync(string User, string Company, string password) {
            this.CheckLoginStatusAsync(User, Company, password, null);
        }
        
        /// <remarks/>
        public void CheckLoginStatusAsync(string User, string Company, string password, object userState) {
            if ((this.CheckLoginStatusOperationCompleted == null)) {
                this.CheckLoginStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckLoginStatusOperationCompleted);
            }
            this.InvokeAsync("CheckLoginStatus", new object[] {
                        User,
                        Company,
                        password}, this.CheckLoginStatusOperationCompleted, userState);
        }
        
        private void OnCheckLoginStatusOperationCompleted(object arg) {
            if ((this.CheckLoginStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckLoginStatusCompleted(this, new CheckLoginStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCompany", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCompany(string username) {
            object[] results = this.Invoke("GetCompany", new object[] {
                        username});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetCompanyAsync(string username) {
            this.GetCompanyAsync(username, null);
        }
        
        /// <remarks/>
        public void GetCompanyAsync(string username, object userState) {
            if ((this.GetCompanyOperationCompleted == null)) {
                this.GetCompanyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCompanyOperationCompleted);
            }
            this.InvokeAsync("GetCompany", new object[] {
                        username}, this.GetCompanyOperationCompleted, userState);
        }
        
        private void OnGetCompanyOperationCompleted(object arg) {
            if ((this.GetCompanyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCompanyCompleted(this, new GetCompanyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CleanActiveUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CleanActiveUser() {
            this.Invoke("CleanActiveUser", new object[0]);
        }
        
        /// <remarks/>
        public void CleanActiveUserAsync() {
            this.CleanActiveUserAsync(null);
        }
        
        /// <remarks/>
        public void CleanActiveUserAsync(object userState) {
            if ((this.CleanActiveUserOperationCompleted == null)) {
                this.CleanActiveUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCleanActiveUserOperationCompleted);
            }
            this.InvokeAsync("CleanActiveUser", new object[0], this.CleanActiveUserOperationCompleted, userState);
        }
        
        private void OnCleanActiveUserOperationCompleted(object arg) {
            if ((this.CleanActiveUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CleanActiveUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecordLoginStats", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RecordLoginStats() {
            this.Invoke("RecordLoginStats", new object[0]);
        }
        
        /// <remarks/>
        public void RecordLoginStatsAsync() {
            this.RecordLoginStatsAsync(null);
        }
        
        /// <remarks/>
        public void RecordLoginStatsAsync(object userState) {
            if ((this.RecordLoginStatsOperationCompleted == null)) {
                this.RecordLoginStatsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecordLoginStatsOperationCompleted);
            }
            this.InvokeAsync("RecordLoginStats", new object[0], this.RecordLoginStatsOperationCompleted, userState);
        }
        
        private void OnRecordLoginStatsOperationCompleted(object arg) {
            if ((this.RecordLoginStatsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecordLoginStatsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecordLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RecordLogin(string SubCompany) {
            this.Invoke("RecordLogin", new object[] {
                        SubCompany});
        }
        
        /// <remarks/>
        public void RecordLoginAsync(string SubCompany) {
            this.RecordLoginAsync(SubCompany, null);
        }
        
        /// <remarks/>
        public void RecordLoginAsync(string SubCompany, object userState) {
            if ((this.RecordLoginOperationCompleted == null)) {
                this.RecordLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecordLoginOperationCompleted);
            }
            this.InvokeAsync("RecordLogin", new object[] {
                        SubCompany}, this.RecordLoginOperationCompleted, userState);
        }
        
        private void OnRecordLoginOperationCompleted(object arg) {
            if ((this.RecordLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecordLoginCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Login(string username, string password) {
            object[] results = this.Invoke("Login", new object[] {
                        username,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string password) {
            this.LoginAsync(username, password, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string password, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        username,
                        password}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecordPrimaryCompany", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RecordPrimaryCompany(string Company, int License, string UserStructure, string idle) {
            object[] results = this.Invoke("RecordPrimaryCompany", new object[] {
                        Company,
                        License,
                        UserStructure,
                        idle});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RecordPrimaryCompanyAsync(string Company, int License, string UserStructure, string idle) {
            this.RecordPrimaryCompanyAsync(Company, License, UserStructure, idle, null);
        }
        
        /// <remarks/>
        public void RecordPrimaryCompanyAsync(string Company, int License, string UserStructure, string idle, object userState) {
            if ((this.RecordPrimaryCompanyOperationCompleted == null)) {
                this.RecordPrimaryCompanyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecordPrimaryCompanyOperationCompleted);
            }
            this.InvokeAsync("RecordPrimaryCompany", new object[] {
                        Company,
                        License,
                        UserStructure,
                        idle}, this.RecordPrimaryCompanyOperationCompleted, userState);
        }
        
        private void OnRecordPrimaryCompanyOperationCompleted(object arg) {
            if ((this.RecordPrimaryCompanyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecordPrimaryCompanyCompleted(this, new RecordPrimaryCompanyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecordSubCompany", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RecordSubCompany(string Company, string PCompany) {
            object[] results = this.Invoke("RecordSubCompany", new object[] {
                        Company,
                        PCompany});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RecordSubCompanyAsync(string Company, string PCompany) {
            this.RecordSubCompanyAsync(Company, PCompany, null);
        }
        
        /// <remarks/>
        public void RecordSubCompanyAsync(string Company, string PCompany, object userState) {
            if ((this.RecordSubCompanyOperationCompleted == null)) {
                this.RecordSubCompanyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecordSubCompanyOperationCompleted);
            }
            this.InvokeAsync("RecordSubCompany", new object[] {
                        Company,
                        PCompany}, this.RecordSubCompanyOperationCompleted, userState);
        }
        
        private void OnRecordSubCompanyOperationCompleted(object arg) {
            if ((this.RecordSubCompanyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecordSubCompanyCompleted(this, new RecordSubCompanyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/VIReMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string VIReMail(string EmailTo, string NameTo, string SubjectText, string user) {
            object[] results = this.Invoke("VIReMail", new object[] {
                        EmailTo,
                        NameTo,
                        SubjectText,
                        user});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void VIReMailAsync(string EmailTo, string NameTo, string SubjectText, string user) {
            this.VIReMailAsync(EmailTo, NameTo, SubjectText, user, null);
        }
        
        /// <remarks/>
        public void VIReMailAsync(string EmailTo, string NameTo, string SubjectText, string user, object userState) {
            if ((this.VIReMailOperationCompleted == null)) {
                this.VIReMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVIReMailOperationCompleted);
            }
            this.InvokeAsync("VIReMail", new object[] {
                        EmailTo,
                        NameTo,
                        SubjectText,
                        user}, this.VIReMailOperationCompleted, userState);
        }
        
        private void OnVIReMailOperationCompleted(object arg) {
            if ((this.VIReMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VIReMailCompleted(this, new VIReMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void CheckLoginStatusCompletedEventHandler(object sender, CheckLoginStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckLoginStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckLoginStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetCompanyCompletedEventHandler(object sender, GetCompanyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCompanyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCompanyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void CleanActiveUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void RecordLoginStatsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void RecordLoginCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void RecordPrimaryCompanyCompletedEventHandler(object sender, RecordPrimaryCompanyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RecordPrimaryCompanyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RecordPrimaryCompanyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void RecordSubCompanyCompletedEventHandler(object sender, RecordSubCompanyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RecordSubCompanyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RecordSubCompanyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void VIReMailCompletedEventHandler(object sender, VIReMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VIReMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VIReMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591