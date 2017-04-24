using CefSharp;
using CefSharp.WinForms;
using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeReport
{
    public partial class MainForm : Form
    {
        private ChromiumWebBrowser Browser;
        private const string MAP_FORM_HTML = "resources/MainPage.html";
        public static MainForm Instance;

        public MainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitChromium();
            Browser.RegisterJsObject("CefBridge", new CefBridge(Browser, this)
            {
                MapForm = new MapForm()
            });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private string GetLocalHtmlString()
        {
            var uncompiled = File.ReadAllText(MAP_FORM_HTML);
            var compiled = Engine.Razor.RunCompile(uncompiled, $"MapCompile-{DateTime.Now}", null, new
            {
                Name = "Bob",
                ImageTest = Workspace.Instance.GetItemGroups().First(g => g.GetItems().Any(i => i.GetItemType() == Models.WorkspaceItem.ItemType.Image)).GetItems().First(i => i.GetItemType() == Models.WorkspaceItem.ItemType.Image).FilePath
            });
            return compiled;
        }

        public void InitChromium()
        {
            var CefSettings = new CefSettings();
            Cef.Initialize(CefSettings);
            Browser = new ChromiumWebBrowser("");
            Browser.LoadHtml(GetLocalHtmlString(), $"file://");
            this.Controls.Add(Browser);
            Browser.Dock = DockStyle.Fill;
            var settings = new BrowserSettings()
            {
                WebSecurity = CefState.Disabled,
                FileAccessFromFileUrls = CefState.Enabled,
                UniversalAccessFromFileUrls = CefState.Enabled,
                LocalStorage = CefState.Enabled
            };
            Browser.BrowserSettings = settings;
        }

        public static void ReloadHtml()
        {
            var dir = Path.Combine(Environment.CurrentDirectory + @"..\..\..\..\resources\");
            File.Copy(dir + "MainPage.html", Environment.CurrentDirectory + @"\resources\MainPage.html", true);
            File.Copy(dir + "MainForm.css", Environment.CurrentDirectory + @"\resources\MainForm.css", true);
            Instance.Browser.LoadHtml(Instance.GetLocalHtmlString(), $"File://");
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                Instance.Browser.LoadHtml(Instance.GetLocalHtmlString(), $"File://");
            }
        }
    }
}
