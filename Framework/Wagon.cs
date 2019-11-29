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
        private readonly String id;
        private readonly int maxWeight;

        public Wagon(int weight = 10)
        {
            this.id = Guid.NewGuid().ToString();
            this.maxWeight = weight;
        }

        public String getString()
        {
            return id;
        }

        public void addAnimal(Animal animal)
        {
            if (!this.canAnimalBeAdded(animal)) throw new Exception("Animal could not be added to wagon");
            filledAnimals.Add(animal);
        }

        public bool canAnimalBeAdded(Animal newAnimal)
        {
            if (filledAnimals.Sum(animal => animal.getSize()) + newAnimal.getSize() > maxWeight)
            {
                return false;
            }

            if (filledAnimals.Any(animal => animal.getConsumptionType() is ConsumptionType.CARNIVORE))
            {
                return !(newAnimal.getConsumptionType() is ConsumptionType.CARNIVORE || newAnimal.getSize() <= filledAnimals.First(animal => animal.getConsumptionType() is ConsumptionType.CARNIVORE).getSize());
            }

            if (filledAnimals.Count > 0)
            {
                return !(newAnimal.getConsumptionType() is ConsumptionType.CARNIVORE && newAnimal.getSize() > filledAnimals.Min(animal => animal.getSize()));
            }

            return true;
        }
    }
}
