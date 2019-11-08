using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Framework
{
    public class Animal
    {
        private TypesEnum type;
        private GenderEnum gender;
        private ConsumptionTypeEnum consumptionType;
        private SizesEnum size;

        public Animal(TypesEnum type, GenderEnum gender, ConsumptionTypeEnum consumptionType, SizesEnum size)
        {
            this.type = type;
            this.gender = gender;
            this.consumptionType = consumptionType;
            this.size = size;
        }

        public SizesEnum getSize()
        {
            return size;
        }

        public ConsumptionTypeEnum getConsumptionType()
        {
            return consumptionType;
        }

        public GenderEnum getGender()
        {
            return gender;
        }

        public TypesEnum getType()
        {
            return type;
        }

        public String getString()
        {
               return "Type: " + getType().toString(false).ToLower() +
                            ", Gender: " + getGender().toString(false).ToLower() +
                            ", ConsumptionType: " + getConsumptionType().toString(false).ToLower() +
                            ", Size: " + getSize().toString(false).ToLower();
        }

        public static int SizeComparator(Animal animal1, Animal animal2)
        {
            int size1 = 2; //animal1.getSize().getPoints();
            int size2 = 1; //animal2.getSize().getPoints();
            return size1.CompareTo(size2);
        }
    }
}
