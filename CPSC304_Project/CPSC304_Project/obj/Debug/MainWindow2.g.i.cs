﻿#pragma checksum "..\..\MainWindow2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FBE73CAFB34E9CDD46488CAC4C7A6C926F34E235"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CPSC304_Project;
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


namespace CPSC304_Project {
    
    
    /// <summary>
    /// MainWindow2
    /// </summary>
    public partial class MainWindow2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DragLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ActiveUsersProjectsComboBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem AddNewProjectComboBoxItem;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowProjectMembersButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrentUserLabel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MainStackPanel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewListButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProjectsButton;
        
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
            System.Uri resourceLocater = new System.Uri("/CPSC304_Project;component/mainwindow2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow2.xaml"
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
            this.DragLabel = ((System.Windows.Controls.Label)(target));
            
            #line 10 "..\..\MainWindow2.xaml"
            this.DragLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragRectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ActiveUsersProjectsComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\MainWindow2.xaml"
            this.ActiveUsersProjectsComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProjectListComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddNewProjectComboBoxItem = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.ShowProjectMembersButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\MainWindow2.xaml"
            this.ShowProjectMembersButton.Click += new System.Windows.RoutedEventHandler(this.ShowProjectMembersButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MainWindow2.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LogoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MainWindow2.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CurrentUserLabel = ((System.Windows.Controls.Label)(target));
            
            #line 17 "..\..\MainWindow2.xaml"
            this.CurrentUserLabel.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CurrentUserLabel_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 17 "..\..\MainWindow2.xaml"
            this.CurrentUserLabel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.CurrentUserLabel_MouseEnter);
            
            #line default
            #line hidden
            
            #line 17 "..\..\MainWindow2.xaml"
            this.CurrentUserLabel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.CurrentUserLabel_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MainStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.AddNewListButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow2.xaml"
            this.AddNewListButton.Click += new System.Windows.RoutedEventHandler(this.AddNewListButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ProjectsButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\MainWindow2.xaml"
            this.ProjectsButton.Click += new System.Windows.RoutedEventHandler(this.ProjectsButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

