﻿#pragma checksum "..\..\..\..\Pages\Room\RoomListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3BC8BA431BBA0315F1B33C635DBA590304A390518AD03D7E12DBA642AD04493"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IsSupport.Pages.Room;
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


namespace IsSupport.Pages.Room {
    
    
    /// <summary>
    /// RoomListPage
    /// </summary>
    public partial class RoomListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\Room\RoomListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearchBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\Room\RoomListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgrRoomsList;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\Room\RoomListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddRoom;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\Room\RoomListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditRoom;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Room\RoomListPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/IsSupport;component/pages/room/roomlistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Room\RoomListPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\Room\RoomListPage.xaml"
            ((IsSupport.Pages.Room.RoomListPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TbSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\Pages\Room\RoomListPage.xaml"
            this.TbSearchBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.TbSearchBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgrRoomsList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.BtnAddRoom = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Pages\Room\RoomListPage.xaml"
            this.BtnAddRoom.Click += new System.Windows.RoutedEventHandler(this.BtnAddRoom_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnEditRoom = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Pages\Room\RoomListPage.xaml"
            this.BtnEditRoom.Click += new System.Windows.RoutedEventHandler(this.BtnEditRoom_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Pages\Room\RoomListPage.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

