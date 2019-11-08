using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Framework
{
    public class Types
    {
        public static readonly Types UNKNOWN = new Types(0, "Unknown");
        public static readonly Types BEAR = new Types(1, "Bear");
        public static readonly Types CAT = new Types(2, "Cat");
        public static readonly Types BIRD = new Types(3, "Bird");
        public static readonly Types CAMEL = new Types(4, "Camel");
        public static readonly Types DONKEY = new Types(5, "Donkey");
        public static readonly Types ELEPHANT = new Types(6, "Elephant");
        public static readonly Types HORSE = new Types(7, "Horse");
        public static readonly Types LlAMA = new Types(8, "Llama");
        public static readonly Types MONKEY = new Types(9, "Monkey");
        public static readonly Types WOLF = new Types(10, "Wolf");
        public static readonly Types ZEBRA = new Types(11, "Zebra");

        public static IEnumerable<Types> types
        {
            get
            {
                yield return UNKNOWN;
                yield return BEAR;
                yield return CAT;
                yield return BIRD;
                yield return CAMEL;
                yield return DONKEY;
                yield return ELEPHANT;
                yield return HORSE;
                yield return LlAMA;
                yield return MONKEY;
                yield return WOLF;
                yield return ZEBRA;
            }
        }

        Types(int id, String type)
        {
            this.id = id;
            this.type = type;
        }

        public int id { get; private set; }
        public String type { get; private set; }


        public static Types fromValue(int value)
        {
            foreach (Types type in types)
            {
                if (type.id == value)
                    return type;
            }
            return UNKNOWN;
        }

        public static Types fromValue(string value)
        {
            foreach (Types type in types)
            {
                if (type.type == value)
                    return type;
            }
            return UNKNOWN;
        }

        public String toString(bool sendID)
        {
            if (sendID)
            {
                return id + ". " + type;
            }
            return type;
        }
    }
}
