/// <summary>
// In tennis, a set is finished when one of the players wins 6 games and the other one wins less than 5, or, if both players win at least 5 games, until one of the players wins 7 games.
// Determine if it is possible for a tennis set to be finished with the score score1 : score2.
/// </summary>
/// <param name="score1">0 ≤ score1 ≤ 10</param>
/// <param name="score2">0 ≤ score2 ≤ 10</param>
/// <returns>true if score1 : score2 represents a possible score for an ended set, false otherwise.</returns>


bool tennisSet(int score1, int score2) {
    if (score1 == score2)
        return false;
    else
    {
        if ((score1 == 6 && score2 < 5) || (score1 < 5 && score2 == 6))
            return true;
        else
        {
            if ((score1 >= 5 && score2 >= 5) && (score1 == 7 || score2 == 7))
                return true;
            else 
                return false;
        }
    }
}
