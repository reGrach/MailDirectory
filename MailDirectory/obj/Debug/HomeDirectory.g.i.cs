﻿#pragma checksum "..\..\HomeDirectory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9A714E712D92158782847FCF77264548650AA2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MailDirectory;
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


namespace MailDirectory {
    
    
    /// <summary>
    /// HomeDirectory
    /// </summary>
    public partial class HomeDirectory : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\HomeDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock headLine;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\HomeDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lettersGrid;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\HomeDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textMail;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\HomeDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butAdd;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\HomeDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butWorkDB;
        
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
            System.Uri resourceLocater = new System.Uri("/MailDirectory;component/homedirectory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomeDirectory.xaml"
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
            this.headLine = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.lettersGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 61 "..\..\HomeDirectory.xaml"
            this.lettersGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChooseLetterClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textMail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.butAdd = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\HomeDirectory.xaml"
            this.butAdd.Click += new System.Windows.RoutedEventHandler(this.Clicl_Add_New_Message);
            
            #line default
            #line hidden
            return;
            case 5:
            this.butWorkDB = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\HomeDirectory.xaml"
            this.butWorkDB.Click += new System.Windows.RoutedEventHandler(this.Clicl_Add_New_Employee);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

