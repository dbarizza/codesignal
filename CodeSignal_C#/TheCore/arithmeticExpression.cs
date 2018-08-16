/// <summary>
// Consider an arithmetic expression of the form a#b=c. Check whether it is possible to replace # with one of the four 
// signs: +, -, * or / to obtain a correct expression.
/// </summary>
/// <param name="a">1 ≤ a ≤ 20</param>
/// <param name="b">1 ≤ b ≤ 20</param>
/// <param name="c">0 ≤ c ≤ 20</param>
/// <returns>true if the desired replacement is possible, false otherwise.</returns>

bool arithmeticExpression(int a, int b, int c) {
    if (a + b == c || a - b == c || a * b == c)
        return true;
    else
    {
        decimal divisao = 0.0M;
        divisao = Convert.ToDecimal(a) / Convert.ToDecimal(b);
        if (divisao == c)
            return true;
        else
            return false;
    }        
}
