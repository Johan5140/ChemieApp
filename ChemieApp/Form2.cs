using ChemieApp.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChemieApp
{
    public partial class Form2 : Form
    {

        public Form2(string kodprvku)
        {

            InitializeComponent();

            this.Headline.Text = "Informace o prvku: " + kodprvku;
            this.Headline.BackColor = Properties.Settings.Default.head;
            string hdtext = Properties.Settings.Default.hdtextcolor;
            if (hdtext == "Tmavý")
            {
                this.Headline.ForeColor = Color.Black;
            }
            if (hdtext == "Světlý")
            {
                this.Headline.ForeColor = Color.White;
            }
            string themecl = Properties.Settings.Default.theme;
            if (themecl == "Tmavý")
            {
                this.BackColor = Color.FromArgb(120, 120, 120);
                this.dataGridView1.BackColor = Color.FromArgb(120, 120, 120);
                this.dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(120, 120, 120);
                this.ForeColor = Color.White;
            }
            if (themecl == "Světlý")
            {
                this.dataGridView1.BackgroundColor = Color.White;
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
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
