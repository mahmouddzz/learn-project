namespace Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1D Array

            int[] numbers;
            //Array with size 4
            numbers = new int[4] { 10, 20, 30, 40 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            //-----------------------------------------------------------------

            //Array with out size, the size will be determined by the number of elements in the array
            int[] numbers2 = { 10, 20, 30, 40 };
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[1]);
            Console.WriteLine(numbers2[2]);
            Console.WriteLine(numbers2[3]);

            numbers2[0] = 100;        //change the value of the first element in the array

            Console.WriteLine($"Length of numbers2: {numbers2.Length}");       //output : 4       // count of elements in the array
            Console.WriteLine($"Last element is at index: {numbers2.Length - 1}");     //output : 3    // index of the last element in the array



            #endregion
        }
    }
}
