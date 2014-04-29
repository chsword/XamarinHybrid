using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Webkit;

namespace Chsword.XamarinHybrid
{
    static public class WebViewExtensions
    {
        public static WebView MessageBox(this WebView view, string message)
        {
            view.AddJavascriptInterface()
            return view;
        }
    }
}
