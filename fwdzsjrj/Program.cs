using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace fwdzsjrj
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            
            if (args.Name.Contains("O2S.Components.PDFView4NET"))
            {
                Stream stream = assembly.GetManifestResourceStream(string.Format("fwdzsjrj.O2S.Components.PDFView4NET.dll"));
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                return Assembly.Load(buffer);
            }
            if (args.Name.Contains("O2S.Components.PDFRender4NET"))
            {
                Stream stream = assembly.GetManifestResourceStream(string.Format("fwdzsjrj.O2S.Components.PDFRender4NET.dll"));
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                return Assembly.Load(buffer);
            }
            throw new Exception("加载【" + args.Name + "】失败");
        }
    }
}
