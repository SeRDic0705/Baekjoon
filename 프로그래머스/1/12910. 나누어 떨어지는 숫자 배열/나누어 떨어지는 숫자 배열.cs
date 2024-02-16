using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> list = new List<int>();
        
        foreach (int n in arr)
        {
            if(n % divisor == 0) list.Add(n);
        }
        if (list.Count == 0) return new int[]{-1};
        else list.Sort();
        
        return list.ToArray();
    }
}