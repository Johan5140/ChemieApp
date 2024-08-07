using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChemieApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.comboBox1.Items.Add("Světlý");
            this.comboBox1.Items.Add("Tmavý");
            this.comboBox2.Items.Add("Světlý");
            this.comboBox2.Items.Add("Tmavý");
            var labels = Controls.OfType<Label>().Where(x => x.Name.StartsWith("label"));
            foreach (var label in labels)
            {
                label.BackColor = Color.Transparent;
            }
            string hdtext = Properties.Settings.Default.hdtextcolor;
            if (hdtext == "Tmavý")
            {
                this.Headline.ForeColor = Color.Black;
                this.comboBox2.SelectedItem = "Tmavý";
            }
            if (hdtext == "Světlý")
            {
                this.Headline.ForeColor = Color.White;
                this.comboBox2.SelectedItem = "Světlý";
            }
            string themecl = Properties.Settings.Default.theme;
            if (themecl == "Tmavý")
            {
                this.comboBox1.SelectedItem = "Tmavý";
                this.BackgroundImage = Properties.Resources.bgdark;
                this.BackColor = Color.FromArgb(120, 120, 120);
                this.ForeColor = Color.White;
                this.comboBox1.BackColor = Color.FromArgb(150, 150, 150);
                this.comboBox1.ForeColor = Color.White;
                this.comboBox2.BackColor = Color.FromArgb(150, 150, 150);
                this.comboBox2.ForeColor = Color.White;
            }
            if (themecl == "Světlý")
            {
                this.BackgroundImage = Properties.Resources.bglight;
                this.BackColor = Color.White;
                this.comboBox1.SelectedItem = "Světlý";
            }
            this.Headline.BackColor = Properties.Settings.Default.head;
            this.button2.BackColor = Properties.Settings.Default.head;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
                Properties.Settings.Default.head = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.head = Color.FromArgb(185, 209, 234);
            Properties.Settings.Default.theme = "Světlý";
            Properties.Settings.Default.hdtextcolor = "Tmavý";
            Properties.Settings.Default.Save();
            MessageBox.Show("Nastavení vrácena do výchozích hodnot, aplikace se restartuje!");
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string vybran = comboBox1.SelectedItem.ToString();
            if (vybran == "Světlý")
            {
                Properties.Settings.Default.theme = "Světlý";
            }
            if (vybran == "Tmavý")
            {
                Properties.Settings.Default.theme = "Tmavý";
            }
            string vybran1 = comboBox2.SelectedItem.ToString();
            if (vybran1 == "Světlý")
            {
                Properties.Settings.Default.hdtextcolor = "Světlý";
            }
            if (vybran1 == "Tmavý")
            {
                Properties.Settings.Default.hdtextcolor = "Tmavý";
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("Nastavení uložena, aplikace se restartuje! ");
            Application.Restart();
        }
    }
}
