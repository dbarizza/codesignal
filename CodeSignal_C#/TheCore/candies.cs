/// <summary>
// n children have got m pieces of candy. They want to eat as much candy as they can, 
// but each child must eat exactly the same amount of candy as any other child. 
// Determine how many pieces of candy will be eaten by all the children together. 
// Individual pieces of candy cannot be split.
/// </summary>
/// <param name="n">Guaranteed constraints:1 ≤ n ≤ 10.</param>
/// <param name="m">Guaranteed constraints:2 ≤ m ≤ 100.</param>
/// <returns>The total number of pieces of candy the children will eat provided they eat as much as they can and all children eat the same amount. </returns>

int candies(int n, int m) {
    return (m / n) * n;
    
}
