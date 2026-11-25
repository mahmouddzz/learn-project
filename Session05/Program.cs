namespace Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1D Array

            //int[] numbers;
            ////Array with size 4
            //numbers = new int[4] { 10, 20, 30, 40 };
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            ////-----------------------------------------------------------------

            ////Array with out size, the size will be determined by the number of elements in the array
            //int[] numbers2 = { 10, 20, 30, 40 };
            //Console.WriteLine(numbers2[0]);
            //Console.WriteLine(numbers2[1]);
            //Console.WriteLine(numbers2[2]);
            //Console.WriteLine(numbers2[3]);

            //numbers2[0] = 100;        //change the value of the first element in the array

            //Console.WriteLine($"Length of numbers2: {numbers2.Length}");       //output : 4       // count of elements in the array
            //Console.WriteLine($"Last element is at index: {numbers2.Length - 1}");     //output : 3    // index of the last element in the array



            #endregion

            #region 2D Array

            ////2D Array with size 2x3
            //int[,] numbers3 = new int[2, 3] 
            //{ 

            //{ 1, 2, 3 }, { 4, 5, 6 } 

            //};


            //Console.WriteLine(numbers3[0, 0]);  //output : 1
            //Console.WriteLine(numbers3[0, 1]);  //output : 2
            //Console.WriteLine(numbers3[0, 2]);  //output : 3
            //Console.WriteLine(numbers3[1, 0]);  //output : 4
            //Console.WriteLine(numbers3[1, 1]);  //output : 5
            //Console.WriteLine(numbers3[1, 2]);  //output : 6

            //Console.WriteLine(numbers3.GetLength(0));  //output : 2
            //Console.WriteLine(numbers3.GetLength(1));  //output : 3

            //Console.WriteLine(numbers3.Length);  //output : 6

            ////--------------------------------------------------------------

            ////Loop through the 2D array and print all elements
            //for (int i = 0; i < numbers3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers3.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"numbers3[{i},{j}] = {numbers3[i, j]}");
            //    }
            //}


            #endregion

            #region User Defined Functions

            //built in functions
            //
            // Console.WriteLine();
            // toupper();
            // ToLower();
            // substring();

            //--    -------------------------------------------------------------

            //user defined functions example

            void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to C# Programming");
            }

            //-------------------------------------------------------------

            //function returning a value
            
            int AddNumbers(int a, int b)
            {
               int result = a + b;
               return result;         // return the result to the caller

            }

            //calling the function

            int total = AddNumbers(10, 20);
            Console.WriteLine(total);           //output : 30

            //-------------------------------------------------------------

            //Void function not returning a value

            void PrintMessage()
            {
                Console.WriteLine("Hello, World!");
            }

            PrintMessage();        //calling the function


            //-------------------------------------------------------------

            // Example for user defined function         

            int CalculateTotal(int math , int science, int english)
            {
                int total = math + science + english;
                return total;
            }

            double CalculateAverage(int Total)
            {
                double total = Total / 3.0;
                return total;

            }

            void PrintResult(int total, double average)
            {
                Console.WriteLine($"Total Marks: {total}");
                Console.WriteLine($"Average Marks: {average}");

                if (average>=50)
                {
                    Console.WriteLine("You have passed!");
                }
                else
                {
                    Console.WriteLine("You have failed!");
                }
            }

            //calling the functions

            PrintResult(100, 60.0);



            #endregion
        }
    }
}
