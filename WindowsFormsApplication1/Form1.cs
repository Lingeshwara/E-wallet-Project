using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = "COM7";
                serialPort1.Open();
            }
            tb_transfer.Text = "open";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                string text = tb_transfer.Text;
                serialPort1.WriteLine(text);
            }

            MessageBox.Show("$1000 transferred successful");
        }
    }
}