public class Solution {
    public int[] solution(long n) {
        string s = n.ToString();
        int[] answer = new int[s.Length];
        
        for(int i = 0; i < s.Length; i++)
        {
            answer[i] = int.Parse(s[s.Length - i - 1].ToString());
        }
        return answer;

    }
}