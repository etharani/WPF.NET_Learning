﻿#pragma checksum "..\..\Calculator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8EE170929527FEA59AB881A1769A93E1FB3B080C57310EDB32CD901EE5896CB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using First_WpfApp;
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


namespace First_WpfApp {
    
    
    /// <summary>
    /// Calculator
    /// </summary>
    public partial class Calculator : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value1;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value2;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox output;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sumbtn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button subbtn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button multibtn;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button divbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/First_WpfApp;component/calculator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Calculator.xaml"
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
            this.value1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.value2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.output = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.sumbtn = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\Calculator.xaml"
            this.sumbtn.Click += new System.Windows.RoutedEventHandler(this.sumbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.subbtn = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\Calculator.xaml"
            this.subbtn.Click += new System.Windows.RoutedEventHandler(this.subbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.multibtn = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\Calculator.xaml"
            this.multibtn.Click += new System.Windows.RoutedEventHandler(this.multibtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.divbtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Calculator.xaml"
            this.divbtn.Click += new System.Windows.RoutedEventHandler(this.divbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
