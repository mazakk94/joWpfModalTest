﻿#pragma checksum "..\..\..\..\Windows\Editor\CreateTest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "71FFD915EC1466FFD68A088A8FE48DF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace UserInterface.Windows.Editor {
    
    
    /// <summary>
    /// CreateTest
    /// </summary>
    public partial class CreateTest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider mySlider;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Length;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox questionsIds;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label maxPoints;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkBox;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Windows\Editor\CreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/windows/editor/createtest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Editor\CreateTest.xaml"
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
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.mySlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 3:
            this.Length = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.questionsIds = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.lstBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.maxPoints = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.chkBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\..\Windows\Editor\CreateTest.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.acceptButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

