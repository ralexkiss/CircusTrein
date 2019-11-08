using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Framework
{
    public class Animal
    {
        private Types type;
        private Gender gender;
        private ConsumptionType consumptionType;
        private Sizes size;

        public Animal(Types type, Gender gender, ConsumptionType consumptionType, Sizes size)
        {
            this.type = type;
            this.gender = gender;
            this.consumptionType = consumptionType;
            this.size = size;
        }

        public int getSize()
        {
            switch (size)
            {
                case Sizes.SMALL:
                    return 1;
                case Sizes.MEDIUM:
                    return 3;
                case Sizes.BIG:
                    return 5;
            }
            return 0;
        }

        public ConsumptionType getConsumptionType()
        {
            return consumptionType;
        }

        public Gender getGender()
        {
            return gender;
        }

        public Types getType()
        {
            return type;
        }

        public String getString()
        {
               return "Type: " + getType().ToString().ToLower() +
                            ", Gender: " + getGender().ToString().ToLower() +
                            ", ConsumptionType: " + getConsumptionType().ToString().ToLower() +
                            ", Size: " + getSize().ToString().ToLower();
        }

        public static int SizeComparator(Animal animal1, Animal animal2)
        {
            int size1 = 2; //animal1.getSize().getPoints();
            int size2 = 1; //animal2.getSize().getPoints();
            return size1.CompareTo(size2);
        }
    }
}
