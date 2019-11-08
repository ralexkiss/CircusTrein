using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Framework
{
    public class Gender
    {
        public static readonly Gender UNKNOWN = new Gender(0, "Unknown");
        public static readonly Gender MALE = new Gender(1, "Male");
        public static readonly Gender FEMALE = new Gender(2, "Female");

        public static IEnumerable<Gender> genders
        {
            get
            {
                yield return UNKNOWN;
                yield return MALE;
                yield return FEMALE;
            }
        }

        Gender(int id, String gender)
        {
            this.id = id;
            this.gender = gender;
        }

        public int id { get; private set; }
        public String gender { get; private set; }

        public static Gender fromValue(int value)
        {
            foreach(Gender gender in genders)
            {
                if (gender.id == value)
                    return gender;
            }
            return UNKNOWN;
        }
        public String toString(bool sendID)
        {
            if (sendID)
            {
                return id + ". " + gender;
            }
            return gender;
        }
    }
}
