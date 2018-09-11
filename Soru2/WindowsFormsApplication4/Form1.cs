using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int satis;
            int adet;
            int hasilat;
            satis = int.Parse (textBox1 .Text);
            adet =  int.Parse (textBox2 .Text);
            hasilat = (satis * adet) / (100)*85;
            MessageBox .Show (hasilat .ToString());
        }
    }
}
