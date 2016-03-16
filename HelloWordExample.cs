namespace HelloWorld  
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HelloWorldExample
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                 Console.WriteLine("Test {0}",i);
            }
            Console.WriteLine("End of Test");
        }
    }
}
