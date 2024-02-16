public class Solution {
    public string solution(string[] seoul) {
        int i = 0;
        foreach (string s in seoul)
        {
            if (s == "Kim") break;
            else i++;
        }
        return new string($"김서방은 {i}에 있다");
    }
}