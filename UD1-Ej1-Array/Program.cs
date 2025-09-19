
using System;

namespace UD1_Ej1_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaración de un Array de palabras
            string[] words = new string[3];
            int count = 0;

            //Introducimos datos en el array 
            while (count < words.Length)
            {
                Console.WriteLine($"Escribe la palabra número {count+1}:");
                words[count]=Console.ReadLine();
                count++;
            }

            //Mostramos el resultado 
            Console.WriteLine("Contenido del Array:");

            foreach (string word in words)
            {

                Console.WriteLine(word);
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }


           

        }
    }
}
