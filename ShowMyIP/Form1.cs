using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ShowMyIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        void getIP()
        {
            string localIP = string.Empty;
            IPHostEntry host;
            listBox1.Items.Clear();
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {


                localIP = ip.ToString();
                listBox1.Items.Add(localIP);
                    }
//            textBox1.Text = localIP;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getIP();
        }
    }
}


