﻿#pragma checksum "..\..\..\..\Pages\Map.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8FC7CBEC0D5962C38D2B83DA46BB24C3FB4B322D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using odkrywca.Pages;


namespace odkrywca.Pages {
    
    
    /// <summary>
    /// Map
    /// </summary>
    public partial class Map : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 96 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink africa;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink south_america;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink north_america;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink antarctica;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink australia;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink asia;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink europe;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\Pages\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas map;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/odkrywca;component/pages/map.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Map.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.africa = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 97 "..\..\..\..\Pages\Map.xaml"
            this.africa.Click += new System.Windows.RoutedEventHandler(this.GoToSite);
            
            #line default
            #line hidden
            
            #line 98 "..\..\..\..\Pages\Map.xaml"
            this.africa.MouseEnter += new System.Windows.Input.MouseEventHandler(this.changeImage);
            
            #line default
            #line hidden
            
            #line 99 "..\..\..\..\Pages\Map.xaml"
            this.africa.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToBaseImg);
            
            #line default
            #line hidden
            return;
            case 2:
            this.south_america = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 107 "..\..\..\..\Pages\Map.xaml"
            this.south_america.Click += new System.Windows.RoutedEventHandler(this.GoToSite);
            
            #line default
            #line hidden
            
            #line 108 "..\..\..\..\Pages\Map.xaml"
            this.south_america.MouseEnter += new System.Windows.Input.MouseEventHandler(this.changeImage);
            
            #line default
            #line hidden
            
            #line 109 "..\..\..\..\Pages\Map.xaml"
            this.south_america.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToBaseImg);
            
            #line default
            #line hidden
            return;
            case 3:
            this.north_america = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 117 "..\..\..\..\Pages\Map.xaml"
            this.north_america.Click += new System.Windows.RoutedEventHandler(this.GoToSite);
            
            #line default
            #line hidden
            
            #line 118 "..\..\..\..\Pages\Map.xaml"
            this.north_america.MouseEnter += new System.Windows.Input.MouseEventHandler(this.changeImage);
            
            #line default
            #line hidden
            
            #line 119 "..\..\..\..\Pages\Map.xaml"
            this.north_america.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToBaseImg);
            
            #line default
            #line hidden
            return;
            case 4:
            this.antarctica = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 127 "..\..\..\..\Pages\Map.xaml"
            this.antarctica.Click += new System.Windows.RoutedEventHandler(this.GoToSite);
            
            #line default
            #line hidden
            
            #line 128 "..\..\..\..\Pages\Map.xaml"
            this.antarctica.MouseEnter += new System.Windows.Input.MouseEventHandler(this.changeImage);
            
            #line default
            #line hidden
            
            #line 129 "..\..\..\..\Pages\Map.xaml"
            this.antarctica.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToBaseImg);
            
            #line default
            #line hidden
            return;
            case 5:
            this.australia = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 137 "..\..\..\..\Pages\Map.xaml"
            this.australia.Click += new System.Windows.RoutedEventHandler(this.GoToSite);
            
            #line default
            #line hidden
            
            #line 138 "..\..\..\..\Pages\Map.xaml"
            this.australia.MouseEnter += new System.Windows.Input.MouseEventHandler(this.changeImage);
            
            #line default
            #line hidden
            
            #line 139 "..\..\..\..\Pages\Map.xaml"
            this.australia.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToBaseImg);
            
            #line default
            #line hidden
            return;
            case 6:
            this.asia = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 147 "..\..\..\..\Pages\Map.xaml"
            this.asia.Click += new System.Windows.RoutedEventHandler(this.GoToSite);
            
            #line default
            #line hidden
            
            #line 148 "..\..\..\..\Pages\Map.xaml"
            this.asia.MouseEnter += new System.Windows.Input.MouseEventHandler(this.changeImage);
            
            #line default
            #line hidden
            
            #line 149 "..\..\..\..\Pages\Map.xaml"
            this.asia.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToBaseImg);
            
            #line default
            #line hidden
            return;
            case 7:
            this.europe = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 157 "..\..\..\..\Pages\Map.xaml"
            this.europe.Click += new System.Windows.RoutedEventHandler(this.GoToSite);
            
            #line default
            #line hidden
            
            #line 158 "..\..\..\..\Pages\Map.xaml"
            this.europe.MouseEnter += new System.Windows.Input.MouseEventHandler(this.changeImage);
            
            #line default
            #line hidden
            
            #line 159 "..\..\..\..\Pages\Map.xaml"
            this.europe.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToBaseImg);
            
            #line default
            #line hidden
            return;
            case 8:
            this.map = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

