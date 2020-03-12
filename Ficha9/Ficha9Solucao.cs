using System;

namespace Ficha9
{
    public class Ficha9Solucao
    {
        #region Exercicio 1.1

        public static void Exercicio1_1()
        {
            Console.WriteLine("3 números?");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            var mult = a * b * c;
            Console.WriteLine(mult);
        }

        #endregion
        #region Exercicio 1.2

        public static void Exercicio1_2()
        {
            Console.WriteLine("2 números?");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b) + "\n"
                            + a + " - " + b + " = " + (a - b) + "\n"
                            + a + " * " + b + " = " + (a * b) + "\n"
                            + a + " / " + b + " = " + (a / b) + "\n"
                            + a + " % " + b + " = " + (a % b) + "\n");                 
        }

        #endregion
        #region Exercicio 1.3

        public static void Exercicio1_3()
        {
            Console.WriteLine("3 números?");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine(((x + y) * z) + "\n" + (x * y + y * z));
        }

        #endregion
        #region Exercicio 1.4
        
        public static void Exercicio1_4()
        {
            Console.WriteLine("Limite de nrs primos?");
            int nr = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (nr == 2)
                Console.WriteLine(nr);
            else
            {
                for (int i = 2; i < nr; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }                       
                    }
                    if(isPrime == true)
                        Console.WriteLine(i);                       
                    isPrime = true;
                }
            }
        }

        #endregion
        #region Exercicio 1.5

        public static void Exercicio1_5()
        {
            Console.WriteLine("Hello?");

            var str = Console.ReadLine();

            if (str == "Is it me you're looking for?")
                Console.WriteLine("I can see it in your eyes");
            else
                Console.WriteLine(":(");
        }
        #endregion
        #region Exercicio 1.6 x

        public static void Exercicio1_6()
        {
            Console.WriteLine("Número entre 1 e 100?");
            int a = int.Parse(Console.ReadLine());


            


        }

        #endregion
    }
}
