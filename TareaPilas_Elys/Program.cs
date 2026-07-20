using System;
using System.Collections.Generic;

class AlmacenElys
{
    static void Main()
    {
        Stack<int> pilaPrincipal = new Stack<int>();
        Stack<int> pilaAuxiliar = new Stack<int>();

        pilaPrincipal.Push(10);
        pilaPrincipal.Push(20);
        pilaPrincipal.Push(30);
        pilaPrincipal.Push(40);
        pilaPrincipal.Push(50);

        Console.WriteLine("--- DESAFÍO C: SIMULADOR DE ALMACÉN ---");
        Console.WriteLine("Contenedores actuales (Tope -> Fondo): 50, 40, 30, 20, 10");

        Console.Write("\n¿Qué ID de contenedor desea retirar?: ");
        int objetivo = int.Parse(Console.ReadLine());

        bool encontrado = false;

        while (pilaPrincipal.Count > 0)
        {
            int actual = pilaPrincipal.Pop();

            if (actual == objetivo)
            {
                Console.WriteLine($"\n>> [EXITO] Contenedor {actual} extraído.");
                encontrado = true;
                break; 
            }
            else
            {
                Console.WriteLine($"[MOVIENDO] Sacando el {actual} y pasándolo a Pila Auxiliar...");
                pilaAuxiliar.Push(actual);
            }
        }

        Console.WriteLine("\n--- Reordenando el almacén (Regresando contenedores) ---");
        while (pilaAuxiliar.Count > 0)
        {
            int regresando = pilaAuxiliar.Pop();
            Console.WriteLine($"Regresando {regresando} a la pila principal.");
            pilaPrincipal.Push(regresando);
        }

        if (!encontrado) Console.WriteLine("\n[ERROR] El contenedor no existe en el almacén.");

        Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
        Console.ReadKey();
    }
}