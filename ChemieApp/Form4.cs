using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChemieApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Headline.BackColor = Properties.Settings.Default.head;
            this.comboBox1.Items.Add("Hmotnostní zlomek");
            comboBox1.SelectedValue = null;
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
                this.button2.BackColor = Color.FromArgb(120, 120, 120);
                this.button4.BackColor = Color.FromArgb(120, 120, 120);
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                        {
                            (control as TextBox).BackColor = Color.FromArgb(150, 150, 150);
                            (control as TextBox).ForeColor = Color.White;
                        }
                        else
                            func(control.Controls);
                };

                func(Controls);
                this.comboBox1.BackColor = Color.FromArgb(150, 150, 150);
                this.comboBox1.ForeColor = Color.White;
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
            if (comboBox1.SelectedValue == null)
            {
                return;
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vyberte prosím jednu z možností");
            }
            else
            {
                string vybran = comboBox1.SelectedItem.ToString();
                if (vybran == "Hmotnostní zlomek")
                {
                    label18.Text = "Jednoduchý výpočet hmotnostního zlomku";
                    var panels = Controls.OfType<Panel>().Where(x => x.Name.StartsWith("panel"));
                    foreach (var panel in panels)
                    {
                        panel.Hide();
                    }
                    this.panel1.Show();
                    return;
                }
                if (vybran == "Objemový zlomek")
                {
                    label18.Text = "Jednoduchý výpočet objemového zlomku";
                    var panels = Controls.OfType<Panel>().Where(x => x.Name.StartsWith("panel"));
                    foreach (var panel in panels)
                    {
                        panel.Hide();
                    }
                    return;
                }
                //Prozatimní řešení - testování funkčnosti přepínání možností v comboboxu
                else
                {
                    var panels = Controls.OfType<Panel>().Where(x => x.Name.StartsWith("panel"));
                    foreach (var panel in panels)
                    {
                        panel.Hide();
                    }
                    label18.Text = "Chyba! Akce není povolena!";
                    MessageBox.Show("Akce není povolena!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out var v1);
            decimal.TryParse(textBox2.Text, out var v2);
            decimal c = (decimal)v1 / (decimal)v2;
            label8.Text = v1.ToString();
            label9.Text = v2.ToString();
            string output = String.Format("{0:#,##0.0000}", c);
            label11.Text = output;
            decimal d = c * 100;
            string output1 = String.Format("{0:#,##0.00}", d);
            label13.Text = output1 + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox3.Text, out var v3);
            decimal.TryParse(textBox4.Text, out var v4);
            decimal a = (decimal)v3 + (decimal)v4;
            string b = String.Format("{0:#,##0.00}", a);
            decimal.TryParse(textBox3.Text, out var g);
            string v = g.ToString();
            label27.Text = b;
            textBox2.Text = b;
            textBox1.Text = v;
            button2_Click(sender, e);
        }
    }
}
