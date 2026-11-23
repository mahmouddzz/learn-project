using System.Text;

namespace Demo_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region convert the name from lower to upper
            //Console.WriteLine("Enter Your Name");
            //string myName = Console.ReadLine();

            //string newName = myName.ToUpper();

            //Console.WriteLine(newName);
            #endregion

            #region Initialize a Null or Empty String

            //string str01 = null;
            //string str02 = string.Empty;
            //string str03 = "";
            //string str04 = default;

            //Console.WriteLine(str01);
            //Console.WriteLine(str02);
            //Console.WriteLine(str03);
            //Console.WriteLine(str04);
            #endregion

            #region ReferenceEquals()
            // ReferenceEquals() method is used to check whether two object references refer to the same object or not.

            //string str1 = new string("Hello".ToCharArray());
            //string str2 = new string("Hello".ToCharArray());

            //Console.WriteLine(object.ReferenceEquals(str1, str2));         // false 

            #endregion

            #region Verbatim Strings

            //string path = "C:\\Users\\Public\\ocuments\\Report.txt"; // Normal string literal
            //string verbatimPath = @"C:\Users\Public\Documents\Report.txt"; // Verbatim string literal

            //Console.WriteLine(path);
            //Console.WriteLine(verbatimPath);


            #endregion

            #region  Path.Combine()

            //string folderPath = @"C:\Users\Public\Documents";
            //string fileName = "Report.txt";

            //string fullPath = Path.Combine(folderPath, fileName);

            //Console.WriteLine(fullPath);   //output: C:\Users\Public\Documents\Report.txt

            #endregion

            #region StringBuilder

            //StringBuilder sb = new StringBuilder("Hello");

            //sb.Append("Name: ");
            //sb.Append("Mahmoud");

            //sb.Append(" Age: ");
            //sb.Append(22);

            //sb.Append(" Grade: ");
            //sb.Append(95.5);

            //Console.WriteLine(sb); //output: HelloName: Mahmoud Age: 22 Grade: 95.5 


            //sb.AppendLine("Hello");
            //sb.AppendLine("mahmoud");
            //sb.AppendLine("ibrahim");
            //sb.AppendLine("Hello");
            //sb.AppendLine("Hello");

            //Console.WriteLine(sb);     //output: HelloName: Mahmoud Age: 22 Grade: 95.5 
                                       //Hello
                                       //mahmoud
                                       //ibrahim
                                       //Hello
                                       //Hello



            #endregion

            #region String Formatting 

            //string concatenation 

            //string name = "Mahmoud"; 

            //string message = "Hello " + name + ", Welcome to the C# World!"; //concatenation

            //Console.WriteLine(message);  //output: Hello Mahmoud, Welcome to the C# World!


            ////string interpolation

            //string name2 = "Mahmoud";

            //string message2 = $"Hello {name2}, Welcome to the C# World!"; //interpolation

            //Console.WriteLine(message2); //output: Hello Mahmoud, Welcome to the C# World!

            ////string.Format()

            //Console.WriteLine(string.Format("Hello {0}, Welcome to the C# World!", name2)); //string.Format() output: Hello Mahmoud, Welcome to the C# World!

            #endregion
        }
    }
}
