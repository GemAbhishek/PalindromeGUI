namespace PalindromeGUI
{
    public class Palindrome
    {
        public static int Ispalindrome(string str)
        {

            string s, revs = "";
            s = str.ToLower();

            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
