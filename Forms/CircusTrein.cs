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

            foreach (Types type in Types.types)
            {
                AnimalTypeBox.Items.Add(type.type);
            }

            foreach (Gender gender in Gender.genders)
            {
                GenderBox.Items.Add(gender.gender);
            }

            foreach (Sizes size in Sizes.sizes)
            {
                SizeBox.Items.Add(size.size);
            }

            foreach (ConsumptionType consumptionType in ConsumptionType.consumptionTypes)
            {
                ConsumptionTypeBox.Items.Add(consumptionType.consumptionType);
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
            Animal animal = new Animal(Types.fromValue(AnimalTypeBox.SelectedItem.ToString()), Gender.fromValue(GenderBox.SelectedItem.ToString()), ConsumptionType.fromValue(ConsumptionTypeBox.SelectedItem.ToString()), Sizes.fromValue(SizeBox.SelectedItem.ToString()));
            wagonLogic.animals.Add(animal);
            createdAnimalsBox.Items.Add(animal.getString());
            MessageBox.Show("Dier toegevoegd met de volgende attributen: " + animal.getString(), "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
