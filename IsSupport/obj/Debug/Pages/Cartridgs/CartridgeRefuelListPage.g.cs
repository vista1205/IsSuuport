#pragma checksum "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF32F8D742ABA43400A0992AD8E8D65054C296401A063869961790C411740DA6"
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
    /// CartridgeRefuelListPage
    /// </summary>
    public partial class CartridgeRefuelListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbPrintFilter;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/cartridgs/cartridgerefuellistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml"
            ((IsSupport.Pages.Cartridgs.CartridgeRefuelListPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbPrintFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml"
            this.CmbPrintFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbPrintFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\Pages\Cartridgs\CartridgeRefuelListPage.xaml"
            this.SearchBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DGridCartridgeList = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

