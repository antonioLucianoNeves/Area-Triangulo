using System;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            

            Console.WriteLine("Entre com a largura de altura do retangulo!");
            ret.altura = int.Parse(Console.ReadLine());

            ret.largura = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Area: " + ret.Area());

            Console.WriteLine("Perimetro: ");

            Console.WriteLine("Diagonal: ");

        }
    }
}
