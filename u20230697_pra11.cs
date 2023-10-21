using System;
using System.Runtime.CompilerServices;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\nMenu de opciones:");
                Console.WriteLine("1. Ingresar numeros");
                Console.WriteLine("2. Calcular suma de numeros");
                Console.WriteLine("3. Buscar numeros");
                Console.WriteLine("4. Ordenar numeros");
                Console.WriteLine("5. Salir");
                Console.WriteLine("\nSeleccione una opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarNumeros();
                        Console.ReadKey();
                        break;

                    case 2:
                        int suma = CalcularSuma();
                        Console.WriteLine("\nLa suma de los numeros es: " + suma);
                        Console.ReadKey();
                        break;

                    case 3:
                        BuscarNumero();
                        Console.ReadKey();
                        break;

                    case 4:
                        OrdenarNumeros();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("\nHasta pronto");
                        break;
                    default:
                        break;
                }

            } while (opcion != 5);
        } // FIN DEL MAIN
        static int[] numeros = new int[5]; // ARREGLO PARA ALMACENAR NUMEROS

        static int cantidadNumeros = 0; // CONTADOR PARA RASTREAR LA CANTIDAD DE NUMEROS INGRESADOS

        static void IngresarNumeros()
        {
            Console.WriteLine("\nIngresa hasta 5 numeros (ingresa -1 para finalizar):");
            cantidadNumeros = 0;

            while (cantidadNumeros < numeros.Length)
            {
                Console.WriteLine("Numero #{0}: ", cantidadNumeros + 1);
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                    break;

                numeros[cantidadNumeros] = numero;
                cantidadNumeros++;
            }
        } // FIN INGRESAR NUMEROS

        static int CalcularSuma()
        {
            int suma = 0;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                suma += numeros[i];
            }
            return suma;
        } // FIN CALCULAR SUMA 

        static void BuscarNumero()
        {
            Console.Write("\nIngresa el numero que deseas buscar: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Console.WriteLine("\nEl numero fue encontrado en el arreglo.");
            else
                Console.WriteLine("\nEl numero no fue encontrado en el arreglo.");

        } // FIN BUSCAR NUMERO

        static void OrdenarNumeros()
        {
            Array.Sort(numeros, 0, cantidadNumeros);
            Console.WriteLine("\nNumeros ordenados de manera ascendente");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }// FIN ORDENAR NUMEROS
    }
}
// NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
// CODIGO: U20230697