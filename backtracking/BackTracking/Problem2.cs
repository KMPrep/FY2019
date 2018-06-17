using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking {
    public class Problem2 {

        public static void Solution(char[] set, int k) {

            if(set == null || set.Length == 0 || k == 0) {
                Console.WriteLine("Either Invalid Array or K equals 0");
                return;
            }

            int arrayLength = set.Length;
            printAllKAry(set, "", arrayLength, k);
        }

        private static void printAllKAry(char[] set, string prefix, int arrayLength, int k) {
            
            if(k == 0) {
                Console.WriteLine(prefix);
                return;
            }

            for(int i = 0; i < arrayLength; ++i) {

                String newPrefix = prefix + set[i];
                printAllKAry(set, newPrefix, arrayLength, k - 1);
            }
        }
    }
}
