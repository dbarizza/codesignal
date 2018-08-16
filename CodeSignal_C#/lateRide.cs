/// <summary>
/// One night you go for a ride on your motorcycle. At 00:00 you start your engine, and
//  the built-in timer automatically begins counting the length of your ride, in minutes. 
//  Off you go to explore the neighborhood.
/// When you finally decide to head back, you realize there's a chance the bridges on your 
// route home are up, leaving you stranded! Unfortunately, you don't have your watch on you 
// and don't know what time it is. All you know thanks to the bike's timer is that n minutes 
// have passed since 00:00.
/// Using the bike's timer, calculate the current time. Return an answer as the sum of 
// digits that the digital timer in the format hh:mm would show.
/// </summary>
/// <param name="n">The duration of your ride, in minutes. It is guaranteed that you've been riding for less than a day (24 hours).</param>
/// <returns>The sum of the digits the digital timer would show.</returns>

int lateRide(int n) {
    int hour = n / 60;
    int minute = n - (hour * 60);

    string string_hour = hour.ToString();
    string string_minute = minute.ToString();

    hour = Convert.ToInt32(string_hour.Substring(0, 1));
    if(string_hour.Substring(1) != "")
    {
        hour = hour + Convert.ToInt32(string_hour.Substring(1));
    }

    minute = Convert.ToInt32(string_minute.Substring(0, 1));
    if(string_minute.Substring(1) != "")
    {
        minute = minute + Convert.ToInt32(string_minute.Substring(1));
    }
    return hour + minute;
}
