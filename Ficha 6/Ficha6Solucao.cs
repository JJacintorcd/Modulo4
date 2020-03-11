using System;

namespace Ficha6
{
    public class Ficha6Solucao
    {
        #region Exercicio 1.1
        public static void Exercicio1()
        {
            Console.WriteLine("qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }

        /// <summary>
        /// Escreve olá
        /// </summary>
        /// <param name="nome">nome a apresentar</param>
        private static void OlaNome(string nome)
        {
            Console.WriteLine("olá " + nome);



        }
        #endregion
        #region Exercicio 1.2
        public static void Exercicio2()
        {
            Console.WriteLine("insira nr 1");
            var nr1 = Console.ReadLine();
            Console.WriteLine("insira nr 2");
            var nr2 = Console.ReadLine();
            var nr1Conv = ConverterStringNr(nr1);
            var nr2Conv = ConverterStringNr(nr2);
            SomarNr(nr1Conv, nr2Conv);

        }

        public static int ConverterStringNr(string nr)
        {
            var parseOK = int.TryParse(nr, out int parsedNr);
            return parsedNr;
        }

        public static void SomarNr(int nrA, int nrB)
        {
            Console.WriteLine(nrA + " + " + nrB + " = " + (nrA + nrB));

        }



        #endregion
        #region Exercicio 1.3

        public static int ReadNrConvert()
        {
            //Console.WriteLine("nr?");
            var nr = Console.ReadLine();
            return ConverterStringNr(nr);
        }

        public static void Exercicio3()
        {
            var nr1 = ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            nr1 += ReadNrConvert();
            Console.WriteLine(nr1);
        }







        #endregion
        #region Exercicio 1.4

        public static void Exercicio4()
        {
            Console.WriteLine("nr1 e nr2?");
            var nr1 = Console.ReadLine();
            var nr2 = Console.ReadLine();
            var nr3 = ""; 
           
            nr3 = nr1;
            nr1 = nr2;
            nr2 = nr3;

            Console.WriteLine("A = " + nr1 + " " + "B = " + nr2);
        }

        #endregion
        #region Exercicio 1.5

        public static void Exercicio5()
        {
            Console.WriteLine("introduzir valores para A");
            var a = ReadNrConvert(); 
            Console.WriteLine("introduzir valores para B");
            var b = ReadNrConvert();
            Console.WriteLine("introduzir valores para C");
            var c = ReadNrConvert();
            
            var alineaA = (-a) + b * c;
            Console.WriteLine(alineaA);
        }



        #endregion
        #region Exercicio 1.6

        public static void Exercicio6()
        {
            Console.WriteLine("nr para tabuada?");
            var a = ReadNrConvert();
            var b = a * 2;
            var c = a * 3;
            var d = a * 4;
            var e = a * 5;
            var f = a * 6;
            var g = a * 7;
            var h = a * 8;
            var i = a * 9;
            var j = a * 10;

            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e + "\n" + f + "\n" + g + "\n" + h + "\n" + i + "\n" + j);

        }
        #endregion
        #region Exercicio 1.7
        public static void Exercicio7()
        {
            Console.WriteLine("dois nrs?");
            var a = ReadNrConvert();
            var b = ReadNrConvert();

            var media = (a + b) / 2;
            Console.WriteLine(media);
           }

        #endregion
        #region Exercicio 1.8
        public static void Exercicio8()
        {
            Console.WriteLine("cinco nrs?");
            var a = ReadNrConvert();
            var b = ReadNrConvert();
            var c = ReadNrConvert();
            var d = ReadNrConvert();
            var e = ReadNrConvert();

            var media = (a + b + c + d + e) / 5;
            Console.WriteLine(media);
        }
        #endregion
        #region Exercicio 1.9
        public static void Exercicio9()
        {
            Console.WriteLine("dez nrs?");
            var a = ReadNrConvert();
            var b = ReadNrConvert();
            var c = ReadNrConvert();
            var d = ReadNrConvert();
            var e = ReadNrConvert();
            var f = ReadNrConvert();
            var g = ReadNrConvert();
            var h = ReadNrConvert();
            var i = ReadNrConvert();
            var j = ReadNrConvert();


            var media = (a + b + c + d + e + f + g + h + i + j) / 10;
            Console.WriteLine(media);
        }
        #endregion
        #region Exercicio 1.10

        public static void Exercicio10()
        {
            Console.WriteLine("tabela 3x3");
            var c = Console.ReadLine();
            Console.WriteLine(c + " " + c + " " + c + "\n" + c + " " + c + " " + c + "\n" + c + " " + c + " " + c);
        }

        #endregion
        #region Exercicio 1.11

        public static double PreçoDecimal(string nr)
        {
            var parseOK = double.TryParse(nr,out double parsedNr);
            return parsedNr;
        }
        public static double ReadPreço()
        {
            var nr = Console.ReadLine();
            return PreçoDecimal(nr);
        }

        public static void Exercicio11()
        {
            Console.WriteLine("nome prod 1?");
            var nome1 = Console.ReadLine();
            Console.WriteLine("preço prod 1?");
            var price1 = ReadPreço();
            Console.WriteLine("quant prod 1?");
            var quant1 = ReadPreço();
            var custoProduto1 = price1 * quant1;
           
            Console.WriteLine("nome prod 2?");
            var nome2 = Console.ReadLine();
            Console.WriteLine("preço prod 3?");
            var price2 = ReadPreço();
            Console.WriteLine("quant prod 4?");
            var quant2 = ReadPreço();
            var custoProduto2 = price2 * quant2;
            
            var custoTotal = custoProduto1 + custoProduto2;
            Console.WriteLine(nome1 + " = " + custoProduto1 + "\n" + nome2 + " = " + custoProduto2 + "\n" + "o total das compras é = " + custoTotal);
        }
        #endregion
        #region Exercicio 2.1

        public static void Exercicio2_1()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            var algo = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + algo);
        }


        #endregion
        #region Exercicio 2.2

        public static void Exercicio2_2()
        {
            Console.WriteLine("dois nrs?");
            var n1 = Console.ReadLine();
            var n2 = Console.ReadLine();
            Console.WriteLine("o primeiro nr é " + n1 + " e o segundo nr é " + n2);
        }

        #endregion
        #region Exercicio 2.3

        public static void Exercicio2_3()
        {
            Console.WriteLine("Temperatura?");
            var tempC = ReadNrConvert();
            var tempF = tempC * 9 / 5 + 32;
            var tempK = tempC + 273.15;
            Console.WriteLine("A temperatura " + tempC + "ºC" + " é " + tempF + "ºF em Farenheit e " + tempK + "ºK em Kelvin");
        }

        #endregion
        #region Exercicio 3.1

        public static void Exercicio3_1()
        {
            Console.WriteLine("Quantas horas?");
            var horas = ReadNrConvert();
            Console.WriteLine("Quantos minutos?");
            var min = ReadNrConvert();
            Console.WriteLine("Quantos segundos?");
            var seg = ReadNrConvert();

            var total = horas * 3600 + min * 60 + seg;
            Console.WriteLine(horas + ":" + min + ":" + seg + ":" + " equivale a " + total + " segundos");
        }

        #endregion
        #region Exercicio3.2

        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual é o raio?");
            var raio = ReadPreço();
            var per = 2 * 3.14 * raio;
            var area = 3.14 * raio * raio;
            Console.WriteLine("A área do circulo é " + area + " e o perimetro é " + per);
        }

        #endregion
    }
}
