using System;
namespace BasicCoreProgram
{
    public class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter First Number = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number = ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine("After Swap" + "\n" + "First Number Is " + a + "\n" + "Second Number Is " + b);
        }
    }
}
