using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Framework
{
    public class Sizes
    {
        public static readonly Sizes UNKNOWN = new Sizes(0, "Unknown", 0);
        public static readonly Sizes SMALL = new Sizes(1, "Klein", 1);
        public static readonly Sizes MEDIUM = new Sizes(2, "Middelmatig", 3);
        public static readonly Sizes BIG = new Sizes(3, "Groot", 5);

        public static IEnumerable<Sizes> sizes
        {
            get
            {
                yield return UNKNOWN;
                yield return SMALL;
                yield return MEDIUM;
                yield return BIG;

            }
        }

        Sizes(int id, String size, int points)
        {
            this.id = id;
            this.size = size;
            this.points = points;
        }

        public int id { get; private set; }
        public String size { get; private set; }
        public int points { get; private set; }


        public static Sizes fromValue(int value)
        {
            foreach (Sizes size in sizes)
            {
                if (size.id == value)
                    return size;
            }
            return UNKNOWN;
        }

        public static Sizes fromValue(string value)
        {
            foreach (Sizes size in sizes)
            {
                if (size.size == value)
                    return size;
            }
            return UNKNOWN;
        }

        public String toString(bool sendID)
        {
            if (sendID)
            {
                return id + ". " + size;
            }
            return size;
        }
        public int getPoints()
        {
            return points;
        }
    }
}
