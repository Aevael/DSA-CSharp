using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.PalindromeSolution
{
    internal class PalindromeSolution
    {
        public bool IsPalindrome(int x)
            {
                var numberString = x.ToString();
                var numberArray = numberString.ToCharArray();
                Array.Reverse(numberArray);
                var reverseString = new string(numberArray);
                return numberString.Equals(reverseString);
            }
    }
}
