using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_circustrein
{
    public partial class Circustrein : Form
    {
        private Sorteren logica;

        public Circustrein()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logica = new Sorteren();

            //Comboboxes
            comboBoxSelectVoer.Items.Add(Dier.voer.planten);
            comboBoxSelectVoer.Items.Add(Dier.voer.vlees);
            comboBoxSelectVoer.SelectedIndex = 0; //Autoselect

            comboBoxSelectGrootte.Items.Add(Dier.grootte.klein);
            comboBoxSelectGrootte.Items.Add(Dier.grootte.middelmatig);
            comboBoxSelectGrootte.Items.Add(Dier.grootte.groot);
            comboBoxSelectGrootte.SelectedIndex = 0; //Autoselect
        }

        private void buttonNieuwDier_Click(object sender, EventArgs e)
        {
            Dier nieuwDier = new Dier((Dier.voer)Convert.ChangeType(comboBoxSelectVoer.SelectedItem, typeof(Dier.voer)), (Dier.grootte)Convert.ChangeType(comboBoxSelectGrootte.SelectedItem, typeof(Dier.grootte))); //Maak geselecteerde dier

            for(int i = 0; i < numericUpDownAantalDieren.Value; i++)
            {
                logica.voegDierAanInputLijst(nieuwDier);
            }

            //Fill listbox
            listBoxDieren.DataSource = null;
            listBoxDieren.DataSource = logica.getLijstInputDieren();

            //Reset numeric to 1
            numericUpDownAantalDieren.Value = 1; 
        }

        public void buttonDeelWagonsIn_Click(object sender, EventArgs e)
        {
            //Maak nieuwe trein
            Trein trein = new Trein();
            List<Dier> gesorteerd = logica.sorteerLijst(logica.getLijstInputDieren());

            trein.vulTrein(gesorteerd); 

            listBoxWagons.DataSource = trein.getTrein(); 
        }

        private void listBoxWagons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wagon selected = (Wagon)Convert.ChangeType(listBoxWagons.SelectedItem, typeof(Wagon));
            progressBarWagon.Value = (10 - selected.getVrijeRuimte()) * 10;

            listBoxDierenWagon.DataSource = selected.getDieren();
        }

        private void selectVoer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
