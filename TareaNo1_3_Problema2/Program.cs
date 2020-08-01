//   2. Crear una matriz de 3 filas por 4 columnas e ingresar valores enteros, 
//        imprimir la primera fila. 
//        Imprimir la última fila 
//        imprimir la primer columna


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_3_Problema2
{
    class ProgramaMatriz
    {
        private int[,] Matriz = new int[3, 4];

        public void IngresoValoresMatriz()
        {
            int Valor = 0, j = 0;
            // Ingresa Valores a La Matriz
            for (int i = 0; i < 3; i++)
            {
                j = 0;
                while (j < 4)
                {
                    Console.Write($"Entre el Valor Matriz[{i},{j}]=");
                    if (int.TryParse(Console.ReadLine(), out Valor) == true)
                    {
                        Matriz[i, j] = Valor;
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Error de Entrada, Intente Nuevamente.");
                    }

                }
            }




        }

        public void ImprimeFila(int Fila)
        {
            // Imprime una Fila Indicada
            Console.Write($"Valores de la Fila {Fila} : \t");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Matriz[Fila, i]+"\t");
            }
        }

        public void ImprimeColumna(int Columna)
        {
            // Imprime una Columna Indicada
            Console.WriteLine($"Valores de la Columna {Columna} : ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Matriz[i, Columna]);
            }

        }


        static void Main(string[] args)
        {
            ProgramaMatriz ProgMatriz = new ProgramaMatriz();
            int intOpcion = 0;

            while (intOpcion != 99)
            {
                Console.Clear();
                Console.WriteLine("****************************************************");
                Console.WriteLine("**  MENU DE PROGRAMA REG/IMPRESION DE MATRIZ 3x4  **");
                Console.WriteLine("****************************************************");
                Console.WriteLine("1 - Registrar Valores en la Matriz                  ");
                Console.WriteLine("2 - Imprimir Primera Fila                           ");
                Console.WriteLine("3 - Imprimir Ultima Fila                            ");
                Console.WriteLine("4 - Imprimir Primera Columna                        ");
                Console.WriteLine("99 - Para Salir                                     ");
                Console.WriteLine("****************************************************");
                if (int.TryParse(Console.ReadLine(), out intOpcion) == false)
                {
                    intOpcion = 0;
                }
                if (intOpcion == 1)
                {
                    ProgMatriz.IngresoValoresMatriz();
                }
                if (intOpcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Valores de la Primera Fila");
                    Console.WriteLine("--------------------------");
                    ProgMatriz.ImprimeFila(0);
                    Console.WriteLine("\n\nFin del Listado.\nPresione Cualquier Tecla para Volver al Menú");
                    Console.ReadKey();

                }
                if (intOpcion == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Valores de la Ultima Fila");
                    Console.WriteLine("--------------------------");
                    ProgMatriz.ImprimeFila(2);
                    Console.WriteLine("\n\nFin del Listado.\nPresione Cualquier Tecla para Volver al Menú");
                    Console.ReadKey();
                }
                if (intOpcion == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Valores de la Primera Columna");
                    Console.WriteLine("-----------------------------");
                    ProgMatriz.ImprimeColumna(0);
                    Console.WriteLine("\n\nFin del Listado.\nPresione Cualquier Tecla para Volver al Menú");
                    Console.ReadKey();
                }

            }

        }
    }
}

