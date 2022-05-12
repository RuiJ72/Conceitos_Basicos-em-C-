using CSharp_revisoes;
using CSharp_Revisoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cshapr_Revisoes
{
    internal class Program
    {
        private static object vertex1;

        public static Vertex Vertex { get; private set; }

        static void Main(string[] args)
        {


            Console.WriteLine("Digite um número ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Piramide piram = new Piramide(numero);
            Console.ReadLine();

            Console.WriteLine("Para calcular a distância euclidiana insira os respetivos valores");

            Vertex = new Vertex();
            
            Console.WriteLine("x1");
            vertex1.x1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("y1");
            Vertex.y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x2");
            Vertex.x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y2");
            vertex.y2 = Convert.ToDouble(Console.ReadLine());




        }
    }
}