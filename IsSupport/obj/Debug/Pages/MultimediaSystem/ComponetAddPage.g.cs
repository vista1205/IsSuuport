#pragma checksum "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3500FDE480DF90FD9D69A3B28A586184C4A4958E78070A18C3F780FC6090325"
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
    /// ComponetAddPage
    /// </summary>
    public partial class ComponetAddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbTitleComponent;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbListTypeComponent;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbDescription;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddComponent;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/multimediasystem/componetaddpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
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
            this.TbTitleComponent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CmbListTypeComponent = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.TbDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnAddComponent = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
            this.BtnAddComponent.Click += new System.Windows.RoutedEventHandler(this.BtnAddComponent_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Pages\MultimediaSystem\ComponetAddPage.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

