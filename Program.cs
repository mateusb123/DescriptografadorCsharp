using System;

namespace descriptografador
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("msg: ");
                string msgCripted = Console.ReadLine();
                string allCaracters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string msgDecripted = "";
                for (int numberCaracter = 0; numberCaracter < msgCripted.Length; numberCaracter++)
                {
                    char caracter = msgCripted[numberCaracter];
                    if (caracter == '.')
                    {
                        msgDecripted += " ";
                    }
                    else
                    {
                        int numberInAllCaracters = allCaracters.IndexOf(caracter);
                        int newNumber = numberInAllCaracters - 3;
                        char newCaracterCripted = allCaracters[newNumber];
                        msgDecripted += newCaracterCripted;
                    }
                }
                Console.WriteLine(msgDecripted);
            }
        }
    }
}
