﻿#pragma checksum "..\..\..\..\..\Interface\Designer\Connection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "529643A6B43AE9929E081E408E234790"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ShaderComposer.Interface.Designer;
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


namespace ShaderComposer.Interface.Designer {
    
    
    /// <summary>
    /// Connection
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class Connection : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\Interface\Designer\Connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Interface\Designer\Connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.EllipseGeometry start;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Interface\Designer\Connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.EllipseGeometry end;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Interface\Designer\Connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.PathFigure line;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Interface\Designer\Connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.BezierSegment bezier;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Interface\Designer\Connection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShaderComposer.Interface.Designer.PreviewWindow PreviewWindow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShaderComposer;component/interface/designer/connection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Interface\Designer\Connection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.path = ((System.Windows.Shapes.Path)(target));
            
            #line 11 "..\..\..\..\..\Interface\Designer\Connection.xaml"
            this.path.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnter);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\..\Interface\Designer\Connection.xaml"
            this.path.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\..\Interface\Designer\Connection.xaml"
            this.path.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.start = ((System.Windows.Media.EllipseGeometry)(target));
            return;
            case 3:
            this.end = ((System.Windows.Media.EllipseGeometry)(target));
            return;
            case 4:
            this.line = ((System.Windows.Media.PathFigure)(target));
            return;
            case 5:
            this.bezier = ((System.Windows.Media.BezierSegment)(target));
            return;
            case 6:
            this.PreviewWindow = ((ShaderComposer.Interface.Designer.PreviewWindow)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

