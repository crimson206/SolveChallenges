using CodelandUsernameValidation;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Test test = new Test();

            foreach(var eachtest in test.allTests)
            {
                string testName = eachtest.Method.Name;
                bool result = eachtest();

                Console.WriteLine("TestName : " + testName);
                Console.WriteLine("Result : " + result);
            }
        }
    }
}