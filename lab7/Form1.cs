using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
            textBox1.Text = form2.MySetting;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           var result =colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                button1.BackColor = colorDialog1.Color; ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000, "Title", "Content", ToolTipIcon.Info);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            var font = fontDialog1.Font;
            var color = fontDialog1.Color;
            richTextBox1.ForeColor = color;
            richTextBox1.Font = font;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // progressBar1.Value = 66;
            progressBar1.PerformStep();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
