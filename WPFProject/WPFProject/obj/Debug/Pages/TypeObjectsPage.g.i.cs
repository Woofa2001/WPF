﻿#pragma checksum "..\..\..\Pages\TypeObjectsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8DFE9C92681DB603652CE0FE40EA61833A0F99BABE7A3B9E0BEA348E7B5B3B1"
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
using WPFProject.Pages;


namespace WPFProject.Pages {
    
    
    /// <summary>
    /// TypeObjectsPage
    /// </summary>
    public partial class TypeObjectsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition SplitterColumn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition ChangeColumn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAreas;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopyAreas;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditAreas;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAreas;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TypeObjectDataGrid;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TypeObjectLabel1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\TypeObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTypeTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFProject;component/pages/typeobjectspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TypeObjectsPage.xaml"
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
            this.SplitterColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 2:
            this.ChangeColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.AddAreas = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\TypeObjectsPage.xaml"
            this.AddAreas.Click += new System.Windows.RoutedEventHandler(this.ShowButtonTypeObject);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CopyAreas = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\TypeObjectsPage.xaml"
            this.CopyAreas.Click += new System.Windows.RoutedEventHandler(this.ShowButtonTypeObject);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditAreas = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\TypeObjectsPage.xaml"
            this.EditAreas.Click += new System.Windows.RoutedEventHandler(this.ShowButtonTypeObject);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteAreas = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\TypeObjectsPage.xaml"
            this.DeleteAreas.Click += new System.Windows.RoutedEventHandler(this.DeleteButtonTypeObject);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TypeObjectDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            
            #line 48 "..\..\..\Pages\TypeObjectsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseEdChangeClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TypeObjectLabel1 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.NameTypeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 52 "..\..\..\Pages\TypeObjectsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CommitButtonTypeObject);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

