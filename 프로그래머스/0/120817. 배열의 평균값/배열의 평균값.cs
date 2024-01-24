using System;

public class Solution {
    public double solution(int[] numbers) {
        int sum = 0;
        foreach(int i in numbers) {
            sum += i;
        }
        
        return (double)sum/numbers.Length;
    }
}