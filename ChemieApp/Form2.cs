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

            var xml = XDocument.Parse(Resources.prvky);
            // creating an empty DataSet object
            DataSet dataSet = new DataSet();
            // filling DataSet with the xml read
            dataSet.ReadXml(xml.CreateReader());

            var ds = new DataSet();
            //ds.ReadXml(Properties.Resources.Vodik.xml);
            this.dataGridView1.DataSource = dataSet.Tables[kodprvku]; //Tables[0]

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersVisible = false;

        }
        private void button1_Click(object sender, EventArgs e)
{
this.Close();
}
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        //define some function which changes defined global values
    }
}
