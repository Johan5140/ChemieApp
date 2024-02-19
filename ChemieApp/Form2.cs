using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Xml;
using ChemieApp.Properties;
using System.Xml.Linq;

namespace ChemieApp
{
    public partial class Form2 : Form
    {
        public int x;    //can be private too
        public string y; //can be private too

        public Form2(string kodprvku)
        {   
            
            InitializeComponent();
            
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            this.label2.Text = kodprvku;

        }
        private void button1_Click(object sender, EventArgs e)
{
this.Close();
}

//define some function which changes defined global values
}
}
