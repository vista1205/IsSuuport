﻿#pragma checksum "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BCC98F8B62FC0DD1704A8C1A0FAA0AB4F1C2CBA1C39829DFCC5AAF939538E4C3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IsSupport.Pages.MultimediaSystem;
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


namespace IsSupport.Pages.MultimediaSystem {
    
    
    /// <summary>
    /// SystemUnitsListPage
    /// </summary>
    public partial class SystemUnitsListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbListStatusDevice;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBoxSerial;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBoxInvent;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgrListSystemUnit;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddSystemUnit;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditSystemUnit;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelSystemUnit;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/multimediasystem/systemunitslistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
            ((IsSupport.Pages.MultimediaSystem.SystemUnitsListPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbListStatusDevice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
            this.CmbListStatusDevice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbListStatusDevice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchBoxSerial = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
            this.SearchBoxSerial.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchBoxSerial_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchBoxInvent = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
            this.SearchBoxInvent.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchBoxInvent_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DgrListSystemUnit = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.BtnAddSystemUnit = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
            this.BtnAddSystemUnit.Click += new System.Windows.RoutedEventHandler(this.BtnAddSystemUnit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnEditSystemUnit = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
            this.BtnEditSystemUnit.Click += new System.Windows.RoutedEventHandler(this.BtnEditSystemUnit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnCancelSystemUnit = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Pages\MultimediaSystem\SystemUnitsListPage.xaml"
            this.BtnCancelSystemUnit.Click += new System.Windows.RoutedEventHandler(this.BtnCancelSystemUnit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

