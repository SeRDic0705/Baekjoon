using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(long n) {
        List<char> list = new List<char>();
        foreach(char c in n.ToString())
        {
            list.Add(c);
        }
        return long.Parse(string.Join("", list.OrderByDescending(i => i).ToList()));
    }
}