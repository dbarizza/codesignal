/// <summary>
// You are given a two-digit integer n. Return the sum of its digits.
/// </summary>
/// <param name="n">Guaranteed constraints:10 ≤ n ≤ 99.</param>
/// <returns>The sum of the first and second digits of the input number.</returns>

int addTwoDigits(int n) {
    string nString = n.ToString();
    return Convert.ToInt32(nString.Substring(0,1)) + 
            Convert.ToInt32(nString.Substring(1,1));
}