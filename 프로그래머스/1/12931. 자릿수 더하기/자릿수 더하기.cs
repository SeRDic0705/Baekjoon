using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        foreach(char c in n.ToString()) {
            answer += int.Parse(c.ToString());
        }
        return answer;
    }
}