public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int Maior = candies.Max();
        List<bool> eMaior = new List<bool>(); 
        
        for(int i = 0; i < candies.Length; i++){
           
                eMaior.Add((candies[i] + extraCandies >= Maior));
        }
        
        return eMaior;
    }
}
