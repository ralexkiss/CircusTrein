using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Framework
{
    public class Wagon
    {
        public List<Animal> filledAnimals = new List<Animal>();
        private String id;
        private int points;

        public Wagon(int points = 10)
        {
            this.id = Guid.NewGuid().ToString();
            this.points = points;
        }

        public String getString()
        {
            return "Wagon: " + id;
        }

        public void addAnimal(Animal animal)
        {
            if (!this.canAnimalBeAdded(animal)) throw new Exception("Animal could not be added to wagon");
            filledAnimals.Add(animal);
        }

        public bool canAnimalBeAdded(Animal newAnimal)
        {
            if (filledAnimals.Sum(animal => animal.getSize().getPoints()) + newAnimal.getSize().getPoints() > points)
            {
                return false;
            }

            if (filledAnimals.Any(animal => animal.getConsumptionType().id is 2))
            {
                return !(newAnimal.getConsumptionType().id is 2 || newAnimal.getSize().getPoints() <= filledAnimals.First(animal => animal.getConsumptionType().id is 2).getSize().getPoints());
            }

            if (filledAnimals.Count > 0)
            {
                return !(newAnimal.getConsumptionType().id is 2 && newAnimal.getSize().getPoints() > filledAnimals.Min(animal => animal.getSize().getPoints()));
            }

            return true;
        }
    }
}
