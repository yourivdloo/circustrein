using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logics;

namespace Circustrein
{
    public partial class Form1 : Form
    {

        Train train = new Train();
        public Form1()
        {
            InitializeComponent();
            CmbSize.DataSource = AnimalSize.GetValues(typeof(AnimalSize));
            CmbSpecies.DataSource = AnimalSpecies.GetValues(typeof(AnimalSpecies));
        }

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;

            //AnimalSize size = (AnimalSize)Enum.Parse(typeof(AnimalSize), CmbSize.SelectedItem.ToString());
            //AnimalSpecies species = (AnimalSpecies)Enum.Parse(typeof(AnimalSpecies), CmbSpecies.SelectedItem.ToString());
            AnimalSize size = (AnimalSize) CmbSize.SelectedItem;
            AnimalSpecies species = (AnimalSpecies)CmbSpecies.SelectedItem; 
            Animal animal = new Animal(name, size, species);
            train.animals.Add(animal);
            LstAnimals.Items.Clear();
            foreach (var i in train.animals)
            {
                LstAnimals.Items.Add(i);
            }
            
        }

        private void Distribute_Click(object sender, EventArgs e)
        {

        }
    }
}
