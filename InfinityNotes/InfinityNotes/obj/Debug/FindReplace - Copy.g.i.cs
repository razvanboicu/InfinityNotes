﻿#pragma checksum "..\..\FindReplace - Copy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F3CDFAC7B755A8A907B5177F7E0AFFB5E0C1D94F26AC601D950D55B7F7A37F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InfinityNotes;
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


namespace InfinityNotes {
    
    
    /// <summary>
    /// FindReplace
    /// </summary>
    public partial class FindReplace : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stack1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFind;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button previousFindButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextFindButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button findButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox searchEverywhereCheckBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxOld;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNew;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button replaceButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\FindReplace - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox replaceAllCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/InfinityNotes;component/findreplace%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FindReplace - Copy.xaml"
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
            this.stack1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.textBoxFind = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.previousFindButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.nextFindButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.findButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\FindReplace - Copy.xaml"
            this.findButton.Click += new System.Windows.RoutedEventHandler(this.PressedFindButton);
            
            #line default
            #line hidden
            return;
            case 6:
            this.searchEverywhereCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.textBoxOld = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.textBoxNew = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.replaceButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\FindReplace - Copy.xaml"
            this.replaceButton.Click += new System.Windows.RoutedEventHandler(this.PressedReplaceButton);
            
            #line default
            #line hidden
            return;
            case 10:
            this.replaceAllCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

