#pragma checksum "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB8D85CBE3271D046C7151EF6B7B2AE1DB98D8322AA77C7220E297768C0AAF51"
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
    /// ComponentsListPage
    /// </summary>
    public partial class ComponentsListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbListTypeComponent;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBoxTitle;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgrListComponents;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddComponent;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditComponent;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelComponent;
        
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/multimediasystem/componentslistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
            ((IsSupport.Pages.MultimediaSystem.ComponentsListPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbListTypeComponent = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
            this.CmbListTypeComponent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbListTypeComponent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchBoxTitle = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
            this.SearchBoxTitle.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchBoxTitle_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DgrListComponents = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.BtnAddComponent = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
            this.BtnAddComponent.Click += new System.Windows.RoutedEventHandler(this.BtnAddComponent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnEditComponent = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
            this.BtnEditComponent.Click += new System.Windows.RoutedEventHandler(this.BtnEditComponent_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnCancelComponent = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Pages\MultimediaSystem\ComponentsListPage.xaml"
            this.BtnCancelComponent.Click += new System.Windows.RoutedEventHandler(this.BtnCancelComponent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

