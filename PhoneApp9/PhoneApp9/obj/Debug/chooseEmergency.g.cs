﻿#pragma checksum "C:\Users\woa\documents\visual studio 2012\Projects\PhoneApp9\PhoneApp9\chooseEmergency.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "492E0167FECA8C0DE865153FF4D7A7F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp9 {
    
    
    public partial class chooseEmergency : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock App_Name;
        
        internal System.Windows.Controls.TextBlock Page_Name;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button Accident;
        
        internal System.Windows.Controls.Button Physical_assault;
        
        internal System.Windows.Controls.Button Medical;
        
        internal System.Windows.Controls.Button Other_emergency_Copy;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp9;component/chooseEmergency.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.App_Name = ((System.Windows.Controls.TextBlock)(this.FindName("App_Name")));
            this.Page_Name = ((System.Windows.Controls.TextBlock)(this.FindName("Page_Name")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Accident = ((System.Windows.Controls.Button)(this.FindName("Accident")));
            this.Physical_assault = ((System.Windows.Controls.Button)(this.FindName("Physical_assault")));
            this.Medical = ((System.Windows.Controls.Button)(this.FindName("Medical")));
            this.Other_emergency_Copy = ((System.Windows.Controls.Button)(this.FindName("Other_emergency_Copy")));
        }
    }
}
