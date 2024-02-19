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
            // creating XDocument from your file
            var xml = XDocument.Parse(Resources.prvky);
            // creating an empty DataSet object
            DataSet dataSet = new DataSet();
            // filling DataSet with the xml read
            dataSet.ReadXml(xml.CreateReader());

            var ds = new DataSet();
            //ds.ReadXml(Properties.Resources.Vodik.xml);
            frm2.dataGridView1.DataSource = dataSet.Tables["vodik"]; //Tables[0]

            frm2.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            frm2.dataGridView1.ColumnHeadersVisible = false;
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Lithium");
            // creating XDocument from your file
            var xml = XDocument.Parse(Resources.prvky);
            // creating an empty DataSet object
            DataSet dataSet = new DataSet();
            // filling DataSet with the xml read
            dataSet.ReadXml(xml.CreateReader());

            var ds = new DataSet();
            //ds.ReadXml(Properties.Resources.Vodik.xml);
            frm2.dataGridView1.DataSource = dataSet.Tables["lithium"]; //Tables[0]

            frm2.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            frm2.dataGridView1.ColumnHeadersVisible = false;
            frm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Sodík");
            // creating XDocument from your file
            var xml = XDocument.Parse(Resources.prvky);
            // creating an empty DataSet object
            DataSet dataSet = new DataSet();
            // filling DataSet with the xml read
            dataSet.ReadXml(xml.CreateReader());

            var ds = new DataSet();
            //ds.ReadXml(Properties.Resources.Vodik.xml);
            frm2.dataGridView1.DataSource = dataSet.Tables["sodik"]; //Tables[0]

            frm2.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            frm2.dataGridView1.ColumnHeadersVisible = false;
            frm2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Draslík");
            // creating XDocument from your file
            var xml = XDocument.Parse(Resources.prvky);
            // creating an empty DataSet object
            DataSet dataSet = new DataSet();
            // filling DataSet with the xml read
            dataSet.ReadXml(xml.CreateReader());

            var ds = new DataSet();
            //ds.ReadXml(Properties.Resources.Vodik.xml);
            frm2.dataGridView1.DataSource = dataSet.Tables["draslik"]; //Tables[0]

            frm2.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            frm2.dataGridView1.ColumnHeadersVisible = false;
            frm2.ShowDialog();
        }
    }
}
