public class Solution {
    public string IntToRoman(int num) {
        int [] intCode = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string [] code = {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
        StringBuilder sb = new StringBuilder();
        for(int i = 0 ; i<intCode.Length;i++){
            while(num>=intCode[i]){
                sb.Append(code[i]);
                num-=intCode[i];
            }
        }
        return sb.ToString();
    }
}