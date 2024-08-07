using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ChemieApp
{
    public partial class aboutapp : Form
    {
        public aboutapp()
        {
            InitializeComponent();
            this.Headline.BackColor = Properties.Settings.Default.head;
            this.Text = String.Format("O aplikaci {0}", AssemblyTitle);
            this.label2.Text = AssemblyProduct;
            this.label3.Text = String.Format("{0}", AssemblyVersion);
            this.label4.Text = AssemblyCopyright;
            this.label5.Text = "Aplikace je ve vývoji a nemusí fungovat správně!";
            this.richTextBox1.SelectAll();
            this.richTextBox1.SelectedText = Properties.Resources.info;
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
                this.BackgroundImage = Properties.Resources.bgdark;
                this.BackColor = Color.FromArgb(120, 120, 120);
                this.ForeColor = Color.White;
                this.richTextBox1.BackColor = Color.FromArgb(120, 120, 120);
                this.richTextBox1.ForeColor = Color.White;
            }
            if (themecl == "Světlý")
            {
                this.BackgroundImage = Properties.Resources.bglight;
                this.BackColor = Color.White;
            }
            var labels = Controls.OfType<Label>().Where(x => x.Name.StartsWith("label"));
            foreach (var label in labels)
            {
                label.BackColor = Color.Transparent;
            }
        }

        #region Přístup k atributům sestavení

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

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
