using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace InfoShape
{
    class CefBridge
    {
        private static ChromiumWebBrowser Browser;
        private static MainForm MapForm;

        public CefBridge(ChromiumWebBrowser browser, MainForm form)
        {
            Browser = browser;
            MapForm = form;
        }

        public void showDevTools()
        {
            Browser.ShowDevTools();
        }
    }
}
