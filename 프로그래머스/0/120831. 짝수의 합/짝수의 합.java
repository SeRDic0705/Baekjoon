class Solution {
    public int solution(int n) {
        int sum = 0;
        int i = 2;
        while(i <= n) {
            sum += i;
            i += 2;
        }
        return sum;
    }
}