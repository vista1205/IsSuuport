﻿#pragma checksum "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC5FC766533EC10DDD4F301E94CD347A2606DC63FD08621FDA85742A73439080"
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
    /// AddStatusCartridgs
    /// </summary>
    public partial class AddStatusCartridgs : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbTitleStatusCartridg;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDescriptionStatusCartridg;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveStatusCartridg;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackStatusCartridg;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/cartridgs/addstatuscartridgs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml"
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
            this.TxbTitleStatusCartridg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtDescriptionStatusCartridg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SaveStatusCartridg = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml"
            this.SaveStatusCartridg.Click += new System.Windows.RoutedEventHandler(this.SaveStatusCartridg_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackStatusCartridg = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\Cartridgs\AddStatusCartridgs.xaml"
            this.BackStatusCartridg.Click += new System.Windows.RoutedEventHandler(this.BackStatusCartridg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

