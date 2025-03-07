namespace Algorithm
{
    public class fizzBuzz
    {
        public static void Algoritma1(int sayi)
        {
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 15 == 0) Console.WriteLine("fizzbuzz");
                else if (i % 3 == 0) Console.WriteLine("fizz");
                else if (i % 5 == 0) Console.WriteLine("buzz");
                else Console.WriteLine(i);
            }

        }
    }
}
