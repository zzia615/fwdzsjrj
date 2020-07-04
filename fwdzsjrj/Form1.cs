using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fwdzsjrj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.FormClosed += Form_FormClosed;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
