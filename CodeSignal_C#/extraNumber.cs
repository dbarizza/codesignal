/// <summary>
/// You're given three integers, a, b and c. It is guaranteed that two of these integers 
/// are equal to each other. What is the value of the third integer?
/// </summary>
/// <param name="a">1 ≤ a ≤ 10^9.</param>
/// <param name="b">1 ≤ b ≤ 10^9.</param>
/// <param name="c">1 ≤ c ≤ 10^9.</param>
/// <returns>integer</returns>

int extraNumber(int a, int b, int c) {
    if (a != b && a == c)
    {
        return b;
    }
    else
    {
        if(a == b)
            return c;
        else
            return a;
    }
}
