﻿#pragma checksum "..\..\..\..\..\Resources\Code\Windows\Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B4D9C86E2A3A00EF867EE8600DA3ACE46794702702AA5E434A5994D777EFC36"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Sticky_Notes;
using Sticky_Notes.Properties;
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


namespace Sticky_Notes {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PathButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FontSizeInput;
        
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
            System.Uri resourceLocater = new System.Uri("/Sticky Notes;component/resources/code/windows/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
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
            
            #line 29 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).AddHandler(System.Windows.Input.Mouse.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown));
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PathButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            this.PathButton.Click += new System.Windows.RoutedEventHandler(this.PathButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FontSizeInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            this.FontSizeInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FontSizeInput_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 85 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FontButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 88 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FontButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 91 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FontButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 94 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FontButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FontButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 116 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColorButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 120 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColorButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 124 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColorButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 128 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColorButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 132 "..\..\..\..\..\Resources\Code\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColorButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

