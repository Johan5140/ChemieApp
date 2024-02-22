using ChemieApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChemieApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Vodík");
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Lithium");
            frm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Sodík");
            frm2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Draslík");
            frm2.ShowDialog();
        }
    }
}
