﻿#pragma checksum "..\..\CustInsert.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C788C8FD0A208D96B4155A485123F8EB46A393F16CE81DC4733C1BDA33DB114D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using VikingTravelsExam;


namespace VikingTravelsExam {
    
    
    /// <summary>
    /// CustInsert
    /// </summary>
    public partial class CustInsert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\CustInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertFirstName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\CustInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertLastName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\CustInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertAddress;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\CustInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertTelNum;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\CustInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCust;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\CustInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chancel;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\CustInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorMessage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VikingTravelsExam;component/custinsert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustInsert.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.insertFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.insertLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.insertAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.insertTelNum = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\CustInsert.xaml"
            this.insertTelNum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumbersOnly);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addCust = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\CustInsert.xaml"
            this.addCust.Click += new System.Windows.RoutedEventHandler(this.AddCust_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Chancel = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\CustInsert.xaml"
            this.Chancel.Click += new System.Windows.RoutedEventHandler(this.Chancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.errorMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

