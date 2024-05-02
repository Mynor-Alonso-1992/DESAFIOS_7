using System;
using System.Collections.Generic;

class TaskManager
{

    private static List<string> tasks = new List<string>();

    public static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowTasks();
                    break;
                case 2:
                    AddTask();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 0:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Mostrar tareas");
        Console.WriteLine("2. Agregar tarea");
        Console.WriteLine("3. Eliminar tarea");
        Console.WriteLine("0. Salir");
        Console.Write("Ingrese su opción: ");
    }

    private static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No hay tareas pendientes.");
            return;
        }

        Console.WriteLine("\nLista de tareas:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, tasks[i]);
        }
    }

    private static void AddTask()
    {
        Console.Write("Ingrese la nueva tarea: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Tarea agregada correctamente.");
    }

    private static void DeleteTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No hay tareas pendientes.");
            return;
        }

        ShowTasks();

        Console.Write("Ingrese el número de la tarea que desea eliminar: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Tarea eliminada correctamente.");
        }
        else
        {
            Console.WriteLine("Índice inválido. Intente de nuevo.");
        }
    }

    private static void Exit()
    {
        Console.WriteLine("Saliendo de la aplicación...");
        Environment.Exit(0);
    }
}
