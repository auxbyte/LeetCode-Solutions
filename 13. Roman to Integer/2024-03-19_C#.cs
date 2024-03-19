public class Solution {
    public int RomanToInt(string s) {
        int runningTotal = 0;
        
        // searchRange - How many chars in string to grab
        int searchRange;


        Dictionary <string, int> numeralBook = new Dictionary <string,int>();
        numeralBook.Add("I",    1);
        numeralBook.Add("V",    5);
        numeralBook.Add("X",   10);
        numeralBook.Add("L",   50);
        numeralBook.Add("C",  100);
        numeralBook.Add("D",  500);
        numeralBook.Add("M", 1000);
        numeralBook.Add("IV",   4);
        numeralBook.Add("IX",   9);
        numeralBook.Add("XL",  40);
        numeralBook.Add("XC",  90);
        numeralBook.Add("CD", 400);
        numeralBook.Add("CM", 900);

        for (int index = 0; index < s.Length; index++) {
            searchRange = 1;
            if (index + 1 < s.Length) {
                if (numeralBook.ContainsKey(s.Substring(index, 2))) {
                    searchRange = 2;
                } else {
                    searchRange = 1;
                }
            }
                runningTotal += numeralBook[s.Substring(index, searchRange)];

                // adjust the index based on searchRange (expected "-1 + 1 = 0" or "-1 + 2 = 0")
                index += (-1 + searchRange);           
        }

        return runningTotal;

    }
}