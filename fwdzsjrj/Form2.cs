using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET;

namespace fwdzsjrj
{
    public partial class Form2 : Form
    {
        public Form2(string pdfFile)
        {
            InitializeComponent();

            this.Text = pdfFile;
            Assembly assembly = Assembly.GetExecutingAssembly();

            Stream stream = assembly.GetManifestResourceStream(string.Format("fwdzsjrj.{0}.pdf",pdfFile));

            PDFPageView pageView = new PDFPageView();

            pageView.Dock = DockStyle.Fill;

            pageView.Document = new PDFDocument();
            pageView.Document.Load(stream);

            this.Controls.Add(pageView);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
