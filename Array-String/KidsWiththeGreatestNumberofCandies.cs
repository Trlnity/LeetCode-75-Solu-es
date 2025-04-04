public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int Maior = candies.Max();
        List<bool> eMaior = new List<bool>(); 
        
        for(int i = 0; i < candies.Length; i++){
            if(candies[i] + extraCandies < Maior){
                eMaior.Add(false);
            } else{
                eMaior.Add(true);
            }
        }
        return eMaior;
    }
}
