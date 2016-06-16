using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringSafari.Test
{
    [TestFixture]
    public class StringSafariTest
    {
        [TestCase("zebra", ExpectedResult = true)]
        [TestCase("ZEBRA", ExpectedResult = false)]
        [TestCase("Lion", ExpectedResult = false)]
        [TestCase("LION ZEBRA zebra lion", ExpectedResult = true)]
        [TestCase("LION zebra LION", ExpectedResult = true)]
        public bool BabyZebraSearch(string str)
        {
            return SafariGuide.HasBabyZebra(str);
        }

        
        [TestCase("zebra", ExpectedResult = false)]
        [TestCase("ZEBRA", ExpectedResult = true)]
        [TestCase("Lion", ExpectedResult = false)]
        [TestCase("LION ZEBRA zebra lion", ExpectedResult = true)]
        [TestCase("LION zebra LION", ExpectedResult = false)]
        public bool AdultZebraSearch(string str)
        {
            return SafariGuide.HasAdultZebra(str);
        }

        
        [TestCase("zebra", ExpectedResult = true)]
        [TestCase("ZEBRA", ExpectedResult = true)]
        [TestCase("Lion", ExpectedResult = false)]
        [TestCase("LION ZEBRA zebra lion", ExpectedResult = true)]
        [TestCase("LION zebra LION", ExpectedResult = true)]
        public bool ZebraSearch(string str)
        {
            return SafariGuide.HasZebra(str);
        }

        
        [TestCase("zebra", ExpectedResult = false)]
        [TestCase("ZEBRA", ExpectedResult = false)]
        [TestCase("Lion", ExpectedResult = false)]
        [TestCase("LION ZEBRA zebra lion", ExpectedResult = true)]
        [TestCase("zebra LION ZEBRA lion", ExpectedResult = true)]
        [TestCase("LION zebra LION", ExpectedResult = false)]
        public bool DazzleSearch(string str)
        {
            return SafariGuide.HasADazzle(str);
        }

        /*
        [TestCase("zebra", ExpectedResult = false)]
        [TestCase("Lion", ExpectedResult = false)]
        [TestCase("LION ZEBRA zebra lion", ExpectedResult = true)]
        [TestCase("zebra LION ZEBRA lion", ExpectedResult = true)]
        [TestCase("LION zebra LION", ExpectedResult = true)]
        [TestCase("LION zebra lion", ExpectedResult = true)]
        public bool PrideSearch(string str)
        {
            return SafariGuide.HasAPride(str);
        }

        [TestCase("zebra", ExpectedResult = false)]
        [TestCase("Lion", ExpectedResult = false)]
        [TestCase("LION ZEBRA zebra lion", ExpectedResult = false)]
        [TestCase("zebra LION ZEBRA lion", ExpectedResult = false)]
        [TestCase("LION zebra LION", ExpectedResult = true)]
        [TestCase("LION zebra lion", ExpectedResult = true)]
        public bool BloodSearch(string str)
        {
            return SafariGuide.ThereWillBeBlood(str);
        }

        [TestCase("zebra", ExpectedResult = true)]
        [TestCase("Lion", ExpectedResult = false)]
        [TestCase("LION ZEBRA zebra lion", ExpectedResult = false)]
        [TestCase("zebra LION ZEBRA lion", ExpectedResult = true)]
        [TestCase("LION zebra LION", ExpectedResult = false)]
        [TestCase("LION zebra lion", ExpectedResult = false)]
        public bool SafeDistanceTest(string str)
        {
            return SafariGuide.SafeDistanceToLion(str);
        }
        */
    }
}
