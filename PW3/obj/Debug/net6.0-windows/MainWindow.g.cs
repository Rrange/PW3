﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AEFDB5E2BA5BB5F5D5E09B8A5CFBB895630E159C"
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
using prak3wpf;


namespace prak3wpf {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imga;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button play;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button up;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button down;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button find_music;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Mus;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button repeat;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Musica;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label max_mus;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label min_mus;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button random;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PW3;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((prak3wpf.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imga = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.play = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.play.Click += new System.Windows.RoutedEventHandler(this.play_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.up = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.up.Click += new System.Windows.RoutedEventHandler(this.up_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.down = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.down.Click += new System.Windows.RoutedEventHandler(this.down_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.find_music = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.find_music.Click += new System.Windows.RoutedEventHandler(this.find_music_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.media = ((System.Windows.Controls.MediaElement)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.media.MediaOpened += new System.Windows.RoutedEventHandler(this.media_MediaOpened);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.media.MediaEnded += new System.Windows.RoutedEventHandler(this.media_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Mus = ((System.Windows.Controls.ListBox)(target));
            
            #line 28 "..\..\..\MainWindow.xaml"
            this.Mus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Mus_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.repeat = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.repeat.Click += new System.Windows.RoutedEventHandler(this.repeat_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.slider = ((System.Windows.Controls.Slider)(target));
            
            #line 42 "..\..\..\MainWindow.xaml"
            this.slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Musica = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.max_mus = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.min_mus = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.random = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.random.Click += new System.Windows.RoutedEventHandler(this.random_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

