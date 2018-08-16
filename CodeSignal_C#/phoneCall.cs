/// <summary>
// Some phone usage rate may be described as follows:
// first minute of a call costs min1 cents,
// each minute from the 2nd up to 10th (inclusive) costs min2_10 cents
// each minute after 10th costs min11 cents.
// You have s cents on your account before the call. What is the duration of the longest call (in minutes rounded down to the nearest integer) you can have?
/// </summary>
/// <param name="min1">1 ≤ min1 ≤ 10.</param>
/// <param name="min2_10">1 ≤ min2_10 ≤ 10.</param>
/// <param name="min11">1 ≤ min11 ≤ 10.</param>
/// <param name="s">2 ≤ s ≤ 60.</param>
/// <returns>integer</returns>

int phoneCall(int min1, int min2_10, int min11, int s) {
    int minutes = 0;
    if (s >= min1)
    {
        s = s - min1;
        minutes++;

        for(int i = 0; i < 9; i++)
        {
            if(s > min2_10)
            {
                s = s - min2_10;
                minutes++;
            }
            else
                return minutes;
        }
        while (s >= min11)
        {
            s = s - min11;
            minutes++;
        }
        return minutes;
    }
    else
        return minutes;    
}
