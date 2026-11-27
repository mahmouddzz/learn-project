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

            ////built in functions
            ////
            //// Console.WriteLine();
            //// toupper();
            //// ToLower();
            //// substring();

            ////--    -------------------------------------------------------------

            ////user defined functions example

            //void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to C# Programming");
            //}

            ////-------------------------------------------------------------

            ////function returning a value

            //int AddNumbers(int a, int b)
            //{
            //   int result = a + b;
            //   return result;         // return the result to the caller

            //}

            ////calling the function

            //int total = AddNumbers(10, 20);
            //Console.WriteLine(total);           //output : 30

            ////-------------------------------------------------------------

            ////Void function not returning a value

            //void PrintMessage()
            //{
            //    Console.WriteLine("Hello, World!");
            //}

            //PrintMessage();        //calling the function


            ////-------------------------------------------------------------

            //// Example for user defined function         

            //int CalculateTotal(int math , int science, int english)
            //{
            //    int total = math + science + english;
            //    return total;
            //}

            //double CalculateAverage(int Total)
            //{
            //    double total = Total / 3.0;
            //    return total;

            //}

            //void PrintResult(int total, double average)
            //{
            //    Console.WriteLine($"Total Marks: {total}");
            //    Console.WriteLine($"Average Marks: {average}");

            //    if (average>=50)
            //    {
            //        Console.WriteLine("You have passed!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You have failed!");
            //    }
            //}

            ////calling the functions

            //PrintResult(100, 60.0);



            #endregion

            #region Passing Parameters to Functions

            static void PrintStudentInfo(string name, int age)
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
            }
            //-------------------------------------------------------------
            //passing by position parameters

            PrintStudentInfo("Mahmoud", 20); /// بنبعت القيم على حسب ترتيب البراميترز في الديفينيشن

            //-------------------------------------------------------------


            //passing by named parameters

            PrintStudentInfo(name: "Ahmed", age: 25); /// بنبعت القيم على حسب اسم البراميترز في الديفينيشن

            //-------------------------------------------------------------

            //defult values for parameters

            static void PrintStudentInfoo(string name, int age = 0)  // defult value for age parameter is 0 
                                                                     //لو بعتنا سن هيتحط لو مبعتناش هيحط زيرو
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
            }

            PrintStudentInfoo("Ali");                     //output : Name: Ali , Age: 0

            PrintStudentInfoo("Ali", 30);                 //output : Name: Ali , Age: 30

            //-------------------------------------------------------------

            //passing by value .... Copy of the value is passed to the function, any changes made to the parameter inside the function will not affect the original value

            static void ChangeNumber(int number)
            {
                number = 100;           //change the value of the parameter
                Console.WriteLine(number);
            }
            
            static void main()
            {
                int num = 50;
                ChangeNumber(num);
                Console.WriteLine(num);     //output : 50
            }   
            ChangeNumber(5);             //output : 100

            //-------------------------------------------------------------

            //passing by reference .... Reference of the value is passed to the function, any changes made to the parameter inside the function will affect the original value


            static void ChangeNumberByRef(ref int number)
            {
                number = 100;           //change the value of the parameter
                Console.WriteLine(number);
            }

            static void main2()
            {
                int num = 50;
                ChangeNumberByRef(ref num);
                Console.WriteLine("num: " + num);     //output : 100
            }



            #endregion

            #region Changing The Refrence 



            #endregion

            #region Changing The Refff

            //changing the refrence in functions not refrence type

            static void ChangeArray(int[] numbers)
            {

                numbers = new int[] { 100, 200, 300 };   //change the reference of the array
                
            }

            static void main3()
            {
                int[] numbers = { 1, 2, 3 };
                ChangeArray(numbers);
                Console.WriteLine(numbers[0]);     //output : 1
            }

            //-------------------------------------------------------------

            //changing the refrence in functions with refrence type

            static void ChangeArrayByRef(ref int[] numbers)
            {
                numbers = new int[] { 100, 200, 300 };   //change the reference of the array
            }

            static void main4()
            {
                int[] numbers = { 1, 2, 3 };
                ChangeArrayByRef(ref numbers);
                Console.WriteLine(numbers[0]);     //output : 100
            }


            #endregion

            #region Out parameters

            //out parameters are used to return multiple values from a function
            //نستخدم ال out parameters لما نحب نرجع اكتر من قيمة من الفنكشن

            static void Calculate(int a, int b, out int sum, out int product)
            {
                sum = a + b;
                product = a * b;
            }

            static void main5()
            {
                int result1;
                int result2;

                Calculate(10, 20, out result1, out result2);

                Console.WriteLine(result1);
                Console.WriteLine(result2);

            }
            #endregion

            #region passing by params 

            //non params

            static void printNumbers(int[] numbers)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            // لاوم تجهز الاراي الاول قبل ما تبعتهم للفنكشن

            int[] numbers = { 1, 2, 3, 4, 5 };

            printNumbers(numbers);

            //--------------------------------------------------------------

            //use params 

            static void PrintNumbers(params int[] numbers)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            PrintNumbers(1, 2, 3, 4, 5);   //output : 1 2 3 4 5
            PrintNumbers(10, 20, 30, 40, 50);   //output : 10 20 30 40 50
            
            #endregion
        }
    }
}
