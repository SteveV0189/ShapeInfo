using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DotSpatial;
using DotSpatial.Data;
using System.Windows.Forms;

namespace InfoShape
{
    class Program
    {
        public const string INFILE = @"D:\Downloads\ne_data\ne_50m_admin_0_countries.shp";
        public const string OUTIMAGE = @"c:\users\steve\desktop\spatial.png";
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MapForm());
        }
    }
}
