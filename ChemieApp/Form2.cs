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

        public Form2(string kodprvku)
        {   
            
            InitializeComponent();
            
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            this.label1.Text = "Informace o prvku: " + kodprvku;

            var xml = XDocument.Parse(Resources.prvky);
            // Vytvoření datasetu
            DataSet dataSet = new DataSet();
            // Vložení dat do datasetu
            dataSet.ReadXml(xml.CreateReader());

            this.dataGridView1.DataSource = dataSet.Tables[kodprvku];

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersVisible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Uzavření okna pomocí klávesy ESC
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
