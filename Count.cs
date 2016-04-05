using System.IO;
using System;

/// <summary>
///  Count: Is the class that will be used for containing methods to counting sum square difference
/// </summary> 

class Count
{
    int sum = 0;
    int square = 0;
    int result;
    

    /// <summary>
    ///  public SumOfSquares: Is method that counts sum of square
    /// </summary> 
    
    public void SumOfSquares(int sumNumber)
    {
        for(int i = 1; i <= sumNumber; i++)
        {
            sum = sum + (i*i);
            Console.WriteLine("Sum: {0}", sum);
        }
    }
    
    public void SquareOfSum(int sumNumber)
    {
        for(int i = 1; i <= sumNumber; i++)
        {
            square = square + i;
            Console.WriteLine("Square: {0}", square);
        }
        
        square = square*square;
        Console.WriteLine("Square of sum: {0}", square);
    }
    
    public void SumSquareDifference()
    {
        result =  square - sum;
        Console.WriteLine("Sum square difference: {0}", result);
    }

}