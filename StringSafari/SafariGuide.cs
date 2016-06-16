using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSafari
{
    public class SafariGuide
    {
        /// <summary>
        /// Looks for a baby zebra in <paramref name="str"/>.
        /// <para>A baby zebra is "zebra", all lowercase.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has "zebra" in it, false otherwise</returns>
        public static bool HasBabyZebra(string str)
        {
            return str.Contains("zebra");
        }

        /// <summary>
        /// Looks for an adult zebra in <paramref name="str"/>.
        /// <para>An adult zebra is "ZEBRA", all uppercase.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has "ZEBRA" in it, false otherwise</returns>
        public static bool HasAdultZebra(string str)
        {
            return str.Contains("ZEBRA");
        }

        /// <summary>
        /// Looks for a zebra in <paramref name="str"/>.
        /// <para>A zebra is the letters "ZEBRA", in any case combination (upper or lower)</para>
        /// <para>"Zebra", "zebra", "ZEBRA", and "ZeBrA" are all valid examples of zebras.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has a zebra in it, false otherwise</returns>
        public static bool HasZebra(string str)
        {
            //string newString = str.ToLower();
            //return HasBabyZebra(newString);
            //return str.ToLower().Contains("zebra");
            return HasBabyZebra(str.ToLower());
        }

        /// <summary>
        /// Looks for at least two zebras in <paramref name="str"/>.
        /// <para>A zebra is defined as it is for the <see cref="HasZebra(string)"/> method.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two zebras in it, false otherwise</returns>
        public static bool HasADazzle(string str)
        {
            // "lion zebra zebra"
            //  0123456789012345
            string newString = str.ToLower();
            int firstZebra = newString.IndexOf("zebra");
            int lastZebra = newString.LastIndexOf("zebra");

            if (firstZebra == lastZebra)
            {
                // only one or zero zebras
                return false;
            }
            else
            {
                // at least two zebras
                return true;
            }
        }

        /// <summary>
        /// Looks for at least two lions in <paramref name="str"/>.
        /// <para>A lion is the letters "LION", in any case combination (upper or lower)</para>
        /// <para>"Lion", "lion", "LION", and "LiOn" are all valid examples of lions.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two lions in it, false otherwise</returns>
        public static bool HasAPride(string str)
        {
            string newString = str.ToLower();
            int firstLion = newString.IndexOf("lion");
            int lastLion = newString.LastIndexOf("lion");

            if (firstLion == lastLion)
            {
                // only one or zero lions!
                return false;
            }
            else
            {
                // at least two lions
                return true;
            }
        }

        /// <summary>
        /// Looks for a pride of lions and only one zebra in <paramref name="str"/>.
        /// <para>If there are two or more zebras, this method should return false.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two lions in it and just one zebra, false otherwise</returns>
        public static bool ThereWillBeBlood(string str)
        {
            // looking for ONE zebra: NOT a dazzle
            if (HasAPride(str) && (!HasADazzle(str) && HasZebra(str)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Looks for a lion and determines if the lion is far enough away for safety.
        /// <para>If there is no lion, this method returns true.</para>
        /// <para>If there is a lion at the start of the string, this method returns false.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if there is no lion at the start of the string</returns>
        public static bool SafeDistanceToLion(string str)
        {
            string newString = str.ToLower();
            if (newString.StartsWith("lion"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Returns true if the string is long (more than 10 characters)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsCrowded(string str)
        {
            if (str.Length > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
