using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a Dictionary that contains information about several members of your family. Use the following example as a template.
            
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Johnny"},
                {"age", "23"}
            });

            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Susan"},
                {"age", "73"}
            });
            
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Gary"},
                {"age", "78"}
            });


            Console.WriteLine();
            Console.WriteLine("My family:");
            Console.WriteLine();
            //Next, iterate over each item in myFamily and produce the following output. Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property. "Krista is my sister and is 42 years old"
            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
                {
                   Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
                }
        Console.WriteLine();
        }
    }
}
