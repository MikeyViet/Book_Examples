//Random number generator example from 7.6 in book
//Shifted and scaled random integers

using System;
/*
class RandomIntegers

{
    static void Main()
    {
        Random randomNumbers = new Random();       // random-number generator

        // loop 20 times
        for(int counter = 1; counter <= 20; ++counter)
        {
            // pick random integer from 1 to 6
            int face = randomNumbers.Next(1, 7);
            Console.Write($"{face} "); // display the generated value
        }

        Console.WriteLine();     
    }
}
*/

//Roll a Six-Sided Die 60,000,000 times
//7.7

/*
class RollDie
{
    static void Main()
    {
        Random randomNumbers = new Random();    // random-number generator

        int frequency1 = 0; //count of 1s rolled
        int frequency2 = 0;
        int frequency3 = 0;
        int frequency4 = 0;
        int frequency5 = 0;
        int frequency6 = 0; 

        // summarize results of 60,000,000 rolls of a die
        for(int roll = 1; roll <= 60000000; ++roll)
        {
            int face = randomNumbers.Next(1, 7);    // number from 1 to 6

            // determine roll value 1 - 6 and increment appropriate counter
            switch(face)
            {
                case 1:
                    ++frequency1;   //increment the counter
                    break;
                case 2:
                    ++frequency2;
                    break;
                case 3:
                    ++frequency3;
                    break;
                case 4:
                    ++frequency4;
                    break;
                case 5:
                    ++frequency5;
                    break;
                case 6:
                    ++frequency6;
                    break;
            }
        }

        Console.WriteLine("Face\tFrequency");   //output the headers
        Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
        Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
        Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");
    }
}
*/

// 7.20 Reference, Output and Value Parameters

class ReferenceAndOutputParameters
{
    // call methods with reference, ouput and value parameters
    static void Main()
    {
        int y = 5;  // initialize y to 5
        int z;      // declares z, but does not initialize it

        // display original values of y and z
        Console.WriteLine($"Original value of y: {y}");
        Console.WriteLine("Original value of z: uninitialized\n");

        // pass y and z by reference
        SquareRef(ref y);   // must use keyword ref
        SquareOut(out z);   // must use keyword out

        // display values of y and z after they're modified by
        // methods SquareRef and SquareOut, respectively
        Console.WriteLine($"Value of y after SquareRef: {y}");
        Console.WriteLine($"Value of z after SquareOut: {z}\n");

        // pass y and z by value
        Square(y);
        Square(z);

        // display values of y and z after they're passaed to method Square
        // demonstrate that arguments passed by value are not modified
        Console.WriteLine($"Value of y after Square : {y}");
        Console.WriteLine($"Value of z after Square : {z}");
    }

    // uses reference parameter x to modify caller's variable
    static void SquareRef(ref int x)
    {
        x = x * x;  // squares value of the caller's variable
    }

    // uses output parameter x to assign a value
    // to an uninitialized variable
    static void SquareOut(out int x)
    {
        x = 6;      // assigns a value to caller's variable
        x = x * x;  // squares value of caller's variable
    }

    // parameter x receives a copy of the value passed as an argument,
    //  so this method cannot modify the caller's variable
    static void Square(int x)
    {
        x = x * x;
    }

}


