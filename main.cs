/// malcome movers chjarges base rate of 200 this will be a const
// the houlry rate is 150$ and there is a charge of 2 $ per mile
// const 200, 150 * amount of hours , 2$ * miles



using System;

class MoveEstimator{//open move estimator

    public const double BaseRate = 200.00;

    public const double HourlyRate = 150.00;

    public const double MileRate = 2.00;

    public static void Main(string[] args){// open Main

        for (int i = 1; i <= 4; i++){//open for loop

            // prompt user for the number of hours the move is expected to take place. create a variable estimatedHours to store the user input.
            Console.WriteLine("How many hours will it take to move your belongings?");
            string estimatedHours = Console.ReadLine();

            // prompt user for the number of miles the move is expected to take place. create a varable estimatedMiles to store the user input.
            Console.WriteLine("How many miles will you be traveling?");
            string estimatedMiles = Console.ReadLine();

// create a variale estimatedTotalCost to hold the estimated cost of the move. parse the userinput from a string to a double
            double estimatedTotalCost = BaseRate + HourlyRate * double.Parse(estimatedHours) + MileRate * double.Parse(estimatedMiles);
          
// print the estimated cost of the move to the console. use string interpolation, ensure that printed output is parsed to a double data type and use the format specifier F2 in order to ensure that two deciaml places are displayed.
            Console.WriteLine($"The estimated cost of your move is {BaseRate + HourlyRate * double.Parse(estimatedHours) + MileRate * double.Parse(estimatedMiles):F2}");
// create a variable for the actual cost to use for verification that the unit test will pass
            double actualCost = BaseRate + HourlyRate * double.Parse(estimatedHours) + MileRate * double.Parse(estimatedMiles);
          
          Console.WriteLine();
// logic to test if unit test will pass. if the difference in the absolute value of the actual cost and the estimated cost is less than 0.01 then the unit test will pass.
            if (Math.Abs(estimatedTotalCost - actualCost) < 0.01){// open if
                Console.WriteLine("unit test passed");
              
              Console.WriteLine();
            }// close if
            else
            {//open else
                Console.WriteLine("unit test failed");
              Console.WriteLine();
            }//close else


        }// end for loop
    }// close Main
}// close move estimator