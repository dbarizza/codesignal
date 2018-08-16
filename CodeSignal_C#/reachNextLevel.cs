/// <summary>
// You are playing an RPG game. Currently your experience points (XP) total is equal to experience. To reach the next level your XP should be at least at threshold. If you kill the monster in front of you, you will gain more experience points in the amount of the reward.
// Given values experience, threshold and reward, check if you reach the next level after killing the monster.
/// </summary>
/// <param name="experience">3 ≤ experience ≤ 250</param>
/// <param name="threshold">5 ≤ threshold ≤ 300</param>
/// <param name="reward">2 ≤ reward ≤ 65</param>
/// <returns>true if you reach the next level, false otherwise.</returns>

bool reachNextLevel(int experience, int threshold, int reward) {
    if(experience + reward >= threshold)
        return true;
    else
        return
}
