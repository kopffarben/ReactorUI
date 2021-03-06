﻿using ReactorUI.Contracts;
using ReactorUI.Styles;
using ReactorUI.WPF.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReactorUI.WPF.Controls
{
    internal class FrameworkElement<T, I, TS> : UIElement<T, I, TS>
        where T : System.Windows.FrameworkElement, new()
        where I : IFrameworkElement
        where TS : FrameworkElementStyle<I>
    {
        protected override void OnUpdate()
        {
            _nativeControl.Width = _widget.Width;
            _nativeControl.MinWidth = _widget.MinWidth;
            _nativeControl.MaxHeight = _widget.MaxHeight;
            _nativeControl.Height = _widget.Height;
            _nativeControl.MinHeight = _widget.MinHeight;
            _nativeControl.MaxWidth = _widget.MaxWidth;
            _nativeControl.Margin = _widget.Margin.ToNativeThickness();
            _nativeControl.VerticalAlignment = (System.Windows.VerticalAlignment)_widget.VerticalAlignment;
            _nativeControl.HorizontalAlignment = (System.Windows.HorizontalAlignment)_widget.HorizontalAlignment;
            base.OnUpdate();
        }
    }
}
