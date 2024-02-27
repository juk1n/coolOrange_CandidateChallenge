using System;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
			if(s.Length <= 1) {
                return true;
            }

            if(s[0] == s[s.Length-1]) {
                return IsPalindrome(s.Substring(1, s.Length - 2));
            }
            return false;
        }
    }
}
