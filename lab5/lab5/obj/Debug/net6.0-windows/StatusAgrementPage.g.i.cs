﻿#pragma checksum "..\..\..\StatusAgrementPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54495D6DC11E290E4CD4C5729D3B58B34DC14D26"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using lab5;


namespace lab5 {
    
    
    /// <summary>
    /// StatusAgrementPage
    /// </summary>
    public partial class StatusAgrementPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Undo;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button New;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Find;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchField;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\StatusAgrementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid StatusAgentDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/lab5;component/statusagrementpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StatusAgrementPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Undo_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Undo_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.New_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.New_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Save_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Find_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Find_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Edit_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Edit_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Delete_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\StatusAgrementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Delete_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Undo = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.New = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.Edit = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.Find = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.Save = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.Delete = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.SearchField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.StatusAgentDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 84 "..\..\..\StatusAgrementPage.xaml"
            this.StatusAgentDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StatusAgentDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
