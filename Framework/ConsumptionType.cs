using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Framework
{

    public class ConsumptionType
    {
        public static readonly ConsumptionType UNKNOWN = new ConsumptionType(0, "Unknown");
        public static readonly ConsumptionType HERBIVORE = new ConsumptionType(1, "Herbivore");
        public static readonly ConsumptionType CARNIVORE = new ConsumptionType(2, "Carnivore");
        public static readonly ConsumptionType OMNIVORE = new ConsumptionType(3, "Omnivore");

        public static IEnumerable<ConsumptionType> consumptionTypes
        {
            get
            {
                yield return UNKNOWN;
                yield return HERBIVORE;
                yield return CARNIVORE;
                yield return OMNIVORE;

            }
        }

        ConsumptionType(int id, String consumptionType)
        {
            this.id = id;
            this.consumptionType = consumptionType;
        }

        public int id { get; private set; }
        public String consumptionType { get; private set; }


        public static ConsumptionType fromValue(int value)
        {
            foreach (ConsumptionType consumptionType in consumptionTypes)
            {
                if (consumptionType.id == value)
                    return consumptionType;
            }
            return UNKNOWN;
        }
        public String toString(bool sendID)
        {
            if (sendID)
            {
                return id + ". " + consumptionType;
            }
            return consumptionType;
        }
    }
}
