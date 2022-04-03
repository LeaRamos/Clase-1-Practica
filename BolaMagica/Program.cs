using PW3_2022_1C_Clase_1.Entidades;
using System;

namespace BolaMagica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] lista=MagicBall.listaDeRespuestas;
            

            Console.WriteLine("Bienvenido a la Bola Magica");
            Console.WriteLine("Escriba una pregunta que desee ser respondida");
            Console.WriteLine("La pregunta debe ser de respuesta de SI/NO");

            Console.WriteLine("Tu pregunta: ");
            String pregunta = Console.ReadLine();

           
            String respuesta = MagicBall.devolverRespuesta(lista);

            Console.WriteLine("Respuesta: " + respuesta);
            Console.ReadKey();
        }
    }
}
