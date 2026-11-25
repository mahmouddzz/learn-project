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

            #region Nullable Types 

            //string name = null;                    //string is a reference type, so it can be null

            //int age = null;  //Error              //int is a value type, so it cannot be null

            //int? age2 = null;                   //int? is a nullable value type, so it can be null

            //------------------------------------------------------------------------------

            //HasValue Property

            //int? age3 = 25;
            //Console.WriteLine(age3.HasValue);          //output: True

            //int? age4 = null;
            //Console.WriteLine(age4.HasValue);        //output: False


            //---------------------------------------------------------------------------------

            //Value Property

            //int? age5 = 30;

            // Console.WriteLine(age5.Value);              //output: 30



            // int? age = null;

            // Console.WriteLine(age.Value);               // Exception

            //---------------------------------------------------------------------------------

            //GetValueOrDefault()

            //  int? age = 25;

            //Console.WriteLine(age.GetValueOrDefault());           //output: 25



            // int? age2 = null;

            //Console.WriteLine(age2.GetValueOrDefault());           //output: 0

            //---------------------------------------------------------------------------------




            #endregion

            #region Null Operators

            ///null conditional operator (?.)

            // string ? name = "mahmoud";

            // name?.ToUpper();                    //if name is not null, it will convert it to upper case, otherwise it will return null

            //Console.WriteLine(name);            //output: mahmoud


            //-----------------------------------------------------------------------------------------



            //null coalescing operator (??)

            //string? name = null;

            //Console.WriteLine(name ?? "Name is null");        //if name is null, it will return "Name is null", otherwise it will return the value of name


            //-----------------------------------------------------------------------------------------


            //null forgiving operator (??=)

           // string? name = "mahmoud";

           /// string confermedName = name!;

           // Console.WriteLine(confermedName);            //output: mahmoud


            #endregion


        }
    }
}
