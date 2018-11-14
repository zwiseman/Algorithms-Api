using System;

namespace algorithmApi {
    public class problems {

        int[] problem;

        public problems () {
            problem = new int[2];
            problem[0] = problem1 ();
            problem[1] = problem2 (0, 1, 0);
        }

        /**
         * Problem 1: Find the sum of all the multiples of 3 or 5 below 1000.
         */
        public int problem1 () {
            int sum = 0;
            for (int i = 0; i < 1000; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }
            return sum;
        }

        /**
         * Problem 2: By considering the terms in the Fibonacci sequence whose 
         * values do not exceed four million, find the sum of the even-valued terms.
         */
        public int problem2 (int sum, int fibNext, int fibLast) {
            if (fibNext < 4000000) {
                fibNext = fibLast + fibNext;
                fibLast = fibNext - fibLast;
                if (fibNext % 2 == 0) {
                    sum += fibNext;
                }
                return problem2 (sum, fibNext, fibLast);
            }
            return sum;
        }

        public int[] getProblems () {
            return problem;
        }
    }
}