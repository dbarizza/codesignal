/// <summary>
// Given n and firstNumber, find the number which is written in the radially opposite
// position to firstNumber.
/// </summary>
/// <param name="n">A positive even integer.Guaranteed constraints:</param>
/// <param name="firstNumber">Guaranteed constraints:0 ≤ firstNumber ≤ n - 1.</param>
/// <returns>integer</returns>

int circleOfNumbers(int n, int firstNumber) {
    int distancia  = n / 2;
    if (firstNumber > distancia)
        return firstNumber - distancia;
    else
        return firstNumber + distancia;
}
