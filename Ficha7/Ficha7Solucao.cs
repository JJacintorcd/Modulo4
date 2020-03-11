using System;

namespace Ficha7
{
    public class Ficha7Solucao
    {
        #region Exercicio 1.1
        public static void Exercicio1_1()
        {
            Console.WriteLine("Qual a nota?");
            var nota = double.Parse(Console.ReadLine());
            if (nota > 9.44)
                Console.WriteLine("Passou");
            else
                Console.WriteLine("Chumbou");      
        }

        #endregion
        #region Exercicio 1.2

        public static void Exercicio1_2()
        {
            Console.WriteLine("Qual o seu peso?");
            var peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura?");
            var altura = double.Parse(Console.ReadLine());
            var bmi = peso / (altura*altura);

            if (bmi <= 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (bmi > 18.5 && bmi <= 24.9)
                Console.WriteLine("Normal");
            else if (bmi > 24.9 && bmi <= 29.9)
                Console.WriteLine("Acima do peso");
            else
                Console.WriteLine("Obeso");

        }

        #endregion
        #region Exercicio 1.3

        public static void Exercicio1_3()
        {
            Console.WriteLine("nr divisível por 3 ou 7");
            var nr = int.Parse(Console.ReadLine());

            if (nr % 3 == 0 && nr % 7 == 0)
                Console.WriteLine("múltiplo de 3 e 7");
            else if (nr % 3 == 0)
                Console.WriteLine("múltiplo de 3");
            else if (nr % 7 == 0)
                Console.WriteLine("múltiplo de 7");
            else 
                Console.WriteLine("não é multiplo de 3 nem 7");
        }

        #endregion
        #region Exercicio 1.5

        public static void Exercicio1_5()
        {
            Console.WriteLine("nr entre 10 e 20 exclusive");
            var nr = int.Parse(Console.ReadLine());

            if (nr > 10 && nr < 20)
                Console.WriteLine("válido");
            else
                Console.WriteLine("inválido");
        }

        #endregion
        #region Exercicio 1.6

        public static void Exercicio1_6()
        {
            Console.WriteLine("Qual o piso?");
            var piso = int.Parse(Console.ReadLine());
            if (piso < (-2) || piso > 6 || piso == 3 || piso == 5)
                Console.WriteLine("Indisponível");
            else
                Console.WriteLine("Indo para o " + piso + "º piso");
        }

        #endregion
        #region Exercicio 1.7

        public static void Exercicio1_7()
        {
            var cont = 0;
            var soma = 0;
            for (cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("nr?");
                var nr = int.Parse(Console.ReadLine());
                soma += nr;
            }        
            Console.WriteLine(soma);
        }
        #endregion
        #region Exercicio 1.8

        public static void Exercicio1_8()
        {
            var str = "";
            var total = 0;
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("nome do prod?");
                var nome = Console.ReadLine();
                Console.WriteLine("preço do prod?");
                var price = int.Parse(Console.ReadLine());
                Console.WriteLine("quantidade do prod?");
                var quant = int.Parse(Console.ReadLine());
                var subTotal = price * quant;
                str += nome + " " + subTotal + "\n";
                total += subTotal;  
            }
            Console.WriteLine("o total é " + total);
        }

        #endregion
        #region Exercicio 1.9

        public static void Exercicio1_9()
        {
            var counter = 0;
            var total = 0;
            int nr;
           
            do
            {
                Console.WriteLine("nr?");
                nr = int.Parse(Console.ReadLine());
                if (nr != 0)
                {
                    total += nr;
                    counter++;
                }
            }
            while (nr != 0);

            Console.WriteLine(total / counter);                              
        }
        #endregion
        #region Exercicio 1.10

        public static void Exercicio1_10()
        {
            Console.WriteLine("nr 1?");
            var nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nr 2?");
            var nr2 = int.Parse(Console.ReadLine());

            Console.WriteLine("operação");            
            var op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine(nr1 + nr2);
                    break;
                case "-":
                    Console.WriteLine(nr1 - nr2);
                    break;
                case "*":
                    Console.WriteLine(nr1 * nr2);
                    break;
                case "/":
                    Console.WriteLine(nr1 / nr2);
                    break;
                case "%":
                    Console.WriteLine(nr1 % nr2);
                    break;
                default:
                    Console.WriteLine("nop");
                    break;                
            }           
        }

        #endregion
        #region Exercicio 1.11

        public static void Exercicio1_11()
        {
            Console.WriteLine("insira caracter");
            var c = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c + " ");                    
                }
                
                Console.Write("\n");
            }
        }

        #endregion
        #region Exercicio 1.12

        public static void Exercicio1_12()
        {
            Console.WriteLine("letra?");
            var c = Console.ReadLine();
            Console.WriteLine("nr?");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c + " ");                   
                }

                Console.Write("\n");
            } 

        }

        #endregion
        #region Exercicio 1.13

        public static void Exercicio1_13()
        {
            Console.WriteLine("1º nr?");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2º nr?");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1º car?");
            var c1 = Console.ReadLine();
            Console.WriteLine("2º car?");
            var c2 = Console.ReadLine();

            var count = 0;
            for(int i = 0; i < n1; i++)
            {
                for(int j = 0; j < n2; j++)
                {
                    if (count % 2 == 0)
                        Console.Write(c1);
                    else
                    {
                        Console.Write(c2);
                    }
                    count++;
                }
                Console.Write("\n");

            }

        }

        #endregion
        #region Exercicio 2.1

        public static void Exercicio2_1()
        {
            Console.WriteLine("Temperatura?");
            var temp = double.Parse(Console.ReadLine());
            var escala = "";

            while (escala != "C" && escala != "K" && escala != "F")
            {
                Console.WriteLine("Em que escala? (K, F, C)");
                var conv = Console.ReadLine();

                switch (conv)
                {
                    case "C":
                        Console.WriteLine(temp + "ºC é equivalente a " + (temp + 273.15) + "ºK e " + (temp * (9 / 5) + 32) + "ºF");
                        break;
                    case "K":
                        Console.WriteLine(temp + "ºK é equivalente a " + (temp - 273.15) + "ºC e " + (temp * (9 / 5) -459.67) + "ºF");
                        break;
                    case "F":
                        Console.WriteLine(temp + "ºF é equivalente a " + (temp - 32) + "ºC e " + ((temp - 32) * 5/9) + "ºK");
                        break;
                }
                break;
            }

        }

        #endregion
        #region Exercicio 2.2

        public static void Exercicio2_2()
        {
            Console.WriteLine("Número limite?");
            var num = double.Parse(Console.ReadLine());

            for (var cont = 0; cont < num; cont++)
            {
                if (cont % 2 == 1)
                    Console.WriteLine(cont);
            }
        }

        #endregion
        #region Exercicio 2.3
        
        public static void Exercicio2_3()
        {
            var caracs = "";
            var carac = "";

            do
            {
                Console.WriteLine("Número? Para terminar, 'enter'");
                carac = Console.ReadLine();
                caracs += carac;
            }
            while (carac != "");            
                Console.WriteLine(caracs);           
        }
        #endregion
        #region Exercicio 3.1

        public static void Exercicio3_1()
        {
            Console.WriteLine("Numero?");
            var nr = int.Parse(Console.ReadLine());

            if (nr % 2 == 0)
                Console.WriteLine(nr * 3);
            else
                Console.WriteLine(nr * 2);
        }

        #endregion
        #region Exercicio 3.2

        public static void Exercicio3_2()
        {
            Console.WriteLine("Dimensão do triângulo?");
            var n = int.Parse(Console.ReadLine());
            int i = 1;

            while (n > 0)
            {
                n--;
                int a = 0;
                while (a != n)
                {
                    Console.Write(" ");
                    a++;
                }
                int b = 0;
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }
                i += 2;
                Console.Write("\n");
            }
        }

        #endregion


    }
}
