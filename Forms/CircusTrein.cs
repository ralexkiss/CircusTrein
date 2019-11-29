using CircusTrein.Framework;
using CircusTrein.Logic;
using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class CircusTrein : Form
    {
        WagonLogic wagonLogic = new WagonLogic();

        public CircusTrein()
        {
            InitializeComponent();
        }

        private void CircusTrein_Load(object sender, EventArgs e)
        {
            wagonLogic.generateMockDataAnimals();
            foreach (Animal animal in wagonLogic.animals)
            {
                createdAnimalsBox.Items.Add(animal.getString());
            }

            foreach (string type in Enum.GetNames(typeof(Types)))
            {
                AnimalTypeBox.Items.Add(type.ToLower());
            }

            foreach (string gender in Enum.GetNames(typeof(Gender)))
            {
                GenderBox.Items.Add(gender.ToLower());
            }

            foreach (string size in Enum.GetNames(typeof(Sizes)))
            {
                SizeBox.Items.Add(size.ToLower());
            }

            foreach (string consumptionType in Enum.GetNames(typeof(ConsumptionType)))
            {
                ConsumptionTypeBox.Items.Add(consumptionType.ToLower());
            }
        }

        private void generateMockDataButton_Click(object sender, EventArgs e)
        {
            createdAnimalsBox.Items.Clear();       
            wagonLogic.generateMockDataAnimals();
            foreach (Animal animal in wagonLogic.animals)
            {
                createdAnimalsBox.Items.Add(animal.getString());
            }
        }

        private void RunAlgoritmButton_Click(object sender, EventArgs e)
        {
            createdAnimalsBox.Items.Clear();
            filledAnimalsBox.Items.Clear();
            wagonLogic.performAddToWagon();
            foreach (Animal animal in wagonLogic.animals)
            {
                createdAnimalsBox.Items.Add(animal.getString());
            }
            foreach (Wagon wagon in wagonLogic.madeWagons)
            {
                filledAnimalsBox.Items.Add(wagon.getString());
            }
        }

        private void CreateAnimalButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AnimalTypeBox.Text) || string.IsNullOrEmpty(GenderBox.Text) || string.IsNullOrEmpty(ConsumptionTypeBox.Text) || string.IsNullOrEmpty(SizeBox.Text))
            {
                MessageBox.Show("Je hebt nog geen gegevens ingevuld!", "Mislukt!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Animal animal = new Animal(
                (Types)Enum.Parse(typeof(Types), AnimalTypeBox.SelectedItem.ToString().ToUpper()), 
                (Gender)Enum.Parse(typeof(Gender), GenderBox.SelectedItem.ToString().ToUpper()), 
                (ConsumptionType)Enum.Parse(typeof(ConsumptionType), ConsumptionTypeBox.SelectedItem.ToString().ToUpper()), 
                (Sizes)Enum.Parse(typeof(Sizes), SizeBox.SelectedItem.ToString().ToUpper()));
            wagonLogic.animals.Add(animal);
            createdAnimalsBox.Items.Add(animal.getString());
            MessageBox.Show("Dier toegevoegd met de volgende attributen: " + animal.getString(), "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void filledAnimalsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                Wagon foundWagon = wagonLogic.madeWagons.Single(wagon => wagon.getString() == filledAnimalsBox.Text);
                string message = "";
                foreach (Animal animal in foundWagon.filledAnimals)
                    message += animal.getString() + "\n";

                MessageBox.Show("Animals: " + message, "Wagon: " + foundWagon.getString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
