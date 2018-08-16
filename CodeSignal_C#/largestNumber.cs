/// <summary>
// Given an integer n, return the largest number that contains exactly n digits.
/// </summary>
/// <param name="n">Guaranteed constraints:1 ≤ n ≤ 9.</param>
/// <returns>The largest integer of length n.</returns>

int largestNumber(int n) {
    int i = 0;
    string stringlargestNumber = "";
    
    while(i < n){
        stringlargestNumber += "9";
        i++;
    }    
    return Convert.ToInt32(stringlargestNumber);
}
