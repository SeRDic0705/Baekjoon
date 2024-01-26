public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        foreach(int m in arr) {
            answer+= m;
        }
        answer = answer / arr.Length;
        return answer;
    }
}