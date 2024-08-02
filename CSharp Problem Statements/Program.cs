namespace CSharp_Problem_Statements
{
    class Program
    {
        public static int Inline(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
        static void PrintMinimumValue(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum Value:"+ min);
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Printing the Given Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static bool StringPalindrome(string str)
        {
            char[] C = str.ToCharArray();
            Array.Reverse(C);
            return new string(C).Equals(str);
        }
        static bool ChkArray(int[]arr,int n)
        {
            return arr.Contains(n);
        }
        static string ChkPath (string Filename)
        {
            return Path.GetFileName(Filename);
        }
        static string ChkPath2(string Filename)
        {
            return Filename.Split('/').Last();
        }
        static string removStringElements(string str)
        {
            return str.Length > 2 ? str.Substring(1, str.Length - 2) : str;
        }
        static bool Array_Average_Value_WholeNumber_or_not(int[] arr)
        {
            return arr.Average() % 1 == 0;
        }
        static string OrderBy (string str)
        {
            return new string (str.OrderBy(x => x).ToArray());
        }
        static string String_Length_Odd_or_Even (string word)
        {
            int length = word.Length;

            if(length % 2 == 0)
            {
                return "Even Length";
            }
            else
            {
                return "Odd Length";
            }
        }
        static bool EndsWith (string str)
        {
            return str.EndsWith("s");
        }
        static int Sum_of_Squares_in_Array(int[] arr)
        {
            return arr.Sum(x => x * x);
        }
        static void Main(string[] args)
        {




            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(Sum_of_Squares_in_Array(nums));


            //Console.WriteLine(EndsWith("Books"));



            //Console.WriteLine(String_Length_Odd_or_Even("JavaScript"));
            
            
            
            
            //Console.WriteLine(OrderBy("PHP"));




            //Check the average value of the elements of a given array of numbers is a whole number or not
            //int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
            //Console.WriteLine(Array_Average_Value_WholeNumber_or_not(nums));





            //Elements Removing from The given String
            //Console.WriteLine("After Removing First and Last Elements:" + removStringElements("Problem"));





            //string s1 = "The quick brown fox jumps over the lazy dog";
            //string s2 = "fox";
            //bool b = s1.Contains(s2);

            //if (b)
            //{
            //    Console.WriteLine("\"'{0}' is in the string '{1}': {2}", s2, s1, b);
            //}
            //else
            //{
            //    Console.WriteLine("Not in the String");
            //}



            //string firstName, middleName, lastName, name;

            //Console.Write("Enter your first name: ");
            //firstName = Convert.ToString(Co)nsole.ReadLine());

            //Console.Write("Enter your middle name or initial: ");
            //middleName = Convert.ToString(Console.ReadLine());

            //Console.Write("Enter Your Last name:");
            //lastName = Convert.ToString(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("You entered '{0}', '{1}', and '{2}'.", 
            //            firstName, middleName, lastName);

            //name = ((firstName.Trim() + " " + middleName.Trim()).Trim() + " " + lastName.Trim()).Trim();

            //Console.WriteLine("The result is " + name + ".");










            //finding the Largest and Lowest Integer using Math Function
            //Console.WriteLine("Enter the first Integer");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Integer");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Thrid Integer");
            //int z = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\tLargest Integer:" + Math.Max(x, Math.Max(y, z)));
            //Console.WriteLine("\tLowest Integer:" + Math.Min(x, Math.Min(y, z)));




            //string file_path;
            //file_path = "c:/csharp/ex/test.cpp";
            //Console.WriteLine(ChkPath(file_path));




            //int[] nums = { 1, 3, 5, 7, 9 };
            //int x = 6;
            //Console.WriteLine(ChkArray(nums, x));




            //Console.WriteLine(StringPalindrome("vvvv"));



            //Array Printing
            //int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            //int[] arr2 = { 12, 23, 44, 11, 54 };

            //PrintMinimumValue(arr1);
            //PrintMinimumValue(arr2);
            //PrintArray(arr1);
            //PrintArray(arr2);



            //Check if the first element or the last element of the two arrays ( length 1 or more) are equal.
            //int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9, 5 };

            //int[] nums2 = { 5, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            //Console.WriteLine(nums1[0].Equals(nums2[0]) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])) && (nums1.Length>=1 && nums2.Length>=1));
            //Console.ReadKey();


            //Checks if the first element and the last element of an array of integers are equal. The array length is greater than 1.
            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 , 1};
            //Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));


            //Count the repeated number in given array
            //Console.WriteLine("Input Integer");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            //Console.WriteLine(nums.Count(n => n == x));



            //Find the Nearest value of constant integer Of Given Input's
            //Console.WriteLine("Enter first integer");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second integer");
            //int y = Convert.ToInt32(Console.ReadLine());

            //int n = 20;

            //var val1 = Math.Abs(x - n);
            //var val2 = Math.Abs(y - n);

            //Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
            //Console.ReadKey();



            //swap two numbers without third variable
            //int num1 = 0, num2 = 0;

            //Console.WriteLine("Enter the number-1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number-2");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Before Swapping \ta={num1} \tb={num2}", num1, num2);

            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;

            //Console.WriteLine($"After Swapping \ta={num1} \tb={num2}", num1, num2);




            // Method to calculate the sum of two integers; if they are equal, the sum is tripled
            //int x = 0, y = 0;
            //Console.WriteLine("Enter First Integer");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Integer");
            //y = int.Parse(Console.ReadLine());
            //Console.WriteLine(Inline(x, y));




            //int num1 = 0;
            //int num2 = 0;

            //Console.WriteLine("Type a number, and then press Enter");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Type a number, and then press enter");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Choose an Option from the following list:");
            //Console.WriteLine("\ta - Add");
            //Console.WriteLine("\tb - Subtract");
            //Console.WriteLine("\tc - Multiply");
            //Console.WriteLine("\td - Divide");
            //Console.WriteLine("Your Option?");

            //switch(Console.ReadLine())
            //{
            //    case "a":
            //        Console.WriteLine($"Your Result; {num1} + {num2} =" + (num1 + num2));
            //        break;
            //    case "b":
            //        Console.WriteLine($"Your Result; {num1} - {num2} =" + (num1 - num2));
            //        break;
            //    case "c":
            //        Console.WriteLine($"Your Result; {num1} * {num2} =" + (num1 * num2));
            //        break;
            //    case "d":
            //        Console.WriteLine($"Your Result; {num1} / {num2} =" + (num1 / num2));
            //        break;
            //}
            //Console.ReadKey();




            //Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line");
            //for (int i = 1; i < (99 + 1); i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}