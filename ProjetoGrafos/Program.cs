using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrafos
{
    class Program
    {
        static void Main(string[] args)

        {
            int op = 0, loop = 0, vertices = 0, linha = 0, coluna = 0;

            Console.WriteLine("Digite 1 para Grafo ou 2 Para Digrafo");
            op = int.Parse( Console.ReadLine());
            Console.WriteLine("Informe a Quantidade de Vertices");
            vertices = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de Arestas");
            loop = int.Parse(Console.ReadLine());
            int [ , ] mat = new int[vertices,vertices];
            if (op == (1)) {
                for(int i = 0; i < loop; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Informe o Vertice que sera ligado. ");
                    linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o Vertice que recebera a ligação. ");
                    coluna =int.Parse( Console.ReadLine());

                    if (linha == coluna)
                    { // recursão
                        mat[linha - 1,coluna - 1] = 1;
                    }
                    else
                    {
                        mat[linha -1,coluna -1] = 1;
                        mat[coluna - 1,linha - 1] = 1;
                    }
                   
                }
                mostrarMatriz(vertices, mat);


            } else if (op.Equals(2))
            {
                for (int i = 0; i < loop; i++)
                    Console.Clear();
                {
                    Console.WriteLine("Informe o Vertice que sera ligado. ");
                    linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o Vertice que recebera a ligação. ");
                    coluna = int.Parse(Console.ReadLine());

                    if (linha == coluna)
                    { // recursão
                        mat[linha - 1, coluna - 1] = 1;
                    }
                    else
                    {
                        mat[linha - 1, coluna - 1] = 1;
                       // mat[coluna - 1, linha - 1] = 1;
                    }

                }
                mostrarMatriz(vertices, mat);


            }

        }



        
        public static void mostrarMatriz(int v, int [,]ma)
        {
            Console.Clear();
            Console.WriteLine("############################## MATRIZ #######################");
           
            Console.WriteLine("");
            for (int i = 0; i < v; i++)
            {
                for (int j = 0; j < v; j++)
                {
                    Console.Write(ma[i,j]+"\t");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

    }
    
}
