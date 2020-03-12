using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {


        #region Jogo da Forca

        public static void JogoDaForca()
        {
            var pal = "australopiteco";
            var wrong = "bdfghjkmnqsvwxyz";
            int count = 1;

            for (int i = 0; i <= pal.Length; i++)
            {
                Console.WriteLine("Letra?");
                var letter = Console.ReadLine();
                if (letter == "a")
                    Console.WriteLine("boa");
                else                    
                    while (count < 7)
                    {
                        if (count == 1)
                            Console.WriteLine("------------");
                    
                    
                        else if (count == 2)
                            Console.WriteLine("------------" + "\n"
                                            + "      0     ");
                    
                    
                        else if (count == 3)
                            Console.WriteLine("------------" + "\n"
                                            + "      0     " + "\n"
                                            + "     /|     ");
                    
                    
                       else if (count == 4)
                            Console.WriteLine("------------" + "\n"
                                            + "      0     " + "\n"
                                            + "     /|\\   ");
                    
                   
                        else if (count == 5)
                            Console.WriteLine("------------" + "\n"
                                            + "      0     " + "\n"
                                            + "     /|\\   " + "\n"
                                            + "     /      ");
                    
                    
                        else if (count == 6)
                            Console.WriteLine("------------" + "\n"
                                            + "      0     " + "\n"
                                            + "     /|\\   " + "\n"
                                            + "     / \\   ");
                        count++;
                        break;
                    }
                      
            }

        }
        
        #endregion
    }
}