/// <summary>
// Given a divisor and a bound, find the largest integer N such that:
// N is divisible by divisor.
// N is less than or equal to bound.
// N is greater than 0.
// It is guaranteed that such a number exists.
/// </summary>
/// <param name="divisor"> 2 ≤ divisor ≤ 10.</param>
/// <param name="bound">5 ≤ bound ≤ 100.</param>
/// <returns>The largest integer not greater than bound that is divisible by divisor.</returns>

int maxMultiple(int divisor, int bound) {
    int i = 1;
    while (divisor * i < bound)
    {
        i++;
    }
    if (divisor * i == bound)
        return divisor * i;
    else
        return divisor * (i-1);    
}


