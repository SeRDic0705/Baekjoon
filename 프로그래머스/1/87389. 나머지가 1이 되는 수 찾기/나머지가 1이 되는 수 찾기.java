class Solution {
    public int solution(int n) {
        int i = 1;
        while (true)
        {
            int temp = n%i;
            if (temp == 1) break;
            else i++;
        }
        return i;
    }
}