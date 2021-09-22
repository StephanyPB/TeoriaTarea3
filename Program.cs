using System;
using System.Collections.Generic;
using System.Text;


namespace TeoriaTarea3
{
    class Program
    {
        // Esta es la función principal del programa
        // Aquí inicia la aplicacion
        static void Main(string[] args)
        {
            Console.WriteLine("Elija una opcion: \n 1-Capitulo 6. \n 2-Capitulo 7. \n3-Salir \n");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    int cantidad = 0; // Cantidad de alumnos
                    int n = 0; // Variable de control de ciclo
                    string valor = "";
                    
                    float suma = 0f;
                    double promedio = 0f;
                    float minima = 100;
                    float maxima = 0f; 

                    // Pedimos la cantidad de alumnos
                    Console.WriteLine("Dame la cantidad de alumnos");
                    valor = Console.ReadLine();
                    cantidad = Convert.ToInt32(valor);
                    float[] calif = new float[cantidad];

                    for (n = 0; n < cantidad; n++)
                    {
                        Console.Write("Dame la calificación ");
                        valor = Console.ReadLine();
                        calif[n] = Convert.ToSingle(valor);
                        suma += calif[n];
                    }

                    promedio = suma / cantidad;
                    for (n = 0; n < cantidad; n++)
                    {
                        if (calif[n] > maxima)
                            maxima = calif[n];
                    }
                    for (n = 0; n < cantidad; n++)
                    {
                        if (calif[n] < minima)
                            minima = calif[n];
                    }
                    promedio = Math.Round(promedio);
                    // Desplegamos los resultados
                    Console.Clear();
                    Console.WriteLine("Cantidad de Alumnos: " + cantidad);
                    Console.WriteLine("El promedio es: " + promedio);
                    Console.WriteLine("La calificación mínima es: " + minima);
                    Console.WriteLine("La calificación máxima es: " + maxima);
                    break;
                case 2:
                    

            
        
                    break;
                case 3:
                    break;
            }
        }
    }
}

