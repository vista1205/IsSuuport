﻿#pragma checksum "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6BB2F9B06F2EFC4AF1F6F2E3DDC810BC69A3C82116128766E809F749B98979E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IsSupport.Pages.Cartridgs;
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


namespace IsSupport.Pages.Cartridgs {
    
    
    /// <summary>
    /// AddPrintersPage
    /// </summary>
    public partial class AddPrintersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbAdditlePrinters;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddImagePrinters;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PreviewImage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddPrinters;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPrintersCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/cartridgs/addprinterspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
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
            this.TxbAdditlePrinters = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BtnAddImagePrinters = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
            this.BtnAddImagePrinters.Click += new System.Windows.RoutedEventHandler(this.BtnAddImagePrinters_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PreviewImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.BtnAddPrinters = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
            this.BtnAddPrinters.Click += new System.Windows.RoutedEventHandler(this.BtnAddPrinters_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnPrintersCancel = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Pages\Cartridgs\AddPrintersPage.xaml"
            this.BtnPrintersCancel.Click += new System.Windows.RoutedEventHandler(this.BtnPrintersCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

