﻿#pragma checksum "..\..\..\Pages\CartridgePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D458BCA75DBBAD96BA2B88FE970D8CC91813D33F0FCFE8725A4F475B79E78F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IsSupport.Pages;
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


namespace IsSupport.Pages {
    
    
    /// <summary>
    /// CartridgePage
    /// </summary>
    public partial class CartridgePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\CartridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartHouseMenu;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\CartridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartIssueMenu;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\CartridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartWaitingMenu;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\CartridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartКefuelMenu;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\CartridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbPrintFilter;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\CartridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridCartridgeList;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/cartridgepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\CartridgePage.xaml"
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
            
            #line 9 "..\..\..\Pages\CartridgePage.xaml"
            ((IsSupport.Pages.CartridgePage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListCartHouseMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\Pages\CartridgePage.xaml"
            this.ListCartHouseMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartHouseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListCartIssueMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\..\Pages\CartridgePage.xaml"
            this.ListCartIssueMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartIssueMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListCartWaitingMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\Pages\CartridgePage.xaml"
            this.ListCartWaitingMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartWaitingMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListCartКefuelMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\..\Pages\CartridgePage.xaml"
            this.ListCartКefuelMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartКefuelMenu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CmbPrintFilter = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.DGridCartridgeList = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

