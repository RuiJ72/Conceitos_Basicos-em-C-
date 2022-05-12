using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Revisoes
{
    internal class Piramide
    {
        int numero = 1;

        public Piramide()
        {
            this.numero = 1;
           
        }

        public int levels;
        

        public Piramide(int levels)
        {
            
        }

        public int numberlevels
        {
            get
            {
                return this.levels;

            }
            set
            {

                if ( levels >= 1) numberlevels = this.levels;
                {
                    throw new Exception("o número atribuido não é válido para a criação de uma pirâmide");
                   
                }
            }
        }

        public void Desenha()
        {

            int Desenha = this.numberlevels;    
        

                Console.WriteLine("Insira um número");
                int Levels = int.Parse(Console.ReadLine());

                for (int i = 1; i <= Levels; i++)
                {
                    for (int j = 1; j <= Levels - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                    for (int l = i - 1; l >= 1; l--)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }


  

