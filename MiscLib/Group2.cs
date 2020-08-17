using System;

namespace MiscLib {
    public class GroupTwoFunctions {
        //---- Group 2 Functions ----------
        public int CalcRectPerimeter (int length, int width) {
            return (length + width) * 2;
        }

        public bool IsTriangularNum (int num) {
            if (num < 0)
                return false;

            int sum = 0;
            for (int n = 1; sum <= num; n++) {
                sum = sum + n;
                if (sum == num)
                    return true;
            }
            return false;
        }

        public int FarenheitToCelcius (int farenheit) {
            return Math.Round ((farenheit - 32) * 5 / 9);
        }

        public bool CheckWhiteSpace (string word) {
            word.ToCharArray ();
            if (word[1] = " " && word[word.Length - 1] = " ") {
                return true;
            } else {
                return false;
            }
        }

        public string CamelString (string word) {
            word.ToCharArray ();
            for (int i = 0; i < word.Length; i++) {
                if (i % 2 == 0) {
                    word[i].toUpper ();
                } else {
                    word[i].toLower ();
                }
            }
        }

        public int CountDigits (string word) {
            for (int i; i < word.Length; i++) {
                if (Char.IsDigit (word[i])) {
                    int count = 0;
                    count = count + i;
                }
            }
        }

    }
}