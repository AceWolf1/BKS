﻿#pragma checksum "..\..\..\Login\RegWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "431611A4A471C2BB86090C0C9A1F053ABDFCD871FE36BE35DD4D7CCC5816F944"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BKS;
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


namespace BKS {
    
    
    /// <summary>
    /// RegWindow
    /// </summary>
    public partial class RegWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCloseRegWindow;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CollapseBtnRegWindow;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstName;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patronymic;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Phone;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Login\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_RegRegWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/BKS;component/login/regwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Login\RegWindow.xaml"
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
            
            #line 15 "..\..\..\Login\RegWindow.xaml"
            ((BKS.RegWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnCloseRegWindow = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Login\RegWindow.xaml"
            this.BtnCloseRegWindow.Click += new System.Windows.RoutedEventHandler(this.BtnCloseRegWindow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CollapseBtnRegWindow = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Login\RegWindow.xaml"
            this.CollapseBtnRegWindow.Click += new System.Windows.RoutedEventHandler(this.CollapseBtnRegWindow_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Patronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Btn_RegRegWindow = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\Login\RegWindow.xaml"
            this.Btn_RegRegWindow.Click += new System.Windows.RoutedEventHandler(this.Btn_RegRegWindow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
