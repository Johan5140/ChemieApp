using ChemieApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        //Odstranění pozadí u popisků
        var labels = Controls.OfType<Label>().Where(x => x.Name.StartsWith("label"));
            foreach (var label in labels)
            {
                label.BackColor = Color.Transparent;
            }

        }
        //Přetahování okna po obrazovce
        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button123_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button122_Click(object sender, EventArgs e)
        {
            aboutapp aboutappform = new aboutapp();
            aboutappform.ShowDialog();
        }
        
        #region Tlačítka vyvolávající informace o prvcích 
        
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Rubidium");
            frm2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Cesium");
            frm2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Francium");
            frm2.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Beryllium");
            frm2.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Hořčík");
            frm2.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Vápník");
            frm2.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Stroncium");
            frm2.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Baryum");
            frm2.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Radium");
            frm2.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Skandium");
            frm2.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Yttrium");
            frm2.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Titan");
            frm2.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Zirkonium");
            frm2.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Hafnium");
            frm2.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Rutherfordium");
            frm2.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Vanad");
            frm2.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Niob");
            frm2.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Tantal");
            frm2.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Dubnium");
            frm2.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Chrom");
            frm2.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Molybden");
            frm2.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Wolfram");
            frm2.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Seaborgium");
            frm2.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Mangan");
            frm2.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Technecium");
            frm2.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Rhenium");
            frm2.ShowDialog();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Bohrium");
            frm2.ShowDialog();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Železo");
            frm2.ShowDialog();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Ruthenium");
            frm2.ShowDialog();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Osmium");
            frm2.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Hassium");
            frm2.ShowDialog();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Kobalt");
            frm2.ShowDialog();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Rhodium");
            frm2.ShowDialog();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Iridium");
            frm2.ShowDialog();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Meitnerium");
            frm2.ShowDialog();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Nikl");
            frm2.ShowDialog();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Palladium");
            frm2.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Platina");
            frm2.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Darmstadtium");
            frm2.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Měď");
            frm2.ShowDialog();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Stříbro");
            frm2.ShowDialog();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Zlato");
            frm2.ShowDialog();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Roentgenium");
            frm2.ShowDialog();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Zinek");
            frm2.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Kadmium");
            frm2.ShowDialog();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Rtuť");
            frm2.ShowDialog();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Kopernicium");
            frm2.ShowDialog();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Bor");
            frm2.ShowDialog();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Hliník");
            frm2.ShowDialog();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Gallium");
            frm2.ShowDialog();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Indium");
            frm2.ShowDialog();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Thallium");
            frm2.ShowDialog();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Nihonium");
            frm2.ShowDialog();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Uhlík");
            frm2.ShowDialog();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Křemík");
            frm2.ShowDialog();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Germanium");
            frm2.ShowDialog();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Cín");
            frm2.ShowDialog();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Olovo");
            frm2.ShowDialog();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Flerovium");
            frm2.ShowDialog();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Dusík");
            frm2.ShowDialog();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Fosfor");
            frm2.ShowDialog();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Arsen");
            frm2.ShowDialog();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Antimon");
            frm2.ShowDialog();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Bismut");
            frm2.ShowDialog();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Moscovium");
            frm2.ShowDialog();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Kyslík");
            frm2.ShowDialog();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Síra");
            frm2.ShowDialog();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Selen");
            frm2.ShowDialog();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Tellur");
            frm2.ShowDialog();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Polonium");
            frm2.ShowDialog();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Livermorium");
            frm2.ShowDialog();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Fluor");
            frm2.ShowDialog();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Chlor");
            frm2.ShowDialog();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Brom");
            frm2.ShowDialog();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Jod");
            frm2.ShowDialog();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Astat");
            frm2.ShowDialog();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Tennessin");
            frm2.ShowDialog();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Helium");
            frm2.ShowDialog();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Neon");
            frm2.ShowDialog();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Argon");
            frm2.ShowDialog();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Krypton");
            frm2.ShowDialog();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Xenon");
            frm2.ShowDialog();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Radon");
            frm2.ShowDialog();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Oganesson");
            frm2.ShowDialog();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Lanthan");
            frm2.ShowDialog();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Cer");
            frm2.ShowDialog();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Praseodym");
            frm2.ShowDialog();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Neodym");
            frm2.ShowDialog();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Promethium");
            frm2.ShowDialog();
        }

        private void button95_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Samarium");
            frm2.ShowDialog();
        }

        private void button96_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Europium");
            frm2.ShowDialog();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Gadolinium");
            frm2.ShowDialog();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Terbium");
            frm2.ShowDialog();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Dysprosium");
            frm2.ShowDialog();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Holmium");
            frm2.ShowDialog();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Erbium");
            frm2.ShowDialog();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Thulium");
            frm2.ShowDialog();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Ytterbium");
            frm2.ShowDialog();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Lutecium");
            frm2.ShowDialog();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Aktinium");
            frm2.ShowDialog();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Thorium");
            frm2.ShowDialog();
        }

        private void button107_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Protaktinium");
            frm2.ShowDialog();
        }

        private void button108_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Uran");
            frm2.ShowDialog();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Neptunium");
            frm2.ShowDialog();
        }

        private void button110_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Plutonium");
            frm2.ShowDialog();
        }

        private void button111_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Americium");
            frm2.ShowDialog();
        }

        private void button112_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Curium");
            frm2.ShowDialog();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Berkelium");
            frm2.ShowDialog();
        }

        private void button114_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Kalifornium");
            frm2.ShowDialog();
        }

        private void button115_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Einsteinium");
            frm2.ShowDialog();
        }

        private void button116_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Fermium");
            frm2.ShowDialog();
        }

        private void button117_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Mendelevium");
            frm2.ShowDialog();
        }

        private void button119_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Nobelium");
            frm2.ShowDialog();
        }

        private void button118_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Lawrencium");
            frm2.ShowDialog();
        }
        #endregion

    }
}
