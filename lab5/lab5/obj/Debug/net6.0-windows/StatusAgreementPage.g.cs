﻿#pragma checksum "..\..\..\StatusAgreementPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "523715B403BC49ECC90C27552ED2B1297BF946B1"
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
    /// StatusAgreementPage
    /// </summary>
    public partial class StatusAgreementPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Undo;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button New;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Find;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchField;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\StatusAgreementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/lab5;component/statusagreementpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StatusAgreementPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 15 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Undo_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Undo_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.New_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.New_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Save_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Find_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Find_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 31 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Edit_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Edit_CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 35 "..\..\..\StatusAgreementPage.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Delete_CommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\StatusAgreementPage.xaml"
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
            this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

