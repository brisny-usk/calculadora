using System;

namespace Calculadoramatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Seleccione la operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese su opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    Console.WriteLine("Saliendo de la calculadora.");
                    break;
                }

                if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                {
                    Console.Write("Ingrese el primer número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double resultado = 0;

                    if (opcion == "1")
                    {
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado de sumar {num1} y {num2} es: {resultado}");
                    }
                    else if (opcion == "2")
                    {
                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado de restar {num1} y {num2} es: {resultado}");
                    }
                    else if (opcion == "3")
                    {
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado de multiplicar {num1} y {num2} es: {resultado}");
                    }
                    else if (opcion == "4")
                    {
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"El resultado de dividir {num1} entre {num2} es: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre 0.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                }
            }
        }
    }
}