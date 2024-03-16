public class Solution {
    public int Reverse(int x) {
        
        bool isNegative = x < 0;
        int a;

        string temp = x.ToString();

        char[] numberList = temp.ToCharArray();

        Array.Reverse(numberList);

        string ret_val = string.Join("", numberList);

        if (isNegative) {
            ret_val = ret_val.Replace("-", "");

            ret_val = "-" + ret_val;
        }

        if (Int32.TryParse(ret_val, out a)) {
            return a;
        } else {
            Console.WriteLine(ret_val);
            return 0;
        }
    }
}