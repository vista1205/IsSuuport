#pragma checksum "..\..\..\..\Pages\Cartridgs\CartListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "377242BD14AEF08CE283E084761165755FBC07B90A0B2F2B4CCADF40E8E20B2A"
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
    /// CartList
    /// </summary>
    public partial class CartList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartHouseMenu;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartIssueMenu;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartWaitingMenu;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListCartКefuelMenu;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbPrintFilter;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRemoveCartridg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridCartridgeList;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddCartridge;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/cartridgs/cartlistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
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
            this.ListCartHouseMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.ListCartHouseMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartHouseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListCartIssueMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.ListCartIssueMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartIssueMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListCartWaitingMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.ListCartWaitingMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartWaitingMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListCartКefuelMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.ListCartКefuelMenu.Click += new System.Windows.RoutedEventHandler(this.ListCartКefuelMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CmbPrintFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.CmbPrintFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbPrintFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.SearchBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnRemoveCartridg = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.BtnRemoveCartridg.Click += new System.Windows.RoutedEventHandler(this.BtnRemoveCartridg_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DGridCartridgeList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.DGridCartridgeList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGridCartridgeList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnAddCartridge = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            this.BtnAddCartridge.Click += new System.Windows.RoutedEventHandler(this.BtnAddCartridge_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 77 "..\..\..\..\Pages\Cartridgs\CartListPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.KartIssue_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

