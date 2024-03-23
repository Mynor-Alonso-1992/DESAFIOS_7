using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        TareasManager tareasManager = new TareasManager();

        bool ejecutando = true;

        while (ejecutando)
        {
            Console.WriteLine("---- Menu ----");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        tareasManager.MostrarTareas();
                        break;
                    case 2:
                        tareasManager.AgregarTarea();
                        break;
                    case 3:
                        tareasManager.EliminarTarea();
                        break;
                    case 4:
                        ejecutando = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número correspondiente a la opción.");
            }

            Console.WriteLine();
        }
    }
}

class TareasManager
{
    static List<string> tareas = new List<string>();

    public void MostrarTareas()
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas por mostrar.");
        }
        else
        {
            Console.WriteLine("---- Tareas ----");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }
    }

    public void AgregarTarea()
    {
        Console.Write("Ingrese la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada correctamente.");
    }

    public void EliminarTarea()
    {
        MostrarTareas();

        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
            return;
        }

        Console.Write("Ingrese el número de la tarea que desea eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int indice))
        {
            if (indice >= 1 && indice <= tareas.Count)
            {
                tareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Número de tarea inválido.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número correspondiente a la tarea.");
        }
    }
}
