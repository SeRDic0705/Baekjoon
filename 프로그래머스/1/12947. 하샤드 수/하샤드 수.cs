using System.Collections.Generic;

public class Solution {
    public bool solution(int x) {
        List<int> list = new List<int>();
        foreach (char c in x.ToString())
        {
            list.Add(int.Parse(c.ToString()));
        }
        
        int result = 0;
        
        foreach (int a in list)
        {
            result += a;
        }
        if (x%result == 0) return true;
        else return false;
    }
}