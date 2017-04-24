using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Threading;
using ShapeReport.Models;
using System.IO;

namespace ShapeReport
{
    class CefBridge
    {
        private static ChromiumWebBrowser Browser;
        private static MainForm MainForm;
        public MapForm MapForm;

        public CefBridge(ChromiumWebBrowser browser, MainForm form)
        {
            Browser = browser;
            MainForm = form;
        }

        public void showDevTools()
        {
            Browser.ShowDevTools();
        }

        public void reloadHtml()
        {
            MainForm.ReloadHtml();
        }

        public void showMapForm()
        {
            MainForm.Invoke((MethodInvoker)delegate ()
           {
               MainForm.Hide();
           });
            var th = new Thread(() =>
            {
                MapForm = new MapForm();
                MapForm.FormClosing += (s, e) =>
                {
                    Application.ExitThread();
                };
                MapForm.ShowDialog();
                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public string getItemGroups()
        {
            var names = new
            {
                categories = Workspace.Instance.GetItemGroups().Select(c =>
                {
                    return new
                    {
                        Order = c.Order,
                        Name = c.Name,
                        Items = c.GetItems()
                    };
                })
            };
            return JsonConvert.SerializeObject(names, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        public string compilePdf()
        {
            var pdfBytes = Report.HtmlToPdf();
            File.WriteAllBytes(Program.REPORT_PATH, pdfBytes);
            return Program.REPORT_PATH;
        }

        public string compileHtmlReport()
        {
            var html = Report.GetCompiledHtml();
            string file = Environment.CurrentDirectory + @"\resources\_compiledReport.html";
            File.WriteAllText(file, html);
            return file;
        }

        public void saveCroppedImage(string base64, string path)
        {

        }
    }
}
