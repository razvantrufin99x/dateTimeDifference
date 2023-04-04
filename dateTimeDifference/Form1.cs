using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimeDifference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DateTime dt1 = new DateTime();
        public DateTime dt2 = new DateTime();
      
        private void Form1_Load(object sender, EventArgs e)
        {
            dt1 = DateTime.Now;
            dt1 = new DateTime(1978,2,13,0,0,0,DateTimeKind.Local);
            textBox1.Text = dt1.ToString();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dt2 = DateTime.Now;
            textBox2.Text = dt2.ToString();
            TimeSpan tmp = dt2 - dt1;
            button1.Text = (tmp.Days/365).ToString() + "  Years";
            textBox3.Text = tmp.ToString();
        }
    }
}
