﻿

#pragma checksum "C:\Users\Tom\Desktop\PRApplicationShalev\PRApplication.Hosting.AzureServiceReference\Views\HostView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "01BA2EEED763416185E079EDBD6F8B1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRApplication.Hosting.AzureServiceReference.Views
{
    partial class HostView : global::Cirrious.MvvmCross.WindowsCommon.Views.MvxWindowsPage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 21 "..\..\Views\HostView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ReadQrCode_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


