﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPNAVConnect.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://nav.gowingu.net:7047/DynamicsNAV90/WS/Rackpeople%20Consulting%20ApS/Page/C" +
            "ustomerInfo2?tenant=rackpeople")]
        public string RPNAVConnect_NAVCustomersWS_CustomerInfo2_Service {
            get {
                return ((string)(this["RPNAVConnect_NAVCustomersWS_CustomerInfo2_Service"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://nav.gowingu.net:7047/DynamicsNAV90/WS/Rackpeople%20Consulting%20ApS/Page/S" +
            "alesInvoice_Service?tenant=rackpeople")]
        public string RPNAVConnect_NAVOrdersWS_SalesOrder_Service_Service {
            get {
                return ((string)(this["RPNAVConnect_NAVOrdersWS_SalesOrder_Service_Service"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://nav.gowingu.net:8091/RPNAVConnectWS.asmx")]
        public string RPNAVConnect_TimeLogDataWS_RPNAVConnectWS {
            get {
                return ((string)(this["RPNAVConnect_TimeLogDataWS_RPNAVConnectWS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://nav.gowingu.net:7047/DynamicsNAV90/WS/Rackpeople%20Consulting%20ApS/Page/S" +
            "alesCRMemo_Service?tenant=rackpeople")]
        public string RPNAVConnect_NAVSalesCRMemoWS_SalesCRMemo_Service_Service {
            get {
                return ((string)(this["RPNAVConnect_NAVSalesCRMemoWS_SalesCRMemo_Service_Service"]));
            }
        }
    }
}
