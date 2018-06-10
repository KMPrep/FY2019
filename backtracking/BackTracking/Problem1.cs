using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking {
    /*
    Generate all strings of n bits 
    */
    public class Problem1 {

        public static char[] charArray;

        public static void Solution(int n) {
            charArray = new char[n];
            Binary(n);
        }

        private static void Binary(int n) {
            if (n < 1) {
                Console.WriteLine(new String(charArray));
                return;
            }

            charArray[n - 1] = '0';
            Binary(n - 1);
            charArray[n - 1] = '1';
            Binary(n - 1);

        }
    }
}
