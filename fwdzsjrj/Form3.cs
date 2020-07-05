using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fwdzsjrj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form2("软件功能介绍").ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            new Form2("装修流程").ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            new Form2("装修注意事项").ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            new Form2("衣柜定制注意事项").ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            new Form2("橱柜定制注意事项").ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            new Form2("瓷砖注意事项").ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            int X = (this.Width - panel1.Width) / 2;
            int Y = (this.Height - panel1.Height) / 2;

            panel1.Location = new Point(X, Y);
        }
    }
}
