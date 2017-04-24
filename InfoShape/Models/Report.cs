using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pechkin;
using System.IO;
using RazorEngine;
using RazorEngine.Templating;

namespace ShapeReport.Models
{
    static class Report
    {
        public static byte[] HtmlToPdf()
        {
            var html = File.ReadAllText(Program.REPORT_TEMPLATE);
            var compiled = Engine.Razor.RunCompile(html, $"ReportCompile-{DateTime.Now}", null, new
            {
                Files = Workspace.Instance.GetItemGroups()
            });
            File.WriteAllText(@"c:\users\steve\desktop\outhtml.html", compiled);
            var cfg = new GlobalConfig();
            cfg.SetOutlineGeneration(false);
            var obCfg = new ObjectConfig();
            obCfg.SetPrintBackground(true);
            obCfg.SetIntelligentShrinking(true);
            return new SimplePechkin(cfg).Convert(obCfg, compiled);
        }        

        public static string GetCompiledHtml()
        {
            var html = File.ReadAllText(Program.REPORT_TEMPLATE);
            var compiled = Engine.Razor.RunCompile(html, $"ReportCompile-{DateTime.Now}", null, new
            {
                Files = Workspace.Instance.GetItemGroups()
            });
            return compiled;
        }
    }
}
