﻿#pragma checksum "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7BDBC6BD7BB53F273F48C31AFE016DED69D21ECF36608544C975EA1E290B60BD"
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
    /// CartridgRecevingPage
    /// </summary>
    public partial class CartridgRecevingPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblAbout;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbRecevingCartridg;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRecevingKartridg;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRecevingBack;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/cartridgs/cartridgrecevingpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml"
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
            this.TblAbout = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.CmbRecevingCartridg = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.BtnRecevingKartridg = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml"
            this.BtnRecevingKartridg.Click += new System.Windows.RoutedEventHandler(this.BtnRecevingKartridg_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnRecevingBack = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Pages\Cartridgs\CartridgRecevingPage.xaml"
            this.BtnRecevingBack.Click += new System.Windows.RoutedEventHandler(this.BtnRecevingBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

