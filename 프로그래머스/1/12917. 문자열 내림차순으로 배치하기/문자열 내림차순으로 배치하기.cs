using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] sol = s.ToCharArray();
        Array.Sort(sol);
        Array.Reverse(sol);
        
        answer = new String(sol);
        
        return answer;
    }
}