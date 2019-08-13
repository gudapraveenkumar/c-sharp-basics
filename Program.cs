using System;
using HelloWorld.Math;
using System.Collections.Generic;

namespace HelloWorld
{
    // Enums - A set of name/value pairs (constants). since it is a new type it should be defined at the namespace level
    public enum ShippingMethod
    {
        // If Values are not set then default is 0 and it goes on increasing
        RegularAirMail = 1, // If Value not set then default will be = 0
        RegisteredAirMail = 2, // If Value not set then default will be  = 1
        Express = 3 // If Value not set then default will be  = 2
    }

    public class Person1
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Type Conversions
             */
            byte b = 1;
            int i = b; // Implicit Type conversion
            Console.WriteLine(i);

            int a = 5;
            byte c = (byte)a; // Explicit Type Conversion
            Console.WriteLine(c);

            int d = 500;
            byte e = (byte)d;
            Console.WriteLine(e); // Outputs 244 since it is the maximum value

            var number = "1234";
            int f = Convert.ToInt32(number);
            Console.WriteLine(f);

            string fasak = "debba";
            fasak = "abba";
            Console.WriteLine(fasak);

            try
            {
                var g = "1234";
                int h = Convert.ToByte(g);
                Console.WriteLine(h);
            }
            catch
            {
                Console.WriteLine("Cannot convert");
            };

            var obj = new Person();
            obj.firstName = "John";
            obj.lastName = "doe";
            obj.Introduce();

            Calculator calculate = new Calculator();
            Console.WriteLine(calculate.Add(5, 2));

            // Non Primitive data types
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]); // No value is initialized Outputs 0 because it is the default value of integer datatype
            Console.WriteLine(numbers[2]); // Outputs 0


            var flags = new Boolean[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); // When no values is initialized it will Output False since it is the default value

            var names = new string[3] { "Praveen", "kumar", "guda" }; // We can also intiliase in this way 

            // Escape characters
            /**
             *  \n      New Line
             *  \t      Tab
             *  \\      Backslash
             *  \'      Single Quotation Mark
             *  \"      Double Quotation Mark
             */

            var firstName = "Praveen Kumar";
            var lastName = "Guda";

            string fullName = firstName + " " + lastName;

            var alternateway = string.Format("My name is {0} {1}", firstName, lastName);

            var names1 = new string[3] { "john", "jack", "Mary" };
            var formatedNames = string.Join(",", names1);
            Console.WriteLine(formatedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\\folder3";
            Console.WriteLine(text);

            // Verbatim string 
            var verbatimString = @"Hi John
Look into the following paths
c:\folder1\folder2\folder3";
            Console.WriteLine(verbatimString);

            // Using Shippingmethod enum
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // Converting enum to an interger by casting

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // Converting interger to an enum by casting

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethodval = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); // Converting string to an enum by casting

            // There are two main types in c#
            // Structures       Primitive types (int, char, float, bool ...), Custom structures ----> Value Types
            // Classes          Arrays, Strings, Custom classes -------> Reference Type
            // Value types and Reference types

            // value types are primitive datatypes ----> Stored in Stack
            var j = 10;
            var k = j;
            k++;
            Console.WriteLine(string.Format("j : {0}, k : {1}", j, k)); // Outputs j : 10, k : 11 because values are copied

            // Reference types are non-primitive datatypes -----> Stored in Heap
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1; // Memory reference is copied not actuall value
            array2[0] = 55;
            Console.WriteLine(string.Format("array1 : {0}, array2 : {1}", array1[0], array2[0]));
            // The value of first element will be changed for both the arrays because they are non primitive types which are referenced.


            var debbaNumber = 1;
            Increment(debbaNumber);
            Console.WriteLine(debbaNumber); // Outputs 1 because here since it is value type so a copy will be sent

            var person = new Person1() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // outputs 30 becuase it is reference type and value is accessed from the memory


            // Enums
            var season = Season.Autumn;

            switch (season)
            {   
                // One outcome for both the conditions
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("It is summer and autumn");
                    break;

                case Season.Winter:
                    Console.WriteLine("It is winter");
                    break;

                default:
                    Console.WriteLine("I dont know");
                    break;

            }

            // Iteration Systems- ------------------------------------------------------
            // For, Foeach, While and Do-while
            // Forloop, normal as we do
            for(var temp = 0; temp <= 10; temp++)
            {
                if(temp % 2 == 0)
                {
                    Console.WriteLine(temp);
                }
            }
            // Foreach is only for inumerable like arrays, and strings
            var randomName = "John Doe";
            foreach(var character in randomName){
                Console.WriteLine(character);
            }

            var randomNumbers = new int[] { 1, 2, 3, 4, 5 };
            foreach(var num in randomNumbers)
            {
                Console.WriteLine(num);
            }

            // While loop use it when we dont know the number of iterations
            // break causes any loop to terminate 
            // continue causes any loop to execute next iteration
            while (true)
            {
                Console.WriteLine("Type your name:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("My name is :" + input);
                    continue;
                }
                    break;
            }

            // Random Numbers ---------------------------------------
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
           
            for (var dd = 0; dd < passwordLength; dd++)
                buffer[i] = (char)('a' + random.Next(0, 26)); // didnt worked but need to see

            Console.WriteLine(buffer);
            var password = new string(buffer);
            Console.Write(password);


            // Arrays have fixed size--------------------------------- 
            // Jagged Array -> 
            var jaggedArray = new int[3][];
            jaggedArray[0] = new int[] {1,2,3,4};
            jaggedArray[1] = new int[] { 1,2};
            jaggedArray[2] = new int[] { 2,5,8};



            var numbersArray = new[] { 2, 5, 6, 4, 8 }; //Initializing array with object initialization syntax;

            // Length - returns the length of the array
            Console.WriteLine("Length: " + numbersArray.Length);

            // IndexOf() - returns index of the element
            var indexresult = Array.IndexOf(numbersArray, 5);
            Console.WriteLine("index = " + indexresult);

            // Clear() - clear the items from starting index and no of elements to be deleted
            // Clearing the items in array of objects means making them null
            // Clearing the items in array of booleans means making them false
            Array.Clear(numbersArray, 0, 2);
            Console.WriteLine("Elemtns in array after clearing");
            foreach(var item in numbersArray)
                Console.WriteLine(item);
            
            // Copy() - copies elements from one array to another 
            var anotherArray = new int[3];
            Array.Copy(numbersArray, anotherArray, 3);
            Console.WriteLine("Array after copying");
            foreach (var copiedItem in anotherArray) 
                Console.WriteLine(copiedItem);

            // Sort() - sort elements in the array
            Array.Sort(numbersArray);
            Console.WriteLine("Elements after sorting");
            foreach(var sortedelements in numbersArray)
                Console.WriteLine(sortedelements);

            // Reverse()
            Array.Reverse(numbersArray);
            Console.WriteLine("Elements after Reverse");
            foreach (var revElement in numbersArray)
                Console.WriteLine(revElement);

            // Lists dynamic size -----------------------------------
            
            var numberList = new List<int>() {1,2,3,4,5,6,5}; // Initializing list with object initialization syntax
            numberList.Add(7); // Add one element to the list just like push
            numberList.AddRange(new int[3] { 8, 9, 10 }); // Add more than one element

            foreach (var listItem in numberList)
                Console.WriteLine(listItem);

            Console.WriteLine("Index of 5 " + numberList.IndexOf(5));
            Console.WriteLine("Last Index of 5 " + numberList.LastIndexOf(5));
            Console.WriteLine("Count " + numberList.Count);

            numberList.Remove(8);
            Console.WriteLine("List after removing  8");

            foreach (var listItem in numberList)
                Console.WriteLine(listItem);

            for(var adf = 0; adf < numberList.Count; adf++)
            {
                if (numberList[adf] == 1)
                    numberList.Remove(numbers[adf]);
            }

            numberList.Clear();

            Console.WriteLine("List count after clearing = " + numberList.Count);

            // Date  -------------------------------------------
            var dateTime = new DateTime(2015, 1, 25);
            var currentDateTime = DateTime.Now;
            var todaysDate = DateTime.Today;
            Console.WriteLine("Hour: " + currentDateTime.Hour);
            Console.WriteLine("Minute: " + currentDateTime.Minute);

            // to change the datetime object
            var tomorrow = currentDateTime.AddDays(1);
            var yesterday = currentDateTime.AddDays(-1);

            Console.WriteLine("Long Date string = " + currentDateTime.ToLongDateString());
            Console.WriteLine("Short Date string = " + currentDateTime.ToShortDateString());
            Console.WriteLine("Long Time string = " + currentDateTime.ToLongTimeString());
            Console.WriteLine("Short Time string = " + currentDateTime.ToShortTimeString());
            Console.WriteLine("Date and Time = " + currentDateTime.ToString());
            Console.WriteLine("Date and Time = " + currentDateTime.ToString("yyyy-MM-dd"));

            // Time --------------------------------------------
            // Creating timespans
            var timeSpan = new TimeSpan(1, 2, 3); //(Hour, Minutes, Seconds)
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration : " + duration);

            // Accessing properties
            Console.WriteLine("Minutes = " + timeSpan.Minutes);
            Console.WriteLine("total Minutes = " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add time  = " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract time  = " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            // ToString
            Console.WriteLine("ToString = "+ timeSpan.ToString());
            // Parse
            Console.WriteLine("Parse = " + TimeSpan.Parse("01:02:03"));
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person1 person)
        {
            person.Age += 10;
        }

       

    }
}
