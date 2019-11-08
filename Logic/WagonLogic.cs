using CircusTrein.Framework;
using CircusTrein.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Logic
{
    public class WagonLogic : IWagonLogic
    {
        public List<Animal> animals = new List<Animal>();
        public List<Wagon> madeWagons = new List<Wagon>();

        public void generateMockDataAnimals()
        {
            Animal wolf = new Animal(Types.WOLF, Gender.MALE, ConsumptionType.CARNIVORE, Sizes.MEDIUM);
            animals.Add(wolf);
            Animal bear = new Animal(Types.BEAR, Gender.MALE, ConsumptionType.CARNIVORE, Sizes.BIG);
            animals.Add(bear);
            Animal cat = new Animal(Types.CAT, Gender.FEMALE, ConsumptionType.CARNIVORE, Sizes.MEDIUM);
            animals.Add(cat);
            Animal bird = new Animal(Types.BIRD, Gender.MALE, ConsumptionType.HERBIVORE, Sizes.SMALL);
            animals.Add(bird);
            Animal donkey = new Animal(Types.DONKEY, Gender.FEMALE, ConsumptionType.HERBIVORE, Sizes.MEDIUM);
            animals.Add(donkey);
            Animal camel = new Animal(Types.CAMEL, Gender.MALE, ConsumptionType.HERBIVORE, Sizes.MEDIUM);
            animals.Add(camel);
            Animal elephant = new Animal(Types.ELEPHANT, Gender.MALE, ConsumptionType.HERBIVORE, Sizes.MEDIUM);
            animals.Add(elephant);
            Animal femalebear = new Animal(Types.BEAR, Gender.FEMALE, ConsumptionType.OMNIVORE, Sizes.BIG);
        }

        public void performAddToWagon()
        {
            animals = animals.OrderBy(animal => animal.getSize().getPoints()).ToList();
            List<Animal> herbivores = animals.Where(animal => animal.getConsumptionType().Equals(ConsumptionType.HERBIVORE)).ToList();
            List<Wagon> wagons = animals.Where(animal => animal.getConsumptionType().Equals(ConsumptionType.CARNIVORE)).Select(animal =>
            {
                var newWagon = new Wagon();
                newWagon.addAnimal(animal);
                return newWagon;
            }).ToList();


            int wagonamount = 0;
            foreach (Animal herbivore in herbivores)
            {
                while (true)
                {
                    if (wagons[wagonamount].canAnimalBeAdded(herbivore))
                    {
                        wagons[wagonamount].addAnimal(herbivore);
                        wagonamount = 0;
                        break;
                    }
                    else if (wagonamount + 1 < wagons.Count)
                    {
                        wagonamount++;
                    }
                    else
                    {
                        var newWagon = new Wagon();
                        newWagon.addAnimal(herbivore);
                        wagons.Add(newWagon);
                        wagonamount++;
                        break;
                    }
                }
            }
            foreach (Wagon wagon in wagons)
            {
                foreach (Animal animal in wagon.filledAnimals)
                {
                    animals.Remove(animal);
                }
                madeWagons.Add(wagon);
            }
        }
    }
}
