﻿#pragma checksum "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "161D5305DA8A41EED729A6CD44F0775BDB98BB1DE633618AE14580DE89C008AD"
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
    /// TypesEquipmentListPage
    /// </summary>
    public partial class TypesEquipmentListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgrTypesEquipmentList;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddTypesEquipment;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditTypesEquipment;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/multimediasystem/typesequipmentlistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
            ((IsSupport.Pages.MultimediaSystem.TypesEquipmentListPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DgrTypesEquipmentList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BtnAddTypesEquipment = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
            this.BtnAddTypesEquipment.Click += new System.Windows.RoutedEventHandler(this.BtnAddTypesEquipment_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnEditTypesEquipment = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
            this.BtnEditTypesEquipment.Click += new System.Windows.RoutedEventHandler(this.BtnEditTypesEquipment_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Pages\MultimediaSystem\TypesEquipmentListPage.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

